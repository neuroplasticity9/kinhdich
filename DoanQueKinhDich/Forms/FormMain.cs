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

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            _isFirstLoadFinished = true;

            this.ucQueDich.CheckedChanged += new System.EventHandler(ucQueDich_CheckedChanged);
            SetQueDefault();
        }

        private void SetQueDefault()
        {
            AmLich = _formQueThoiGian.AmLich;
            LoadQue(_formQueThoiGian);
        }

        private void DisplayQueToUI()
        {
            if (!_isFirstLoadFinished)
            {
                return;
            }

            var queService = new VietDichQueService(this);
            txtQueDesc.Text = queService.GetQueDesc();
        }

        private NgayLayQue GetNgayLayQue()
        {
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

        private void ucQueDich_CheckedChanged(object sender, EventArgs e)
        {
            DisplayQueToUI();
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

        private void btnLayQue_Click(object sender, EventArgs e)
        {
            _formQueThoiGian.IsDone = false;
            _formQueThoiGian.ShowDialog(this);

            if (_formQueThoiGian.IsDone)
            {
                AmLich = _formQueThoiGian.AmLich;
                LoadQue(_formQueThoiGian);
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

        private void btnHoc_Click(object sender, EventArgs e)
        {
            var form = new FormQueHoc();

            form.ShowDialog(this);
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnLayQue.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnHoc.PerformClick();
            }
            else if (e.KeyCode == Keys.F12)
            {
                var formTimTen = new FormTimTen();
                formTimTen.ShowDialog(this);
            }
        }
    }
}
