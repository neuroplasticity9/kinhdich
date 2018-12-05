using System;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormTimTen : Form
    {
        private bool _luonHienKetQua = false;
        private TenService _tenService = new TenService();

        public FormTimTen()
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
            rad8.Checked = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var tongSo = GetTongSo2Chu();

            var minLen = 1;
            var maxLen = 6;

            var lotOption = new TimTenOption(1, 6, txtLotKy.Text, txtLotChon.Text, dungKhongDau: chkLotKhongDau.Checked, dungDauHuyen: chkLotHuyen.Checked, dungDauSac: chkLotSac.Checked, dungDauHoi: chkLotHoi.Checked, dungDauNga: chkLotNga.Checked, dungDauNang: chkLotNang.Checked);
            var tenOption = new TimTenOption(1, 6, txtTenKy.Text, txtTenChon.Text, dungKhongDau: chkTenKhongDau.Checked, dungDauHuyen: chkTenHuyen.Checked, dungDauSac: chkTenSac.Checked, dungDauHoi: chkTenHoi.Checked, dungDauNga: chkTenNga.Checked, dungDauNang: chkTenNang.Checked);

            txtDesc.Clear();
            txtDesc.Text = _tenService.Get2ChuCoTong(tongSo, lotOption, tenOption);
        }

        private int GetTongSo2Chu()
        {
            if (rad5.Checked) return 5;

            if (rad6.Checked) return 6;

            if (rad7.Checked) return 7;

            if (rad8.Checked) return 8;

            if (rad9.Checked) return 9;

            if (rad10.Checked) return 10;

            if (rad11.Checked) return 11;

            return 8;
        }
        
        private void FormQueHoc_KeyDown(object sender, KeyEventArgs e)
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDesc.Text);
        }
    }
}
