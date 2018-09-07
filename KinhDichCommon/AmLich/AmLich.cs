using System;

namespace KinhDichCommon
{
    /// <summary>
    /// Ngay am lich.
    /// </summary>
    public class AmLich
    {
        public DateTime SolarDate { get; set; }

        public int LunarYear { get; set; }
        public int LunarMonth { get; set; }
        public int LunarDay { get; set; }
        public int LunarLeap { get; set; }

        private CanChi _gioAm, _ngayAm, _thangAm, _namAm;

        public CanChi NamAm => GetCanChiNam();
        public CanChi ThangAm => GetCanChiThang();
        public CanChi NgayAm => GetCanChiNgay();
        public CanChi GioAm => GetCanChiGio();

        public AmLich(int lunarYear, int lunarMonth, int lunarDay, int lunarLeap, DateTime solarDate)
        {
            this.LunarYear = lunarYear;
            this.LunarMonth = lunarMonth;
            this.LunarDay = lunarDay;
            this.LunarLeap = lunarLeap;
            this.SolarDate = SolarDate;
        }

        private CanChi GetCanChiNam()
        {
            if (_namAm == null)
            {
                // Mod 10 => 0=Canh, 1=Tân, 2=Nhâm, ..., 9=Kỷ
                // + 6 mod 10 => 0=Giap, ...
                var canIndex = (LunarYear + 6) % 10;

                // Mod 12 => 0=Thân, 1=Dậu, 2=Tuất, ..., 11=Mùi.
                // + 8 mod 12 => 0=Ti, ...
                var chiIndex = (LunarYear + 8) % 12;

                _namAm = new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
            }

            return _namAm;
        }

        private CanChi GetCanChiThang()
        {
            if (_thangAm == null)
            {
                // 0=Giap, 1=At, ...
                var canIndex = (LunarYear * 12 + LunarMonth + 3) % 10;

                // 0=Ti, 1=Suu, ..., 11=Hoi.
                var chiIndex = (LunarMonth + 1) % 12;

                _thangAm = new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
            }

            return _thangAm;
        }

        private CanChi GetCanChiNgay()
        {
            if (_ngayAm == null)
            {
                long jd = Calendar.jdFromDate(SolarDate);
                var canIndex = (int)(jd + 9) % 10;
                var chiIndex = (int)(jd + 1) % 12;

                _ngayAm = new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
            }

            return _ngayAm;
        }

        /// <summary>
        /// Giáp Kỷ hoàn gia Giáp
        /// Ất Canh, Bính tác sơ
        /// Bính Tân tòng Mậu khởi
        /// Đinh Nhâm, Canh tí cư.
        /// Mậu Quí hà phương pháp?
        /// Nhâm tí thị thuận hành.
        /// </summary>
        /// <returns></returns>
        public Can GetCanGioTi()
        {
            int gioTiCanIndex = (GetCanChiNgay().Can.Id * 2 - 2) % 10;
            return ThienCan.All[gioTiCanIndex];
        }

        /// <summary>
        /// Từ địa chi của giờ, lấy ra thiên can của giờ.
        /// </summary>
        /// <param name="chi"></param>
        /// <returns></returns>
        public Can GetCanCuaGio(Chi chi)
        {
            int chiIndex = 0;
            for (int i = 0; i < DiaChi.All.Count; i++)
            {
                if (chi == DiaChi.All[i])
                {
                    chiIndex = i;
                    break;
                }
            }

            Can canGioTi = GetCanGioTi();
            int canGioTiIndex = 0;
            for (int i = 0; i < ThienCan.All.Count; i++)
            {
                if (canGioTi == ThienCan.All[i])
                {
                    canGioTiIndex = i;
                    break;
                }
            }

            int canIndex = (canGioTiIndex + chiIndex) % 10;

            return ThienCan.All[canIndex];
        }

        public Chi GetChiCuaGio(DateTime date)
        {
            var currentTime = date.TimeOfDay;

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

            return DiaChi.All[chiIndex];
        }

        public CanChi GetCanChiGio()
        {
            if (_gioAm == null)
            {
                Chi chi = GetChiCuaGio(SolarDate);
                Can can = GetCanCuaGio(chi);

                _gioAm = new CanChi { Can = can, Chi = chi };
            }

            return _gioAm;
        }
    }
}
