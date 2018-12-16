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
        private Color _normalColor;
        private Color _selectedColor = Color.Blue;
        private List<Button> _diaChiButtons = new List<Button>();
        private LayQueService _layQueService = new LayQueService();

        private FormTimTen _formTimTen = new FormTimTen();
        private FormQueHoc _formHoc = new FormQueHoc();

        private int _selectedChiCuaGio = 0;

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

            _diaChiButtons[_selectedChiCuaGio].PerformClick();

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
            var listQueTrong1Ngay = _layQueService.GetAllQueIndexesForADay(AmLich, "");

            for (int i = 0; i < _diaChiButtons.Count; i++)
            {
                _diaChiButtons[i].Text = GetButtonText(listQueTrong1Ngay[i]);
            }

            QueIndex queGioMui = listQueTrong1Ngay[7];
            int dongHaoGioTi = queGioMui.HaoDongNumber - 1 <= 0 ? 6 : queGioMui.HaoDongNumber - 1;

            labelNgayDich.Text = $"Ngày {queGioMui.GetQueChu().NgoaiQuai.Tuong}.  Giờ Mùi động hào {queGioMui.HaoDongNumber}";
        }

        private string GetButtonText(QueIndex queIndex)
        {
            LucThu thu = LucThu.GetLucThu(AmLich.NgayAm.Can, queIndex.HaoDongNumber - 1);

            return $"{queIndex.GetQueChu().NameShort} → {queIndex.GetQueBien().NameShort} ({thu.Name} - {queIndex.HaoDongNumber})";
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

            txtCalculationDesc.Text = queIndex.Desc;

            ucQueDich.uiNgoaiQuai.SelectedIndex = queIndex.NgoaiQuaiIndex;
            ucQueDich.uiNoiQuai.SelectedIndex = queIndex.NoiQuaiIndex;

            ucQueDich.ResetHaoDong();
            ucQueDich.uiIsHao1Dong.Checked = queIndex.HaoDongNumber == 1;
            ucQueDich.uiIsHao2Dong.Checked = queIndex.HaoDongNumber == 2;
            ucQueDich.uiIsHao3Dong.Checked = queIndex.HaoDongNumber == 3;
            ucQueDich.uiIsHao4Dong.Checked = queIndex.HaoDongNumber == 4;
            ucQueDich.uiIsHao5Dong.Checked = queIndex.HaoDongNumber == 5;
            ucQueDich.uiIsHao6Dong.Checked = queIndex.HaoDongNumber == 6;

            var queService = new VietDichQueService(this);
            txtQueDesc.Text = queService.GetQueDesc();
        }

        private QueIndex GetQueIndex(CachLayQue cachLayQue, AmLich amLich)
        {
            var queIndex = new QueIndex();

            switch (cachLayQue)
            {
                case CachLayQue.None:
                    break;

                case CachLayQue.ThoiGianOnly:
                    queIndex = _layQueService.GetQueIndexByTime(amLich, "");
                    break;

                case CachLayQue.SoOnly:
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
            SetChiCuaGio();
        }

        private void SetChiCuaGio()
        {
            int chiIndex = GetCurrentChiCuaGio();

            _selectedChiCuaGio = chiIndex;

            OnUpdatedChiCuaGio(chiIndex);
        }

        private int GetCurrentChiCuaGio()
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

            return chiIndex;
        }

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.ThoiGianOnly;

            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Enabled = false;
            chkCongChiGio.Enabled = false;

            GetQue();
        }

        private void radioNgoaiSoNoiSo_CheckedChanged(object sender, EventArgs e)
        {
            CachLayQue = CachLayQue.SoOnly;

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
                btnLoadCurrentDateTime.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnHoc.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnTimTen.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnCopy.PerformClick();
            }
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            _formTimTen.ShowDialog(this);
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
            radThoiGian.Checked = true;

            var index = GetButtonIndex((Button)sender);
            _selectedChiCuaGio = index;

            OnUpdatedChiCuaGio(_selectedChiCuaGio);

            GetQue();
        }

        private void OnUpdatedChiCuaGio(int selectedChiCuaGio)
        {
            // Cập nhật giờ dựa vào địa chi đã chọn.
            var datePart = uiHour.Value.Date;
            var newHour = TimeSpan.FromHours(selectedChiCuaGio * 2);
            var newMinute = TimeSpan.FromMinutes(DuongLich.TimeOfDay.Minutes);

            uiHour.Value = datePart + newHour + newMinute;

            UpdateButtonsBackColor(selectedChiCuaGio);
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtQueDesc.Text);

            MessageBox.Show(this, "Đã copy kết quả vào clipboard.");
        }

        private void btnHoc_Click(object sender, EventArgs e)
        {
            _formHoc.ShowDialog(this);
        }
    }

}
