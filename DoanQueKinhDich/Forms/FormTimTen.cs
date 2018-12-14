using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormTimTen : Form
    {
        private TenNuService _tenNuService = new TenNuService();
        private TenNamService _tenNamService = new TenNamService();

        private List<CheckBox> _allCheckboxes;

        public FormTimTen()
        {
            InitializeComponent();

            _allCheckboxes = new List<CheckBox> { null, null, null, chk4, chk5, chk6, chk7, chk8, chk9, chk10, chk11, chk12 };
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var minLen = 1;
            var maxLen = 6;

            var lotOption = new TimTenOption(minLen, maxLen, txtLotKy.Text, txtLotChon.Text, 
                                             dungKhongDau: chkLotKhongDau.Checked, dungDauHuyen: chkLotHuyen.Checked, dungDauSac: chkLotSac.Checked, 
                                             dungDauHoi: chkLotHoi.Checked, dungDauNga: chkLotNga.Checked, dungDauNang: chkLotNang.Checked);

            var tenOption = new TimTenOption(minLen, maxLen, txtTenKy.Text, txtTenChon.Text, 
                                             dungKhongDau: chkTenKhongDau.Checked, dungDauHuyen: chkTenHuyen.Checked, dungDauSac: chkTenSac.Checked, 
                                             dungDauHoi: chkTenHoi.Checked, dungDauNga: chkTenNga.Checked, dungDauNang: chkTenNang.Checked);

            var list = new List<string>();
            TenService tenService = GetTenService();

            for (int i = 0; i < _allCheckboxes.Count; i++)
            {
                if (_allCheckboxes[i] != null)
                {
                    int tongSoKyTu = GetTongSoKyTu(_allCheckboxes[i]);

                    if (chkGhepTenNgauNhien.Checked)
                    {
                        list.AddRange(tenService.Get2ChuRandom(tongSoKyTu, lotOption, tenOption));
                    }
                    else
                    {
                        list.AddRange(tenService.Get2ChuTenDep(tongSoKyTu, lotOption, tenOption));
                    }
                }
            }

            var sortedNameList = list.OrderBy(name => name).ToList();
            var result = _tenNuService.GetNamesInString(sortedNameList);

            txtDesc.Clear();
            txtDesc.Text = result;
        }

        private TenService GetTenService()
        {
            if (radBeGai.Checked)
            {
                return _tenNuService;
            }

            return _tenNamService;
        }

        private int GetTongSoKyTu(CheckBox checkBox)
        {
            if (!checkBox.Checked)
            {
                return 0;
            }

            for (int i = 0; i < _allCheckboxes.Count; i++)
            {
                if (_allCheckboxes[i] == checkBox)
                {
                    return i + 1;
                }
            }

            return 0;
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
