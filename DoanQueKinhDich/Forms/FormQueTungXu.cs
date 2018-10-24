using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using DoanQueKinhDich.UserControls;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueTungXu : Form, IQueLayDuoc
    {
        private int _lanLayQue = 0;

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
        public AmLich AmLich { get; private set; }
        public CachLayQue CachLayQue => CachLayQue.TungXu;
        public NgayLayQue NgayLayQue => AmLich.ToNgayLayQue();

        public FormQueTungXu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            ucQueDich.DisableAllControls();

            ucQueDich.HideAllControls();

            AmLich = DateTime.Now.ToAmLich();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (IsDone)
            {
                this.Close();
                return;
            }

            _lanLayQue++;

            try
            {
                btnGo.Enabled = false;

                SetResultForHaoAndHaoDong((ViTriHao)_lanLayQue);
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

        private void SetResultForHaoAndHaoDong(ViTriHao viTriHao)
        {
            TungXu tungXu = new TungXu();
            tungXu.Run();

            SetHao(viTriHao, tungXu);
            ucQueDich.ShowCacHao(viTriHao);

            labelKetQua.Text = tungXu.GetKetQua();
        }

        private void SetHao(ViTriHao viTriHao, TungXu tungXu)
        {
            switch (viTriHao)
            {
                case ViTriHao.None:
                    break;

                case ViTriHao.Hao1:
                    CheckHaoAndHaoDong(ucQueDich.uiHao1, ucQueDich.uiIsHao1Dong, tungXu);
                    break;

                case ViTriHao.Hao2:
                    CheckHaoAndHaoDong(ucQueDich.uiHao2, ucQueDich.uiIsHao2Dong, tungXu);
                    break;

                case ViTriHao.Hao3:
                    CheckHaoAndHaoDong(ucQueDich.uiHao3, ucQueDich.uiIsHao3Dong, tungXu);
                    break;

                case ViTriHao.Hao4:
                    CheckHaoAndHaoDong(ucQueDich.uiHao4, ucQueDich.uiIsHao4Dong, tungXu);
                    break;

                case ViTriHao.Hao5:
                    CheckHaoAndHaoDong(ucQueDich.uiHao5, ucQueDich.uiIsHao5Dong, tungXu);
                    break;
                case ViTriHao.Hao6:
                    CheckHaoAndHaoDong(ucQueDich.uiHao6, ucQueDich.uiIsHao6Dong, tungXu);
                    break;

                default:
                    break;
            }
        }

        private void CheckHaoAndHaoDong(CheckBox chkHao, CheckBox chkHaoDong, TungXu tungXu)
        {
            chkHao.Checked = tungXu.Duong;
            chkHaoDong.Checked = tungXu.Dong;
        }


        private void CheckHaoAndHaoDong(ucLabel chkHao, CheckBox chkHaoDong, TungXu tungXu)
        {
            chkHao.Checked = tungXu.Duong;
            chkHaoDong.Checked = tungXu.Dong;
        }

        private void FormQueTungXu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnGo.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
