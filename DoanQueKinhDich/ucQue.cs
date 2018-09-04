using DoanQueKinhDich.Business;
using KinhDichCommon;
using System;
using System.Windows.Forms;

namespace DoanQueKinhDich
{
    public partial class ucQue : UserControl, IQue
    {

        public CheckBox uiHao6 => chkHao6;
        public CheckBox uiHao5 => chkHao5;
        public CheckBox uiHao4 => chkHao4;
        public CheckBox uiHao3 => chkHao3;
        public CheckBox uiHao2 => chkHao2;
        public CheckBox uiHao1 => chkHao1;
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

        public bool Hao1Dong => chkHao6Dong.Checked;
        public bool Hao2Dong => chkHao5Dong.Checked;
        public bool Hao3Dong => chkHao4Dong.Checked;
        public bool Hao4Dong => chkHao3Dong.Checked;
        public bool Hao5Dong => chkHao2Dong.Checked;
        public bool Hao6Dong => chkHao1Dong.Checked;

        bool IQue.IsDone { get => throw new NotImplementedException(); }
        CanChi IQue.NgayAm { get => throw new NotImplementedException(); }
        CanChi IQue.ThangAm { get => throw new NotImplementedException(); }

        public ucQue()
        {
            InitializeComponent();
        }

        public void DisableAllControls()
        {
            uiHao6.Enabled = false;
            uiHao5.Enabled = false;
            uiHao4.Enabled = false;
            uiHao3.Enabled = false;
            uiHao2.Enabled = false;
            uiHao1.Enabled = false;

            uiHao6Dong.Enabled = false;
            uiHao5Dong.Enabled = false;
            uiHao4Dong.Enabled = false;
            uiHao3Dong.Enabled = false;
            uiHao2Dong.Enabled = false;
            uiHao1Dong.Enabled = false;

            uiNgoaiQuai.Enabled = false;
            uiNoiQuai.Enabled = false;
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
