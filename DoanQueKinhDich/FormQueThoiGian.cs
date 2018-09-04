using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
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

        private void uiDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            GetQue();
        }

        private void GetQue()
        {
            DateTime selectedDate = uiDate.SelectionRange.Start;
            var selectedTime = uiHour.Value.TimeOfDay;
            if (selectedTime >= TimeSpan.FromHours(23))
            {
                // Increase 1 day if it passed 11PM.
                selectedDate = selectedDate.AddDays(1);
            }

            var amLich = selectedDate.ToAmLich();

            IsDone = true;

            SetUIControls(amLich);

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
            ucQueDich.uiNgoaiQuai.SelectedIndex = ngoaiQuaiIndex;

            Chi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
            var totalNamThangNgayGio = totalNamThangNgay + gioChi.Id;
            var noiQuaiIndex = (totalNamThangNgayGio - 1) % 8;
            ucQueDich.uiNoiQuai.SelectedIndex = noiQuaiIndex;

            var haoDongIndex = totalNamThangNgayGio % 6;
            ucQueDich.uiHao1Dong.Checked = haoDongIndex == 1;
            ucQueDich.uiHao2Dong.Checked = haoDongIndex == 2;
            ucQueDich.uiHao3Dong.Checked = haoDongIndex == 3;
            ucQueDich.uiHao4Dong.Checked = haoDongIndex == 4;
            ucQueDich.uiHao5Dong.Checked = haoDongIndex == 5;
            ucQueDich.uiHao6Dong.Checked = haoDongIndex == 0;
        }

        private void SetUIControls(AmLich amLich)
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

            labelNgayAmLich.Text = $"Ngày âm lịch: {amLich.LunarYear}-{amLich.LunarMonth}-{amLich.LunarDay}";
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
