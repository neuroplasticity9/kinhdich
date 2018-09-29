using System;
using System.Text;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueThoiGian : Form, IQueLayDuoc
    {
        private bool _useCurrentTime = true;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormQueThoiGian()
        {
            InitializeComponent();

            ucQueDich.DisableAllControls();

            SetChiCuaGio();

            radThoiGian.Checked = true;

            btnLoadCurrentDateTime.PerformClick();
            txtSoHoacChu.Focus();
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

        public bool IsDone { get; set; } = false;
        public DateTime DuongLich { get; private set; } = DateTime.Now;
        public AmLich AmLich { get; private set; }
        public NgayLayQue NgayLayQue => AmLich.ToNgayLayQue();
        public CachLayQue CachLayQue { get; private set; }

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

            IsDone = true;
            this.Close();
        }

        private void uiDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            GetQue();

            uiDatePicker.Value = uiDate.SelectionRange.Start;
        }

        private void GetQue()
        {
            AmLich = (uiDate.SelectionRange.Start + uiHour.Value.TimeOfDay).ToAmLich();

            SetUIControls(AmLich);

            SetNoiQuaiNgoaiQuai(AmLich);
        }
        
        private void SetNoiQuaiNgoaiQuai(AmLich amLich)
        {
            QueIndex queIndex = GetQueIndex(amLich);

            ucQueDich.uiNgoaiQuai.SelectedIndex = queIndex.NgoaiQuaiIndex;
            ucQueDich.uiNoiQuai.SelectedIndex = queIndex.NoiQuaiIndex;

            ucQueDich.ResetHaoDong();
            ucQueDich.uiIsHao1Dong.Checked = queIndex.HaoDongIndex == 1;
            ucQueDich.uiIsHao2Dong.Checked = queIndex.HaoDongIndex == 2;
            ucQueDich.uiIsHao3Dong.Checked = queIndex.HaoDongIndex == 3;
            ucQueDich.uiIsHao4Dong.Checked = queIndex.HaoDongIndex == 4;
            ucQueDich.uiIsHao5Dong.Checked = queIndex.HaoDongIndex == 5;
            ucQueDich.uiIsHao6Dong.Checked = queIndex.HaoDongIndex == 0;
        }

        private QueIndex GetQueIndex(AmLich amLich)
        {
            var queIndex = new QueIndex();

            switch (CachLayQue)
            {
                case CachLayQue.None:
                    break;

                case CachLayQue.MaiHoaTienThien1:
                    queIndex = GetQueIndexByTime(amLich);
                    break;

                case CachLayQue.MaiHoaTienThien2:
                    queIndex = GetQueIndexBySoAndTime(txtQueNgoai1.Text, amLich);
                    break;

                case CachLayQue.MaiHoaTienThien3:
                    queIndex = GetQueIndexBySoAndSo(txtQueNgoai2.Text, txtQueNoi2.Text, amLich);
                    break;

                default:
                    break;
            }

            return queIndex;
        }

        private QueIndex GetQueIndexBySoAndTime(string textCuaQuai, AmLich amLich)
        {
            int tongNgoaiQuai = GetTongCuaQuai(textCuaQuai);
            int tongNoiQuai = GetTongNamThangNgayGio(amLich);

            return new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1 + 8) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1 + 8) % 8,
                HaoDongIndex = (tongNgoaiQuai + tongNoiQuai + amLich.GioAm.Chi.Id) % 6,
            };
        }

        private QueIndex GetQueIndexBySoAndSo(string textCuaNgoaiQuai, string textCuaNoiQuai, AmLich amLich)
        {
            int tongNgoaiQuai = GetTongCuaQuai(textCuaNgoaiQuai);
            int tongNoiQuai = GetTongCuaQuai(textCuaNoiQuai);

            // Tiên thiên đoán bằng số nên không cần giờ. Hậu thiên đoán bằng bát quái nên cần thêm giờ vào để tìm hào động.
            int chiNumber = radTienThien.Checked ? 0 : amLich.GioAm.Chi.Id;

            var queIndex = new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1 + 8) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1 + 8) % 8,
                HaoDongIndex = (tongNgoaiQuai + tongNoiQuai + chiNumber) % 6,
            };

            var sb = new StringBuilder();
            sb.AppendLine($"1. Ngoại quái: số {tongNgoaiQuai} % 8 = {queIndex.NgoaiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NgoaiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"2. Nội quái:   số {tongNoiQuai} % 8 = {queIndex.NoiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NoiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"3. Động hào:   ngoại quái {tongNgoaiQuai} + nội quái {tongNoiQuai}{GetGioHauThienDesc(amLich.GioAm)} = {tongNgoaiQuai + tongNoiQuai + chiNumber} % 6 = {GetHaoDongDesc(queIndex.HaoDongIndex)}");

            txtDesc.Text = sb.ToString();

            return queIndex;
        }

        private string GetGioHauThienDesc(CanChi gio)
        {
            return radTienThien.Checked ? "" : $" + giờ {gio.Chi.Name} {gio.Chi.Id}";
        }

        private int GetTongCuaQuai(string textCuaQuai)
        {
            if (int.TryParse(textCuaQuai, out int soCuaQuai))
            {
                // Nếu là 1 số thì lấy chính số đó.
                return soCuaQuai;
            }
            else
            {
                // Đếm số chữ cái trong đoạn text.
                return textCuaQuai.Replace(" ", "").Length;
            }
        }

        private QueIndex GetQueIndexByTime(AmLich amLich)
        {
            int soHoacChu = GetTongCuaQuai(txtSoHoacChu.Text);
            int tongNgoaiQuai = GetTongNamThangNgay(amLich) + soHoacChu;
            int tongNoiQuai = GetTongNamThangNgayGio(amLich) + soHoacChu;

            var queIndex = new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1 + 8) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1 + 8) % 8,
                HaoDongIndex = tongNoiQuai % 6,
            };

            var sb = new StringBuilder();
            sb.AppendLine($"1. Ngoại quái: năm {GetNamDesc(amLich.NamAm)} + tháng {amLich.LunarMonth} + ngày {amLich.LunarDay} + số {soHoacChu} = {tongNgoaiQuai} % 8 = {queIndex.NgoaiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NgoaiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"2. Nội quái:   năm {GetNamDesc(amLich.NamAm)} + tháng {amLich.LunarMonth} + ngày {amLich.LunarDay} + số {soHoacChu} + giờ {amLich.GioAm.Chi.Name} {amLich.GioAm.Chi.Id} = {tongNoiQuai} % 8 = {queIndex.NoiQuaiIndex + 1} = quẻ {BatQuai.All[queIndex.NoiQuaiIndex].Name}");
            sb.AppendLine();
            sb.AppendLine($"3. Động hào:   tổng nội quái {tongNoiQuai} % 6 = {GetHaoDongDesc(queIndex.HaoDongIndex)}");

            txtDesc.Text = sb.ToString();

            return queIndex;
        }

        private int GetHaoDongDesc(int haoDongIndex)
        {
            return haoDongIndex == 0 ? 6 : haoDongIndex;
        }

        private string GetNamDesc(CanChi nam)
        {
            return chkUseNamCan.Checked ? $"{nam.Can.Name} {nam.Can.Id}" : $"{nam.Chi.Name} {nam.Chi.Id}";
        }

        private int GetTongNamThangNgay(AmLich amLich)
        {
            var tongNamThangNgay = 0;
            if (chkUseNamCan.Checked)
            {
                // Dùng can của năm, theo Thiệu Vỹ Hoa.
                tongNamThangNgay = amLich.NamAm.Can.Id + amLich.LunarMonth + amLich.LunarDay;
            }
            else
            {
                // Dùng chi của năm, theo Thiệu Khang Tiết.
                tongNamThangNgay = amLich.NamAm.Chi.Id + amLich.LunarMonth + amLich.LunarDay;
            }

            return tongNamThangNgay;
        }


        private int GetTongNamThangNgayGio(AmLich amLich)
        {
            DiaChi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
            return  GetTongNamThangNgay(amLich) + gioChi.Id;
        }

        private void SetUIControls(AmLich amLich)
        {
            CanChi ngayAm = amLich.NgayAm;
            CanChi thangAm = amLich.ThangAm;
            CanChi namAm = amLich.NamAm;

            cbxNgayCan.SelectedIndex = ngayAm.Can.Id - 1;
            cbxNgayChi.SelectedIndex = ngayAm.Chi.Id - 1;
            cbxThangCan.SelectedIndex = thangAm.Can.Id - 1;
            cbxThangChi.SelectedIndex = thangAm.Chi.Id - 1;
            cbxNamCan.SelectedIndex = namAm.Can.Id - 1;
            cbxNamChi.SelectedIndex = namAm.Chi.Id - 1;

            DiaChi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
            ThienCan gioCan = amLich.GetCanCuaGio(gioChi);
            cbxGioCan.SelectedIndex = gioCan.Id - 1;

            labelNgayDuongLich.Text = $"Ngày dương lịch: {amLich.SolarDate.Year}-{amLich.SolarDate.Month}-{amLich.SolarDate.Day}";
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
            // Cập nhật giờ dựa vào địa chi đã chọn.
            var datePart = uiHour.Value.Date;

            var chiGioIndexCurrent = DuongLich.ToAmLich().GetCanChiGio().Chi.Id - 1;
            var chiGioIndexSelected = cbxGioChi.SelectedIndex;
            var diffHour = TimeSpan.FromHours((chiGioIndexSelected- chiGioIndexCurrent) * 2);
            var hourPart = DuongLich.TimeOfDay + diffHour;

            uiHour.Value = datePart + hourPart;

            GetQue();
        }

        private void uiHour_ValueChanged(object sender, EventArgs e)
        {
            SetChiCuaGio();
        }

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.MaiHoaTienThien1;

            chkUseNamCan.Enabled = true;
            txtSoHoacChu.Enabled = true;
            txtQueNgoai1.Enabled = false;
            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Enabled = false;
            radTienThien.Enabled = false;
            radHauThien.Enabled = false;

            txtSoHoacChu.Focus();

            GetQue();
        }

        private void radNgoaiSo_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.MaiHoaTienThien2;

            chkUseNamCan.Enabled = false;
            txtSoHoacChu.Enabled = false;
            txtQueNgoai1.Enabled = true;
            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Enabled = false;
            radTienThien.Enabled = false;
            radHauThien.Enabled = false;
            
            txtQueNgoai1.Focus();

            GetQue();
        }

        private void radioNgoaiSoNoiSo_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.MaiHoaTienThien3;

            chkUseNamCan.Enabled = false;
            txtSoHoacChu.Enabled = false;
            txtQueNgoai1.Enabled = false;
            txtQueNgoai2.Enabled = true;
            txtQueNoi2.Enabled = true;
            radTienThien.Enabled = true;
            radHauThien.Enabled = true;
            radTienThien.Checked = true;

            txtQueNgoai2.Focus();

            GetQue();
        }

        /// <summary>
        /// Note: events for 3 text controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQueNgoai1_TextChanged(object sender, EventArgs e)
        {
            GetQue();
        }

        /// <summary>
        /// Note: events for 2 radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radTienThien_CheckedChanged(object sender, EventArgs e)
        {
            GetQue();
        }

        private void txtSoHoacChu_TextChanged(object sender, EventArgs e)
        {
            GetQue();
        }

        private void btnLoadCurrentDateTime_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            DuongLich = now;
            uiDate.SelectionRange = new SelectionRange(now, now);
            uiDatePicker.Value = now;
            uiHour.Value = now;

            GetQue();
        }
    }

    class QueIndex
    {
        public int NgoaiQuaiIndex { get; set; }
        public int NoiQuaiIndex { get; set; }
        public int HaoDongIndex { get; set; }
    }

}
