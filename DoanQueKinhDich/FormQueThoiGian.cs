using System;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueThoiGian : Form, IQue
    {
        private string _queChuUrl;
        private string _queBienUrl;

        public FormQueThoiGian()
        {
            InitializeComponent();
        }

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

        public CanChi NgayAm => GetNhatThan();

        public CanChi ThangAm => GetNguyetKien();

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

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            cbxNgoaiQuai.SelectedIndex = 0;
            cbxNoiQuai.SelectedIndex = 0;

            SetChiCuaGio();

            GetQue();
        }

        private void SetChiCuaGio()
        {
            var currentTime = uiHour.Value.TimeOfDay;

            var chiIndex = 0;
            if (currentTime <= TimeSpan.FromHours(1))
            {
                chiIndex = 0;
            }
            else
            {
                for (int i = 1; i < DiaChi.All.Count; i++)
                {
                    if (currentTime <= TimeSpan.FromHours(i * 2 + 1))
                    {
                        chiIndex = i;
                        break;
                    }
                }
            }

            cbxGioChi.SelectedIndex = chiIndex;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            GetQue();

            this.Close();
        }

        private void chkHao6_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao6);
            UpdateNgoaiQuai();
        }

        private void chkHao5_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao5);
            UpdateNgoaiQuai();
        }

        private void chkHao4_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao4);
            UpdateNgoaiQuai();
        }

        private void chkHao3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao3);
            UpdateNoiQuai();
        }

        private void chkHao2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao2);
            UpdateNoiQuai();
        }

        private void chkHao1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextAmDuong(chkHao1);
            UpdateNoiQuai();
        }

        private void ChangeTextAmDuong(CheckBox chkHao)
        {
            chkHao.Text = chkHao.Checked ? Utils.Duong : Utils.Am;
        }

        private void UpdateNgoaiQuai()
        {
            Cung cung;
            for (int i = 0; i < BatQuai.All.Count; i++)
            {
                cung = BatQuai.All[i];
                if (cung.Duong3 == chkHao6.Checked &&
                    cung.Duong2 == chkHao5.Checked &&
                    cung.Duong1 == chkHao4.Checked)
                {
                    cbxNgoaiQuai.SelectedIndex = i;
                    return;
                }
            }
        }

        private void UpdateNoiQuai()
        {
            Cung cung;
            for (int i = 0; i < BatQuai.All.Count; i++)
            {
                cung = BatQuai.All[i];
                if (cung.Duong3 == chkHao3.Checked &&
                    cung.Duong2 == chkHao2.Checked &&
                    cung.Duong1 == chkHao1.Checked)
                {
                    cbxNoiQuai.SelectedIndex = i;
                    return;
                }
            }
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

        private void uiDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            GetQue();
        }

        private void GetQue()
        {
            DateTime selectedDate = uiDate.SelectionRange.Start;
            //var selectedTime = uiHour.Value.TimeOfDay;

            var amLich = selectedDate.ToAmLich();

            IsDone = true;

            SetNgayThangComboboxes(amLich);

            SetNoiQuaiNgoaiQuai(amLich);
        }

        private void SetNoiQuaiNgoaiQuai(AmLich amLich)
        {
            var totalNamThangNgay = 0;
            if (chkUseNamCan.Checked)
            {
                totalNamThangNgay = amLich.GetCanChiNam().Can.Id + amLich.LunarMonth + amLich.LunarDay;
            }
            else
            {
                totalNamThangNgay = amLich.GetCanChiNam().Chi.Id + amLich.LunarMonth + amLich.LunarDay;
            }

            var ngoaiQuaiIndex = (totalNamThangNgay - 1) % 8;
            cbxNgoaiQuai.SelectedIndex = ngoaiQuaiIndex;

            Chi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
            var totalNamThangNgayGio = totalNamThangNgay + gioChi.Id;
            var noiQuaiIndex = (totalNamThangNgayGio - 1) % 8;
            cbxNoiQuai.SelectedIndex = noiQuaiIndex;

            var haoDongIndex = totalNamThangNgayGio % 6;
            chkHao1Dong.Checked = haoDongIndex == 1;
            chkHao2Dong.Checked = haoDongIndex == 2;
            chkHao3Dong.Checked = haoDongIndex == 3;
            chkHao4Dong.Checked = haoDongIndex == 4;
            chkHao5Dong.Checked = haoDongIndex == 5;
            chkHao6Dong.Checked = haoDongIndex == 0;
        }

        private void SetNgayThangComboboxes(AmLich amLich)
        {
            CanChi ngayAm = amLich.GetCanChiNgay();
            CanChi thangAm = amLich.GetCanChiThang();
            CanChi namAm = amLich.GetCanChiNam();

            cbxNgayCan.SelectedIndex = ngayAm.Can.Id - 1;
            cbxNgayChi.SelectedIndex = ngayAm.Chi.Id - 1;
            cbxThangCan.SelectedIndex = thangAm.Can.Id - 1;
            cbxThangChi.SelectedIndex = thangAm.Chi.Id - 1;
            cbxNamCan.SelectedIndex = namAm.Can.Id - 1;
            cbxNamChi.SelectedIndex = namAm.Chi.Id - 1;

            Chi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
            Can gioCan = amLich.GetCanCuaGio(gioChi);
            cbxGioCan.SelectedIndex = gioCan.Id - 1;
        }

        private void uiDatePicker_ValueChanged(object sender, EventArgs e)
        {
            uiDate.SelectionRange = new SelectionRange(uiDatePicker.Value, uiDatePicker.Value);
        }

        private void chkUseNamCan_CheckedChanged(object sender, EventArgs e)
        {
            GetQue();
        }

        private void cbxGioChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQue();
        }

        private void uiHour_ValueChanged(object sender, EventArgs e)
        {
            SetChiCuaGio();
        }
    }
}
