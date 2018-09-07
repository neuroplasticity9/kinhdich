using DoanQueKinhDich.Business;
using KinhDichCommon;
using System;
using System.Windows.Forms;

namespace DoanQueKinhDich.UserControls
{
    public partial class ucQue : UserControl, IQue
    {
        public event EventHandler CheckedChanged;
        public ucLabel uiHao6 => chkHao6;
        public ucLabel uiHao5 => chkHao5;
        public ucLabel uiHao4 => chkHao4;
        public ucLabel uiHao3 => chkHao3;
        public ucLabel uiHao2 => chkHao2;
        public ucLabel uiHao1 => chkHao1;
        public CheckBox uiIsHao6Dong => chkIsHao6Dong;
        public CheckBox uiIsHao5Dong => chkIsHao5Dong;
        public CheckBox uiIsHao4Dong => chkIsHao4Dong;
        public CheckBox uiIsHao3Dong => chkIsHao3Dong;
        public CheckBox uiIsHao2Dong => chkIsHao2Dong;
        public CheckBox uiIsHao1Dong => chkIsHao1Dong;

        public ComboBox uiNgoaiQuai => cbxNgoaiQuai;
        public ComboBox uiNoiQuai => cbxNoiQuai;

        public bool Hao6 => chkHao6.Checked;
        public bool Hao5 => chkHao5.Checked;
        public bool Hao4 => chkHao4.Checked;
        public bool Hao3 => chkHao3.Checked;
        public bool Hao2 => chkHao2.Checked;
        public bool Hao1 => chkHao1.Checked;

        public bool Hao6Dong => chkIsHao6Dong.Checked;
        public bool Hao5Dong => chkIsHao5Dong.Checked;
        public bool Hao4Dong => chkIsHao4Dong.Checked;
        public bool Hao3Dong => chkIsHao3Dong.Checked;
        public bool Hao2Dong => chkIsHao2Dong.Checked;
        public bool Hao1Dong => chkIsHao1Dong.Checked;

        public ucQue()
        {
            InitializeComponent();
        }

        public void ShowCacHao(ViTriHao viTriHao)
        {
            switch (viTriHao)
            {
                case ViTriHao.None:
                    break;
                case ViTriHao.Hao1:
                    chkHao1.Visible = uiBienHao1.Visible = true;
                    chkIsHao1Dong.Visible = chkIsHao1Dong.Checked;
                    break;

                case ViTriHao.Hao2:
                    chkHao2.Visible = uiBienHao2.Visible = true;
                    chkIsHao2Dong.Visible = chkIsHao2Dong.Checked;
                    break;

                case ViTriHao.Hao3:
                    chkHao3.Visible = uiBienHao3.Visible = true;
                    chkIsHao3Dong.Visible = chkIsHao3Dong.Checked;
                    break;

                case ViTriHao.Hao4:
                    chkHao4.Visible = uiBienHao4.Visible = true;
                    chkIsHao4Dong.Visible = chkIsHao4Dong.Checked;
                    break;

                case ViTriHao.Hao5:
                    chkHao5.Visible = uiBienHao5.Visible = true;
                    chkIsHao5Dong.Visible = chkIsHao5Dong.Checked;
                    break;

                case ViTriHao.Hao6:
                    chkHao6.Visible = uiBienHao6.Visible = true;
                    chkIsHao6Dong.Visible = chkIsHao6Dong.Checked;
                    break;

                default:
                    break;
            }
        }

        public void DisableAllControls()
        {
            var newValue = false;

            uiHao6.EnableClick = newValue;
            uiHao5.EnableClick = newValue;
            uiHao4.EnableClick = newValue;
            uiHao3.EnableClick = newValue;
            uiHao2.EnableClick = newValue;
            uiHao1.EnableClick = newValue;

            uiIsHao6Dong.Enabled = newValue;
            uiIsHao5Dong.Enabled = newValue;
            uiIsHao4Dong.Enabled = newValue;
            uiIsHao3Dong.Enabled = newValue;
            uiIsHao2Dong.Enabled = newValue;
            uiIsHao1Dong.Enabled = newValue;

            uiBienHao6.EnableClick = newValue;
            uiBienHao5.EnableClick = newValue;
            uiBienHao4.EnableClick = newValue;
            uiBienHao3.EnableClick = newValue;
            uiBienHao2.EnableClick = newValue;
            uiBienHao1.EnableClick = newValue;

            uiNgoaiQuai.Enabled = newValue;
            uiNoiQuai.Enabled = newValue;
        }

        public void HideAllControls()
        {
            var newValue = false;

            uiHao6.Visible = newValue;
            uiHao5.Visible = newValue;
            uiHao4.Visible = newValue;
            uiHao3.Visible = newValue;
            uiHao2.Visible = newValue;
            uiHao1.Visible = newValue;

            uiIsHao6Dong.Visible = newValue;
            uiIsHao5Dong.Visible = newValue;
            uiIsHao4Dong.Visible = newValue;
            uiIsHao3Dong.Visible = newValue;
            uiIsHao2Dong.Visible = newValue;
            uiIsHao1Dong.Visible = newValue;

            uiBienHao6.Visible = newValue;
            uiBienHao5.Visible = newValue;
            uiBienHao4.Visible = newValue;
            uiBienHao3.Visible = newValue;
            uiBienHao2.Visible = newValue;
            uiBienHao1.Visible = newValue;

            uiNgoaiQuai.Visible = newValue;
            uiNoiQuai.Visible = newValue;

        }

