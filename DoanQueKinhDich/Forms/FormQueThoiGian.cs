using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public partial class FormQueThoiGian : Form, IQueLayDuoc
    {
        private bool _dontUpdateBack = false;
        private Color _normalColor;
        private Color _selectedColor = Color.Blue;
        private List<Button> _diaChiButtons = new List<Button>();

        private LayQueService _layQueService = new LayQueService();

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormQueThoiGian()
        {
            InitializeComponent();

            _diaChiButtons = new List<Button>() { btn1Ti, btn2Suu, btn3Dan, btn4Mao, btn5Thin, btn6Ty, btn7Ngo, btn8Mui, btn9Than, btn10Dau, btn11Tuat, btn12Hoi };
            _normalColor = btn1Ti.BackColor;

            ucQueDich.DisableAllControls();

            SetChiCuaGio();

            radThoiGian.Checked = true;

            btnLoadCurrentDateTime.PerformClick();

            _diaChiButtons[cbxGioChi.SelectedIndex].PerformClick();

            UpdateGioChiButtonsText();
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

            UpdateGioChiButtonsText();
        }

        private void UpdateGioChiButtonsText()
        {
            var listQueTrong1Ngay = _layQueService.GetAllQueIndexesForADay(AmLich, txtSoHoacChu.Text);

            for (int i = 0; i < _diaChiButtons.Count; i++)
            {
                _diaChiButtons[i].Text = GetButtonText(listQueTrong1Ngay[i]);
            }

            QueIndex queGioMui = listQueTrong1Ngay[7];
            int dongHaoGioTi = queGioMui.HaoDongNumber - 1 <= 0 ? 6 : queGioMui.HaoDongNumber - 1;

            labelNgayDich.Text = $"Ngày {queGioMui.GetQueChu().NgoaiQuai.Tuong.PadRight(5)}  Giờ Mùi động hào {queGioMui.HaoDongNumber}";
            labelDongHaoGioTi.Text = $"            Giờ Tí  động hào {dongHaoGioTi}";
        }

        private string GetButtonText(QueIndex queIndex)
        {
            LucThu thu = LucThu.GetLucThu(AmLich.NgayAm.Can, queIndex.HaoDongNumber - 1);


            return $"{queIndex.GetQueChu().NameShort} → {queIndex.GetQueBien().NameShort} ({thu.Name})";
        }

        private void GetQue()
        {
            AmLich = (uiDate.SelectionRange.Start + uiHour.Value.TimeOfDay).ToAmLich();

            SetUIControls(AmLich);

            SetNoiQuaiNgoaiQuai(AmLich);
        }
        
        private void SetNoiQuaiNgoaiQuai(AmLich amLich)
        {
            QueIndex queIndex = GetQueIndex(CachLayQue, amLich);

            txtDesc.Text = queIndex.Desc;

            ucQueDich.uiNgoaiQuai.SelectedIndex = queIndex.NgoaiQuaiIndex;
            ucQueDich.uiNoiQuai.SelectedIndex = queIndex.NoiQuaiIndex;

            ucQueDich.ResetHaoDong();
            ucQueDich.uiIsHao1Dong.Checked = queIndex.HaoDongNumber == 1;
            ucQueDich.uiIsHao2Dong.Checked = queIndex.HaoDongNumber == 2;
            ucQueDich.uiIsHao3Dong.Checked = queIndex.HaoDongNumber == 3;
            ucQueDich.uiIsHao4Dong.Checked = queIndex.HaoDongNumber == 4;
            ucQueDich.uiIsHao5Dong.Checked = queIndex.HaoDongNumber == 5;
            ucQueDich.uiIsHao6Dong.Checked = queIndex.HaoDongNumber == 6;
        }

        private QueIndex GetQueIndex(CachLayQue cachLayQue, AmLich amLich)
        {
            var queIndex = new QueIndex();

            switch (cachLayQue)
            {
                case CachLayQue.None:
                    break;

                case CachLayQue.MaiHoaTienThien1:
                    queIndex = _layQueService.GetQueIndexByTime(amLich, txtSoHoacChu.Text);
                    break;

                case CachLayQue.MaiHoaTienThien2:
                    queIndex = _layQueService.GetQueIndexBySoAndTime(amLich, txtQueNgoai1.Text);
                    break;

                case CachLayQue.MaiHoaTienThien3:
                    queIndex = _layQueService.GetQueIndexBySoAndSo(txtQueNgoai2.Text, txtQueNoi2.Text, amLich, chkCongChiGio.Checked);
                    break;

                default:
                    break;
            }

            return queIndex;
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

            radThoiGian.Checked = true;
        }

        private void chkUseNamCan_CheckedChanged(object sender, EventArgs e)
        {
            GetQue();
        }

        private void uiHour_ValueChanged(object sender, EventArgs e)
        {
            _dontUpdateBack = true;

            SetChiCuaGio();

            _dontUpdateBack = false;
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

        private void cbxGioChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_dontUpdateBack)
            {
                // Cập nhật giờ dựa vào địa chi đã chọn.
                var datePart = uiHour.Value.Date;
                var chiGioIndexSelected = cbxGioChi.SelectedIndex;
                var newHour = TimeSpan.FromHours(chiGioIndexSelected * 2);
                var newMinute = TimeSpan.FromMinutes(DuongLich.TimeOfDay.Minutes);

                uiHour.Value = datePart + newHour + newMinute;
            }

            UpdateButtonsBackColor(cbxGioChi.SelectedIndex);

            radThoiGian.Checked = true;

            GetQue();
        }

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.MaiHoaTienThien1;

            txtSoHoacChu.Enabled = true;
            txtQueNgoai1.Enabled = false;
            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Enabled = false;
            chkCongChiGio.Enabled = false;

            txtSoHoacChu.Focus();

            GetQue();
        }

        private void radNgoaiSo_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.MaiHoaTienThien2;

            txtSoHoacChu.Enabled = false;
            txtQueNgoai1.Enabled = true;
            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Enabled = false;
            chkCongChiGio.Enabled = false;
            
            txtQueNgoai1.Focus();

            GetQue();
        }

        private void radioNgoaiSoNoiSo_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.MaiHoaTienThien3;

            txtSoHoacChu.Enabled = false;
            txtQueNgoai1.Enabled = false;
            txtQueNgoai2.Enabled = true;
            txtQueNoi2.Enabled = true;
            chkCongChiGio.Enabled = true;

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCongChiGio_CheckedChanged(object sender, EventArgs e)
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

            // Set back to use Thoi Gian.
            radThoiGian.Checked = true;

            GetQue();
        }

        private void FormQueThoiGian_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnGo.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnLoadCurrentDateTime.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void onTextBoxEntered(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            textbox?.SelectAll();
        }

        private int GetButtonIndex(Button btn)
        {
            for (int i = 0; i < _diaChiButtons.Count; i++)
            {
                if (btn == _diaChiButtons[i])
                {
                    return i;
                }
            }

            return 0;
        }

        private void UpdateButtonsBackColor(int clickedIndex)
        {
            for (int i = 0; i < _diaChiButtons.Count; i++)
            {
                if (i == clickedIndex)
                {
                    _diaChiButtons[i].BackColor = _selectedColor;
                    _diaChiButtons[i].ForeColor = Color.White;
                }
                else
                {
                    _diaChiButtons[i].BackColor = _normalColor;
                    _diaChiButtons[i].ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// 12 buttons event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn12DiaChi_Click(object sender, EventArgs e)
        {
            var index = GetButtonIndex((Button)sender);
            cbxGioChi.SelectedIndex = index;

            radThoiGian.Checked = true;
        }

        /// <summary>
        /// 12 buttons event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn12DiaChi_Enter(object sender, EventArgs e)
        {
            ((Button)sender).PerformClick();
        }
    }

}
