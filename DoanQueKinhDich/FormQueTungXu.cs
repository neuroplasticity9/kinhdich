using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueTungXu : Form, IQue
    {
        private int _lanLayQue = 0;
        private DateTime _ngayLayQue = DateTime.Now;

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

        public bool IsDone { get; private set; } = false;

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
                    SetResultForHao(ucQueDich.uiHao1, ucQueDich.uiHao1Dong);
                    break;

                case 2:
                    SetResultForHao(ucQueDich.uiHao2, ucQueDich.uiHao2Dong);
                    break;

                case 3:
                    SetResultForHao(ucQueDich.uiHao3, ucQueDich.uiHao3Dong);
                    break;

                case 4:
                    SetResultForHao(ucQueDich.uiHao4, ucQueDich.uiHao4Dong);
                    break;

                case 5:
                    SetResultForHao(ucQueDich.uiHao5, ucQueDich.uiHao5Dong);
                    break;

                case 6:
                    SetResultForHao(ucQueDich.uiHao6, ucQueDich.uiHao6Dong);
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
            ucQueDich.DisableAllControls();

            ucQueDich.uiHao6.Visible = false;
            ucQueDich.uiHao5.Visible = false;
            ucQueDich.uiHao4.Visible = false;
            ucQueDich.uiHao3.Visible = false;
            ucQueDich.uiHao2.Visible = false;
            ucQueDich.uiHao1.Visible = false;

            ucQueDich.uiHao6Dong.Visible = false;
            ucQueDich.uiHao5Dong.Visible = false;
            ucQueDich.uiHao4Dong.Visible = false;
            ucQueDich.uiHao3Dong.Visible = false;
            ucQueDich.uiHao2Dong.Visible = false;
            ucQueDich.uiHao1Dong.Visible = false;

            //ucQueDich.uiNgoaiQuai.SelectedIndex = -1;
            //ucQueDich.uiNoiQuai.SelectedIndex = -1;
        }

    }
}
