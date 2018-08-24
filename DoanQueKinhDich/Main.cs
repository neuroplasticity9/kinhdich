using System;
using System.Windows.Forms;
using KinhDichCommon;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.ThienCan;

namespace DoanQueKinhDich
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var date = mcDate.SelectionRange.Start;
            // MessageBox.Show(date.ToString());

            var queChu = QueDich.GetQue(chkHao6.Checked, chkHao5.Checked, chkHao4.Checked, chkHao3.Checked, chkHao2.Checked, chkHao1.Checked);
            var queBien = QueDich.GetQueBien(queChu, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);

            var nhatThan = new CanChi { Can = Canh, Chi = Ti };
            var nguyetKien = new CanChi { Can = Giap, Chi = Dan };
            //var nhatThan = new CanChi { Can = Ky, Chi = Suu };
            //var nguyetKien = new CanChi { Can = Quy, Chi = Hoi };

            var queChuString = queChu.GetLucThan(nhatThan, nguyetKien, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);
            var queBienString = queBien.GetLucThan(nhatThan, nguyetKien, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);

            txtQueChu.Text = queChuString;
            txtQueBien.Text = queBienString;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
