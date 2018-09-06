﻿using System;
using System.Windows.Forms;
using DoanQueKinhDich.Business;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    public enum CachLayQue
    {
        None = 0,
        MaiHoaTienThien1 = 1,
        MaiHoaTienThien2 = 2,
        MaiHoaTienThien3 = 3,
    }

    public class QueIndex
    {
        public int NgoaiQuaiIndex { get; set; }
        public int NoiQuaiIndex { get; set; }
        public int HaoDongIndex { get; set; }
    }

    public partial class FormQueThoiGian : Form, IQue, IQueThoi
    {
        private string _queChuUrl;
        private string _queBienUrl;
        private CachLayQue _cachLayQue;

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
        public AmLich AmLich { get; private set; }

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
            // Test
            uiDatePicker.Value = new DateTime(1983, 3, 13);

            radThoiGian.Checked = true;

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
            AmLich = uiDate.SelectionRange.Start.ToAmLich();

            IsDone = true;

            SetUIControls(AmLich);

            SetNoiQuaiNgoaiQuai(AmLich);
        }
        
        private void SetNoiQuaiNgoaiQuai(AmLich amLich)
        {
            var queIndex = new QueIndex();

            switch (_cachLayQue)
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

            ucQueDich.uiNgoaiQuai.SelectedIndex = queIndex.NgoaiQuaiIndex;
            ucQueDich.uiNoiQuai.SelectedIndex = queIndex.NoiQuaiIndex;
            
            ucQueDich.uiHao1Dong.Checked = queIndex.HaoDongIndex == 1;
            ucQueDich.uiHao2Dong.Checked = queIndex.HaoDongIndex == 2;
            ucQueDich.uiHao3Dong.Checked = queIndex.HaoDongIndex == 3;
            ucQueDich.uiHao4Dong.Checked = queIndex.HaoDongIndex == 4;
            ucQueDich.uiHao5Dong.Checked = queIndex.HaoDongIndex == 5;
            ucQueDich.uiHao6Dong.Checked = queIndex.HaoDongIndex == 0;
        }

        private QueIndex GetQueIndexBySoAndTime(string textCuaQuai, AmLich amLich)
        {
            int tongNgoaiQuai = GetTongCuaQuai(textCuaQuai);
            int tongNoiQuai = GetTongNamThangNgayGio(amLich);

            return new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1) % 8,
                HaoDongIndex = (tongNgoaiQuai + tongNoiQuai + amLich.GioAm.Chi.Id) % 6,
            };
        }

        private QueIndex GetQueIndexBySoAndSo(string textCuaNgoaiQuai, string textCuaNoiQuai, AmLich amLich)
        {
            int tongNgoaiQuai = GetTongCuaQuai(textCuaNgoaiQuai);
            int tongNoiQuai = GetTongCuaQuai(textCuaNoiQuai);

            return new QueIndex
            {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1) % 8,
                HaoDongIndex = (tongNgoaiQuai + tongNoiQuai + amLich.GioAm.Chi.Id) % 6,
            };
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
            int tongNgoaiQuai = GetTongNamThangNgay(amLich);
            int tongNoiQuai = GetTongNamThangNgayGio(amLich);

            return new QueIndex {
                NgoaiQuaiIndex = (tongNgoaiQuai - 1) % 8,
                NoiQuaiIndex = (tongNoiQuai - 1) % 8,
                HaoDongIndex = tongNoiQuai % 6,
            };
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
            Chi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
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

            Chi gioChi = DiaChi.All[cbxGioChi.SelectedIndex];
            Can gioCan = amLich.GetCanCuaGio(gioChi);
            cbxGioCan.SelectedIndex = gioCan.Id - 1;

            labelNgayAmLich.Text = $"Ngày âm lịch: {amLich.LunarYear}-{amLich.LunarMonth}-{amLich.LunarDay}";
            labelNgayDuongLich.Text = $"Ngày dương lịch: {amLich.SonarDate.Year}-{amLich.SonarDate.Month}-{amLich.SonarDate.Day}";
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

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            _cachLayQue = CachLayQue.MaiHoaTienThien1;

            chkUseNamCan.Enabled = true;
            txtQueNgoai1.Text = "";
            txtQueNgoai1.Enabled = false;
            txtQueNgoai2.Text = "";
            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Text = "";
            txtQueNoi2.Enabled = false;
        }

        private void radNgoaiSo_CheckedChanged(object sender, EventArgs e)
        {
            _cachLayQue = CachLayQue.MaiHoaTienThien2;

            chkUseNamCan.Enabled = false;
            txtQueNgoai1.Text = "";
            txtQueNgoai1.Enabled = true;
            txtQueNgoai2.Text = "";
            txtQueNgoai2.Enabled = false;
            txtQueNoi2.Text = "";
            txtQueNoi2.Enabled = false;

            txtQueNgoai1.Focus();
        }

        private void radioNgoaiSoNoiSo_CheckedChanged(object sender, EventArgs e)
        {
            _cachLayQue = CachLayQue.MaiHoaTienThien3;

            chkUseNamCan.Enabled = false;
            txtQueNgoai1.Text = "";
            txtQueNgoai1.Enabled = false;
            txtQueNgoai2.Text = "";
            txtQueNgoai2.Enabled = true;
            txtQueNoi2.Text = "";
            txtQueNoi2.Enabled = true;

            txtQueNgoai2.Focus();
        }
    }
}
