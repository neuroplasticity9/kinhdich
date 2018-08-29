﻿using System;
using System.Threading;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class LayQue : Form, IQue
    {
        private const string Duong = "—";
        private const string Am = "- -";
        private const int SleepSeconds = 1;
        private const int MaxRandomNumber = 100000;

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

        public CanChi NgayAm => _ngayLayQue.GetAmLich().GetCanChiNgay();

        public CanChi ThangAm => _ngayLayQue.GetAmLich().GetCanChiThang();

        public LayQue()
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

                TungXu();
            }
            finally
            {
                btnGo.Enabled = true;
                if (_lanLayQue >= 6)
                {
                    IsDone = true;
                    btnGo.Text = "Close";
                }
                else
                {
                    btnGo.Text = $"Tung xu lần {_lanLayQue + 1}";
                }
            }
        }

        private void TungXu()
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
            int soTong = GetQue();
            chkHao.Visible = true;
            chkHaoDong.Visible = true;
            chkHao.Checked = soTong % 3 == 1; // Chỉ có 1 đồng dương.
            chkHaoDong.Checked = soTong % 3 == 0; // Cả 3 đồng tiền cùng âm hay cùng dương.
        }

        private int GetQue()
        {
            // Sleep some seconds.
            Thread.Sleep(SleepSeconds * 1000);

            var random = new Random(DateTime.Now.Millisecond);
            int xu1 = random.Next(0, MaxRandomNumber) % 2;
            int xu2 = random.Next(0, MaxRandomNumber) % 2;
            int xu3 = random.Next(0, MaxRandomNumber) % 2;

            return xu1 + xu2 + xu3;
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
            ChangeTextAmDuong(chkHao6);
        }

        private void chkHao5_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao5);
        }

        private void chkHao4_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao4);
        }

        private void chkHao3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao3);
        }

        private void chkHao2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao2);
        }

        private void chkHao1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao1);
        }

        private void ChangeTextAmDuong(CheckBox chkHao)
        {
            chkHao.Text = chkHao.Checked ? Duong : Am;
        }
    }
}
