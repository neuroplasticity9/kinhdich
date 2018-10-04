using KinhDichCommon;
using System;
using System.Windows.Forms;

namespace DoanQueKinhDich.UserControls
{
    public partial class ucQueDon : UserControl
    {
        public event EventHandler CheckedChanged;
        public ucLabel uiHao6 => chkHao6;
        public ucLabel uiHao5 => chkHao5;
        public ucLabel uiHao4 => chkHao4;
        public ucLabel uiHao3 => chkHao3;
        public ucLabel uiHao2 => chkHao2;
        public ucLabel uiHao1 => chkHao1;

        public bool Hao6 => chkHao6.Checked;
        public bool Hao5 => chkHao5.Checked;
        public bool Hao4 => chkHao4.Checked;
        public bool Hao3 => chkHao3.Checked;
        public bool Hao2 => chkHao2.Checked;
        public bool Hao1 => chkHao1.Checked;

        public Que Que { get; set; }

        public ucQueDon()
        {
            InitializeComponent();
        }

        public void SetQue(Que que)
        {
            Que = que;

            uiHao6.Checked = que.Hao6.Duong;
            uiHao5.Checked = que.Hao5.Duong;
            uiHao4.Checked = que.Hao4.Duong;
            uiHao3.Checked = que.Hao3.Duong;
            uiHao2.Checked = que.Hao2.Duong;
            uiHao1.Checked = que.Hao1.Duong;
        }

        private void uiBienHao6_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(null, null);
        }

        private void uiBienHao5_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(null, null);
        }

        private void uiBienHao4_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(null, null);
        }

        private void uiBienHao3_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(null, null);
        }

        private void uiBienHao2_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(null, null);
        }

        private void uiBienHao1_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(null, null);
        }

    }
}
