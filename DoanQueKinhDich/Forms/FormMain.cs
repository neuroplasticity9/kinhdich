using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormMain : Form, IQueLayDuoc
    {
        private string _queChuUrl;
        private string _queHoUrl;
        private string _queBienUrl;
        private FormQueThoiGian _formQueThoiGian = new FormQueThoiGian();

        public FormMain()
        {
            InitializeComponent();
        }
        public bool Hao6 => ucQueDich.Hao6; 
        public bool Hao5 => ucQueDich.Hao5; 
        public bool Hao4 => ucQueDich.Hao4; 
        public bool Hao3 => ucQueDich.Hao3; 
        public bool Hao2 => ucQueDich.Hao2; 
        public bool Hao1 => ucQueDich.Hao1; 

        public bool Hao6Dong => ucQueDich.Hao6Dong; 
        public bool Hao5Dong => ucQueDich.Hao5Dong; 
        public bool Hao4Dong => ucQueDich.Hao4Dong; 
        public bool Hao3Dong => ucQueDich.Hao3Dong; 
        public bool Hao2Dong => ucQueDich.Hao2Dong; 
        public bool Hao1Dong => ucQueDich.Hao1Dong;

        public CachLayQue CachLayQue { get; private set; } = CachLayQue.Manual;
        public NgayLayQue NgayLayQue => GetNgayLayQue();
        public bool IsDone { get; private set; } = false;
        public AmLich AmLich { get; set; }

        private bool _isFirstLoadFinished;
        private bool _disableNgayThangChange;

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            linkQueChu.Visible = false;
            linkQueBien.Visible = false;

            SetNgayThangComboboxes(DateTime.Now);
            _isFirstLoadFinished = true;

            this.ucQueDich.CheckedChanged += new System.EventHandler(ucQueDich_CheckedChanged);
            SetQueDefault();
        }

        private void SetQueDefault()
        {
            AmLich = _formQueThoiGian.AmLich;
            LoadQue(_formQueThoiGian);
            radVietDich.Checked = true;
        }

        private void DisplayQueToUI()
        {
            if (!_isFirstLoadFinished)
            {
                return;
            }

            QueService queService = null;
            if (radLucHao.Checked)
            {
                queService = new LucHaoQueService(this);
            }
            else if (radMaiHoa.Checked)
            {
                queService = new MaiHoaQueService(this);
            }
            else
            {
                queService = new VietDichQueService(this);
            }

            linkQueChu.Visible = true;
            linkQueChu.Text = GetNameForLink(queService.QueChu);
            _queChuUrl = GetUrl(queService.QueChu.Name, queService.QueChu.QueId);

            if (radLucHao.Checked)
            {
                linkQueHo.Visible = false;
                linkQueBien.Location = new System.Drawing.Point(1081, linkQueChu.Location.Y);
            }
            else
            {
                linkQueBien.Location = new System.Drawing.Point(1147, linkQueChu.Location.Y);
            }
            
            txtQueDesc.Text = queService.GetQueDesc();

            if (this.CoQueBien())
            {
                linkQueBien.Visible = true;
                linkQueBien.Text = GetNameForLink(queService.QueBien);
                _queBienUrl = GetUrl(queService.QueBien.Name, queService.QueBien.QueId);

                if (!radLucHao.Checked)
                {
                    linkQueHo.Visible = true;
                    linkQueHo.Text = GetNameForLink(queService.QueHo);
                    _queHoUrl = GetUrl(queService.QueHo.Name, queService.QueHo.QueId);
                }
            }
            else
            {
                linkQueBien.Visible = false;
            }
        }

        private NgayLayQue GetNgayLayQue()
        {
            if (CachLayQue == CachLayQue.Manual)
            {
                return new NgayLayQue(GetNhatThan(), GetNguyetKien());
            }
            
            return AmLich.ToNgayLayQue();
        }

        private string GetNameForLink(Que que)
        {
            var result = $"{que.NameShort} {que.NameChinese} - Quẻ {que.QueId}";

            if (que.QueThuan != null)
            {
                result += $" thuộc {que.QueThuan.NameShort} {que.QueThuan.NameChinese}";
            }

            return result;
        }

        private string GetUrl(string name, int queId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "http://cohoc.net/64-que-dich.html";
            }

            return $"http://cohoc.net/{name.Replace(" ", "-")}-kid-{queId}.html";
        }

        private CanChi GetNguyetKien()
        {
            return FormUtils.GetCanChi(cbxThangCan, cbxThangChi);
        }

        private CanChi GetNhatThan()
        {
            return FormUtils.GetCanChi(cbxNgayCan, cbxNgayChi);
        }

        private void ucQueDich_CheckedChanged(object sender, EventArgs e)
        {
            DisplayQueToUI();
        }

        private void SetNgayThangComboboxes(DateTime ngayLayQue)
        {
            CanChi ngayAm = ngayLayQue.ToAmLich().NgayAm;
            CanChi thangAm = ngayLayQue.ToAmLich().ThangAm;

            cbxNgayCan.SelectedIndex = ngayAm.Can.Id - 1;
            cbxNgayChi.SelectedIndex = ngayAm.Chi.Id - 1;
            cbxThangCan.SelectedIndex = thangAm.Can.Id - 1;
            cbxThangChi.SelectedIndex = thangAm.Chi.Id - 1;
        }

        private void linkQueChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_queChuUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void linkQueHo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_queHoUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void linkQueBien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_queBienUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadQue(IQueLayDuoc que)
        {
            this.CachLayQue = que.CachLayQue;

            ucQueDich.uiHao6.Checked = que.Hao6;
            ucQueDich.uiHao5.Checked = que.Hao5;
            ucQueDich.uiHao4.Checked = que.Hao4;
            ucQueDich.uiHao3.Checked = que.Hao3;
            ucQueDich.uiHao2.Checked = que.Hao2;
            ucQueDich.uiHao1.Checked = que.Hao1;

            ucQueDich.uiIsHao6Dong.Checked = que.Hao6Dong;
            ucQueDich.uiIsHao5Dong.Checked = que.Hao5Dong;
            ucQueDich.uiIsHao4Dong.Checked = que.Hao4Dong;
            ucQueDich.uiIsHao3Dong.Checked = que.Hao3Dong;
            ucQueDich.uiIsHao2Dong.Checked = que.Hao2Dong;
            ucQueDich.uiIsHao1Dong.Checked = que.Hao1Dong;

            _disableNgayThangChange = true;
            cbxNgayCan.SelectedIndex = AmLich.NgayAm.Can.Id - 1;
            cbxNgayChi.SelectedIndex = AmLich.NgayAm.Chi.Id - 1;

            cbxThangCan.SelectedIndex = AmLich.ThangAm.Can.Id - 1;
            cbxThangChi.SelectedIndex = AmLich.ThangAm.Chi.Id - 1;
            _disableNgayThangChange = false;
        }

        private void linkAmLich_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://lichvannien.vietbao.vn/");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtQueDesc.Text);
        }

        private void btnTungXuLayQue_Click(object sender, EventArgs e)
        {
            var formLayQue = new FormQueTungXu();

            formLayQue.ShowDialog(this);

            if (formLayQue.IsDone)
            {
                AmLich = formLayQue.AmLich;
                LoadQue(formLayQue);
                radLucHao.Checked = true;
            }
        }

        private void btnLayQueMaiHoa_Click(object sender, EventArgs e)
        {
            _formQueThoiGian.IsDone = false;
            _formQueThoiGian.ShowDialog(this);

            if (_formQueThoiGian.IsDone)
            {
                AmLich = _formQueThoiGian.AmLich;
                LoadQue(_formQueThoiGian);
                radVietDich.Checked = true;
            }
        }

        /// <summary>
        /// Event for 2 radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radMaiHoa_CheckedChanged(object sender, EventArgs e)
        {
            DisplayQueToUI();
        }

        private void cbxThangCan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_disableNgayThangChange)
            {
                return;
            }

            var combobox = sender as ComboBox;
            var comboboxToUpdate = cbxThangChi;
            CapNhatChi(combobox, comboboxToUpdate);
            CachLayQue = CachLayQue.Manual;
            DisplayQueToUI();
        }

        private void cbxThangChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_disableNgayThangChange)
            {
                return;
            }

            var combobox = sender as ComboBox;
            var comboboxToUpdate = cbxThangCan;
            CapNhatCan(combobox, comboboxToUpdate);
            CachLayQue = CachLayQue.Manual;
            DisplayQueToUI();
        }

        private void cbxNgayCan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_disableNgayThangChange)
            {
                return;
            }

            var combobox = sender as ComboBox;
            var comboboxToUpdate = cbxNgayChi;
            CapNhatChi(combobox, comboboxToUpdate);
            CachLayQue = CachLayQue.Manual;
            DisplayQueToUI();
        }

        private void cbxNgayChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_disableNgayThangChange)
            {
                return;
            }

            var combobox = sender as ComboBox;
            var comboboxToUpdate = cbxNgayCan;
            CapNhatCan(combobox, comboboxToUpdate);
            CachLayQue = CachLayQue.Manual;
            DisplayQueToUI();
        }

        /// <summary>
        /// Nếu chọn can thì phải cập nhật lại chi.
        /// </summary>
        /// <param name="combobox"></param>
        /// <param name="comboboxToUpdate"></param>
        private void CapNhatChi(ComboBox combobox, ComboBox comboboxToUpdate)
        {
            ThienCan selectedCan = ThienCan.All[combobox.SelectedIndex];
            DiaChi firstChi = CanChi.GetChiDauTienHopLe(selectedCan);

            if (comboboxToUpdate.SelectedIndex < 0)
            {
                comboboxToUpdate.SelectedIndex = firstChi.Id - 1;
            }
            else
            {
                DiaChi currentChi = DiaChi.All[comboboxToUpdate.SelectedIndex];
                // Cập nhật chi nếu khác loại âm dương.
                if (currentChi.Duong != firstChi.Duong)
                {
                    comboboxToUpdate.SelectedIndex = firstChi.Id - 1;
                }
            }
        }

        /// <summary>
        /// Nếu chọn chi thì phải cập nhật lại can.
        /// </summary>
        /// <param name="combobox"></param>
        /// <param name="comboboxToUpdate"></param>
        private void CapNhatCan(ComboBox combobox, ComboBox comboboxToUpdate)
        {
            DiaChi selectedChi = DiaChi.All[combobox.SelectedIndex];
            ThienCan firstCan = CanChi.GetCanDauTienHopLe(selectedChi);

            if (comboboxToUpdate.SelectedIndex < 0)
            {
                comboboxToUpdate.SelectedIndex = firstCan.Id - 1;
            }
            else
            {
                ThienCan currentCan = ThienCan.All[comboboxToUpdate.SelectedIndex];
                // Cập nhật chi nếu khác loại âm dương.
                if (currentCan.Duong != firstCan.Duong)
                {
                    comboboxToUpdate.SelectedIndex = firstCan.Id - 1;
                }
            }
        }
    }
}
