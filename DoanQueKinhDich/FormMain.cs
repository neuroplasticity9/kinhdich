using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormMain : Form, IQue
    {
        private string _queChuUrl;
        private string _queBienUrl;

        public FormMain()
        {
            InitializeComponent();
        }

        public bool IsDone { get; private set; } = false;

        public bool Hao1 => chkHao1.Checked;

        public bool Hao2 => chkHao2.Checked;

        public bool Hao3 => chkHao3.Checked;

        public bool Hao4 => chkHao4.Checked;

        public bool Hao5 => chkHao5.Checked;

        public bool Hao6 => chkHao6.Checked;

        public bool Hao1Dong => chkHao1Dong.Checked;

        public bool Hao2Dong => chkHao2Dong.Checked;

        public bool Hao3Dong => chkHao3Dong.Checked;

        public bool Hao4Dong => chkHao4Dong.Checked;

        public bool Hao5Dong => chkHao5Dong.Checked;

        public bool Hao6Dong => chkHao6Dong.Checked;

        public CanChi NgayAm => GetNhatThan();

        public CanChi ThangAm => GetNguyetKien();

        private void btnGo_Click(object sender, EventArgs e)
        {
            var queService = new QueService(this);

            linkQueChu.Visible = true;
            linkQueChu.Text = $"{queService.QueChu.NameShort} - Quẻ số {queService.QueChu.QueId}";
            _queChuUrl = GetUrl(queService.QueChu.Name, queService.QueChu.QueId);

            if (CoQueBien())
            {
                string queChuString = queService.GetQueChuVaQueBienDesc();
                txtQueChu.Text = queChuString;

                linkQueBien.Visible = true;
                linkQueBien.Text = $"{queService.QueBien.NameShort} - Quẻ số {queService.QueBien.QueId}";
                _queBienUrl = GetUrl(queService.QueBien.Name, queService.QueBien.QueId);
            }
            else
            {
                linkQueBien.Visible = false;
                string queChuString = queService.GetQueDesc();
                txtQueChu.Text = queChuString;
            }
        }

        private string GetUrl(string name, int queId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "http://cohoc.net/64-que-dich.html";
            }

            return $"http://cohoc.net/{name.Replace(" ", "-")}-kid-{queId}.html";
        }

        private bool CoQueBien()
        {
            return chkHao6Dong.Checked || chkHao5Dong.Checked || chkHao4Dong.Checked ||
                   chkHao3Dong.Checked || chkHao2Dong.Checked || chkHao1Dong.Checked;
        }

        private CanChi GetNguyetKien()
        {
            return GetCanChi(cbxThangCan.SelectedIndex, cbxThangChi.SelectedIndex);
        }

        private CanChi GetNhatThan()
        {
            return GetCanChi(cbxNgayCan.SelectedIndex, cbxNgayChi.SelectedIndex);
        }

        private CanChi GetCanChi(int canIndex, int chiIndex)
        {
            return new CanChi
            {
                Can = ThienCan.GetCan(canIndex + 1),
                Chi = DiaChi.GetChi(chiIndex + 1),
            };
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            linkQueChu.Visible = false;
            linkQueBien.Visible = false;

            cbxNgoaiQuai.SelectedIndex = 0;
            cbxNoiQuai.SelectedIndex = 0;

            SetNgayThangComboboxes(DateTime.Now);
        }

        private void SetNgayThangComboboxes(DateTime ngayLayQue)
        {
            CanChi ngayAm = ngayLayQue.ToAmLich().GetCanChiNgay();
            CanChi thangAm = ngayLayQue.ToAmLich().GetCanChiThang();

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

        private void chkHao6_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao6);
            UpdateNgoaiQuai();
        }

        private void chkHao5_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao5);
            UpdateNgoaiQuai();
        }

        private void chkHao4_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao4);
            UpdateNgoaiQuai();
        }

        private void chkHao3_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao3);
            UpdateNoiQuai();
        }

        private void chkHao2_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao2);
            UpdateNoiQuai();
        }

        private void chkHao1_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao1);
            UpdateNoiQuai();
        }

        private void UpdateNgoaiQuai()
        {
            FormUtils.UpdateBatQuai(cbxNgoaiQuai, chkHao6, chkHao5, chkHao4);
        }

        private void UpdateNoiQuai()
        {
            FormUtils.UpdateBatQuai(cbxNoiQuai, chkHao3, chkHao2, chkHao1);
        }

        private void cbxNgoaiQuai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cung cung = BatQuai.All[cbxNgoaiQuai.SelectedIndex];
            chkHao6.Checked = cung.Duong3;
            chkHao5.Checked = cung.Duong2;
            chkHao4.Checked = cung.Duong1;
        }

        private void cbxNoiQuai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cung cung = BatQuai.All[cbxNoiQuai.SelectedIndex];
            chkHao3.Checked = cung.Duong3;
            chkHao2.Checked = cung.Duong2;
            chkHao1.Checked = cung.Duong1;
        }

        private void LoadQue(IQue que)
        {
            if (que.IsDone)
            {
                chkHao6.Checked = que.Hao6;
                chkHao5.Checked = que.Hao5;
                chkHao4.Checked = que.Hao4;
                chkHao3.Checked = que.Hao3;
                chkHao2.Checked = que.Hao2;
                chkHao1.Checked = que.Hao1;

                chkHao6Dong.Checked = que.Hao6Dong;
                chkHao5Dong.Checked = que.Hao5Dong;
                chkHao4Dong.Checked = que.Hao4Dong;
                chkHao3Dong.Checked = que.Hao3Dong;
                chkHao2Dong.Checked = que.Hao2Dong;
                chkHao1Dong.Checked = que.Hao1Dong;

                cbxNgayCan.SelectedIndex = que.NgayAm.Can.Id - 1;
                cbxNgayChi.SelectedIndex = que.NgayAm.Chi.Id - 1;

                cbxThangCan.SelectedIndex = que.ThangAm.Can.Id - 1;
                cbxThangChi.SelectedIndex = que.ThangAm.Chi.Id - 1;

                btnGo.PerformClick();
            }
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
            Clipboard.SetText(txtQueChu.Text);
        }

        private void btnLayQue_Click(object sender, EventArgs e)
        {
            var formLayQue = new FormQueTungXu();

            formLayQue.ShowDialog(this);

            LoadQue(formLayQue);
        }

        private void btnLayQueTheoNgay_Click(object sender, EventArgs e)
        {
            var formLayQue = new FormQueThoiGian();

            formLayQue.ShowDialog(this);

            LoadQue(formLayQue);
        }
    }
}
