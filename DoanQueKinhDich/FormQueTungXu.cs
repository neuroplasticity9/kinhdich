using System;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueTungXu : Form, IQue
    {
        private int _lanLayQue = 0;
        private DateTime _ngayLayQue = DateTime.Now;

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

        public CanChi NgayAm => _ngayLayQue.ToAmLich().GetCanChiNgay();

        public CanChi ThangAm => _ngayLayQue.ToAmLich().GetCanChiThang();

        public FormQueTungXu()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (IsDone)
            {
                this.Close();
            }

            _lanLayQue++;

            try
            {
                btnGo.Enabled = false;
                //labelKetQua.Text = "Đang tung xu...";

                DoTungXu();
            }
            finally
            {
                btnGo.Enabled = true;
                if (_lanLayQue >= 6)
                {
                    IsDone = true;
                    btnGo.Text = "Lấy Quẻ";
                }
                else
                {
                    btnGo.Text = $"Tung xu lần {_lanLayQue + 1}";
                }
            }
        }

        private void DoTungXu()
        {
            switch (_lanLayQue)
            {
                case 1:
                    SetResultForHao(chkHao1, chkHao1Dong);
                    break;

                case 2:
                    SetResultForHao(chkHao2, chkHao2Dong);
                    break;

                case 3:
                    SetResultForHao(chkHao3, chkHao3Dong);
                    break;

                case 4:
                    SetResultForHao(chkHao4, chkHao4Dong);
                    break;

                case 5:
                    SetResultForHao(chkHao5, chkHao5Dong);
                    break;

                case 6:
                    SetResultForHao(chkHao6, chkHao6Dong);
                    break;

                default:
                    break;
            }
        }

        private void SetResultForHao(CheckBox chkHao, CheckBox chkHaoDong)
        {
            TungXu tungXu = new TungXu();
            tungXu.Run();

            chkHao.Checked = tungXu.Duong;
            chkHaoDong.Checked = tungXu.Dong;

            chkHao.Visible = true;
            chkHaoDong.Visible = true;

            labelKetQua.Text = tungXu.GetKetQua();
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            chkHao6.Visible = false;
            chkHao5.Visible = false;
            chkHao4.Visible = false;
            chkHao3.Visible = false;
            chkHao2.Visible = false;
            chkHao1.Visible = false;

            chkHao6Dong.Visible = false;
            chkHao5Dong.Visible = false;
            chkHao4Dong.Visible = false;
            chkHao3Dong.Visible = false;
            chkHao2Dong.Visible = false;
            chkHao1Dong.Visible = false;
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

        /// <summary>
        /// Update ngoại quái khi hào 6 hay 5 hay 4 hiện ra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkHao6Dong_VisibleChanged(object sender, EventArgs e)
        {
            UpdateNgoaiQuai();
        }

        /// <summary>
        /// Update nội quái khi hào 3 hay 2 hay 1 hiện ra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkHao3Dong_VisibleChanged(object sender, EventArgs e)
        {
            UpdateNoiQuai();
        }
    }
}