        private void ucQue_Load(object sender, EventArgs e)
        {
            cbxNgoaiQuai.SelectedIndex = 0;
            cbxNoiQuai.SelectedIndex = 0;
        }

        private void chkHao6_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao6);
            FormUtils.ChangeTextAmDuong(uiBienHao6, chkHao6, chkIsHao6Dong);
            UpdateNgoaiQuai();
        }

        private void chkHao5_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao5);
            FormUtils.ChangeTextAmDuong(uiBienHao5, chkHao5, chkIsHao5Dong);
            UpdateNgoaiQuai();
        }

        private void chkHao4_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao4);
            FormUtils.ChangeTextAmDuong(uiBienHao4, chkHao4, chkIsHao4Dong);
            UpdateNgoaiQuai();
        }

        private void chkHao3_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao3);
            FormUtils.ChangeTextAmDuong(uiBienHao3, chkHao3, chkIsHao3Dong);
            UpdateNoiQuai();
        }

        private void chkHao2_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao2);
            FormUtils.ChangeTextAmDuong(uiBienHao2, chkHao2, chkIsHao2Dong);
            UpdateNoiQuai();
        }

        private void chkHao1_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao1);
            FormUtils.ChangeTextAmDuong(uiBienHao1, chkHao1, chkIsHao1Dong);
            UpdateNoiQuai();
        }

        private void UpdateNgoaiQuai()
        {
            FormUtils.UpdateBatQuai(cbxNgoaiQuai, chkHao6, chkHao5, chkHao4);
            CheckedChanged?.Invoke(null, null);
        }

        private void UpdateNoiQuai()
        {
            FormUtils.UpdateBatQuai(cbxNoiQuai, chkHao3, chkHao2, chkHao1);
            CheckedChanged?.Invoke(null, null);
        }

        private void cbxNgoaiQuai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cung cung = BatQuai.All[cbxNgoaiQuai.SelectedIndex];
            chkHao6.Checked = cung.Duong3;
            chkHao5.Checked = cung.Duong2;
            chkHao4.Checked = cung.Duong1;

            CheckedChanged?.Invoke(null, null);
        }

        private void cbxNoiQuai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cung cung = BatQuai.All[cbxNoiQuai.SelectedIndex];
            chkHao3.Checked = cung.Duong3;
            chkHao2.Checked = cung.Duong2;
            chkHao1.Checked = cung.Duong1;

            CheckedChanged?.Invoke(null, null);
        }

        private void chkHao6Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao6, chkHao6, chkIsHao6Dong);
            CheckedChanged?.Invoke(null, null);
        }

        private void chkHao5Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao5, chkHao5, chkIsHao5Dong);
            CheckedChanged?.Invoke(null, null);
        }

        private void chkHao4Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao4, chkHao4, chkIsHao4Dong);
            CheckedChanged?.Invoke(null, null);
        }

        private void chkHao3Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao3, chkHao3, chkIsHao3Dong);
            CheckedChanged?.Invoke(null, null);
        }

        private void chkHao2Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao2, chkHao2, chkIsHao2Dong);
            CheckedChanged?.Invoke(null, null);
        }

        private void chkHao1Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao1, chkHao1, chkIsHao1Dong);
            CheckedChanged?.Invoke(null, null);
        }

        /// <summary>
        /// Update nội quái khi hào 3 hay 2 hay 1 hiện ra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkHao1_VisibleChanged(object sender, EventArgs e)
        {
            UpdateNoiQuai();
        }

        /// <summary>
        /// Update ngoại quái khi hào 6 hay 5 hay 4 hiện ra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkHao4_VisibleChanged(object sender, EventArgs e)
        {
            UpdateNgoaiQuai();
        }

        private void uiBienHao6_CheckedChanged(object sender, EventArgs e)
        {
            chkIsHao6Dong.Checked = uiBienHao6.IsDuong != chkHao6.IsDuong;
        }

        private void uiBienHao5_CheckedChanged(object sender, EventArgs e)
        {
            chkIsHao5Dong.Checked = uiBienHao5.IsDuong != chkHao5.IsDuong;
        }

        private void uiBienHao4_CheckedChanged(object sender, EventArgs e)
        {
            chkIsHao4Dong.Checked = uiBienHao4.IsDuong != chkHao4.IsDuong;
        }

        private void uiBienHao3_CheckedChanged(object sender, EventArgs e)
        {
            chkIsHao3Dong.Checked = uiBienHao3.IsDuong != chkHao3.IsDuong;
        }

        private void uiBienHao2_CheckedChanged(object sender, EventArgs e)
        {
            chkIsHao2Dong.Checked = uiBienHao2.IsDuong != chkHao2.IsDuong;
        }

        private void uiBienHao1_CheckedChanged(object sender, EventArgs e)
        {
            chkIsHao1Dong.Checked = uiBienHao1.IsDuong != chkHao1.IsDuong;
        }
    }
}
