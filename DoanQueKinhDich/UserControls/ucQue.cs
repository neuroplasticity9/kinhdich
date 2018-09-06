using DoanQueKinhDich.Business;
using DoanQueKinhDich.UserControls;
using KinhDichCommon;
using System;
using System.Windows.Forms;

namespace DoanQueKinhDich.UserControls
{
    public partial class ucQue : UserControl, IQue
    {

        public ucLabel uiHao6 => chkHao6;
        public ucLabel uiHao5 => chkHao5;
        public ucLabel uiHao4 => chkHao4;
        public ucLabel uiHao3 => chkHao3;
        public ucLabel uiHao2 => chkHao2;
        public ucLabel uiHao1 => chkHao1;
        public CheckBox uiHao6Dong => chkHao6Dong;
        public CheckBox uiHao5Dong => chkHao5Dong;
        public CheckBox uiHao4Dong => chkHao4Dong;
        public CheckBox uiHao3Dong => chkHao3Dong;
        public CheckBox uiHao2Dong => chkHao2Dong;
        public CheckBox uiHao1Dong => chkHao1Dong;

        public ComboBox uiNgoaiQuai => cbxNgoaiQuai;
        public ComboBox uiNoiQuai => cbxNoiQuai;

        public bool Hao6 => chkHao6.Checked;
        public bool Hao5 => chkHao5.Checked;
        public bool Hao4 => chkHao4.Checked;
        public bool Hao3 => chkHao3.Checked;
        public bool Hao2 => chkHao2.Checked;
        public bool Hao1 => chkHao1.Checked;

        public bool Hao6Dong => chkHao6Dong.Checked;
        public bool Hao5Dong => chkHao5Dong.Checked;
        public bool Hao4Dong => chkHao4Dong.Checked;
        public bool Hao3Dong => chkHao3Dong.Checked;
        public bool Hao2Dong => chkHao2Dong.Checked;
        public bool Hao1Dong => chkHao1Dong.Checked;

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
                    chkHao1Dong.Visible = chkHao1Dong.Checked;
                    break;

                case ViTriHao.Hao2:
                    chkHao2.Visible = uiBienHao2.Visible = true;
                    chkHao2Dong.Visible = chkHao2Dong.Checked;
                    break;

                case ViTriHao.Hao3:
                    chkHao3.Visible = uiBienHao3.Visible = true;
                    chkHao3Dong.Visible = chkHao3Dong.Checked;
                    break;

                case ViTriHao.Hao4:
                    chkHao4.Visible = uiBienHao4.Visible = true;
                    chkHao4Dong.Visible = chkHao4Dong.Checked;
                    break;

                case ViTriHao.Hao5:
                    chkHao5.Visible = uiBienHao5.Visible = true;
                    chkHao5Dong.Visible = chkHao5Dong.Checked;
                    break;

                case ViTriHao.Hao6:
                    chkHao6.Visible = uiBienHao6.Visible = true;
                    chkHao6Dong.Visible = chkHao6Dong.Checked;
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

            uiHao6Dong.Enabled = newValue;
            uiHao5Dong.Enabled = newValue;
            uiHao4Dong.Enabled = newValue;
            uiHao3Dong.Enabled = newValue;
            uiHao2Dong.Enabled = newValue;
            uiHao1Dong.Enabled = newValue;

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

            uiHao6Dong.Visible = newValue;
            uiHao5Dong.Visible = newValue;
            uiHao4Dong.Visible = newValue;
            uiHao3Dong.Visible = newValue;
            uiHao2Dong.Visible = newValue;
            uiHao1Dong.Visible = newValue;

            uiNgoaiQuai.Visible = newValue;
            uiNoiQuai.Visible = newValue;

            uiBienHao6.Visible = newValue;
            uiBienHao5.Visible = newValue;
            uiBienHao4.Visible = newValue;
            uiBienHao3.Visible = newValue;
            uiBienHao2.Visible = newValue;
            uiBienHao1.Visible = newValue;
        }

        private void ucQue_Load(object sender, EventArgs e)
        {
            cbxNgoaiQuai.SelectedIndex = 0;
            cbxNoiQuai.SelectedIndex = 0;
        }

        private void chkHao6_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao6);
            FormUtils.ChangeTextAmDuong(uiBienHao6, chkHao6, chkHao6Dong);
            UpdateNgoaiQuai();
        }

        private void chkHao5_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao5);
            FormUtils.ChangeTextAmDuong(uiBienHao5, chkHao5, chkHao5Dong);
            UpdateNgoaiQuai();
        }

        private void chkHao4_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao4);
            FormUtils.ChangeTextAmDuong(uiBienHao4, chkHao4, chkHao4Dong);
            UpdateNgoaiQuai();
        }

        private void chkHao3_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao3);
            FormUtils.ChangeTextAmDuong(uiBienHao3, chkHao3, chkHao3Dong);
            UpdateNoiQuai();
        }

        private void chkHao2_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao2);
            FormUtils.ChangeTextAmDuong(uiBienHao2, chkHao2, chkHao2Dong);
            UpdateNoiQuai();
        }

        private void chkHao1_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(chkHao1);
            FormUtils.ChangeTextAmDuong(uiBienHao1, chkHao1, chkHao1Dong);
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

        private void chkHao6Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao6, chkHao6, chkHao6Dong);
        }

        private void chkHao5Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao5, chkHao5, chkHao5Dong);
        }

        private void chkHao4Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao4, chkHao4, chkHao4Dong);
        }

        private void chkHao3Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao3, chkHao3, chkHao3Dong);
        }

        private void chkHao2Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao2, chkHao2, chkHao2Dong);
        }

        private void chkHao1Dong_CheckedChanged(object sender, EventArgs e)
        {
            FormUtils.ChangeTextAmDuong(uiBienHao1, chkHao1, chkHao1Dong);
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
    }
}
