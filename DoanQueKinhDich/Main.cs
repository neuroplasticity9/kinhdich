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

            //var nhatThan = new CanChi { Can = Canh, Chi = Ti };
            //var nguyetKien = new CanChi { Can = Giap, Chi = Dan };
            CanChi nhatThan = GetNhatThan();
            CanChi nguyetKien = GetNguyetKien();

            var queChuString = queChu.GetLucThan(nhatThan, nguyetKien, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);
            var queBienString = queBien.GetLucThan(nhatThan, nguyetKien, chkHao6Dong.Checked, chkHao5Dong.Checked, chkHao4Dong.Checked, chkHao3Dong.Checked, chkHao2Dong.Checked, chkHao1Dong.Checked);

            txtQueChu.Text = queChuString;
            txtQueBien.Text = queBienString;
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

        private void Main_Load(object sender, EventArgs e)
        {
            cbxNgayCan.SelectedIndex = 6;
            cbxNgayChi.SelectedIndex = 0;
            cbxThangCan.SelectedIndex = 0;
            cbxThangChi.SelectedIndex = 2;
        }
    }
}
