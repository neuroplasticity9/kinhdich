using System;

namespace KinhDichCommon
{
    /// <summary>
    /// Ngay am lich.
    /// </summary>
    public class AmLich
    {
        public DateTime SonarDate { get; set; }

        public int LunarYear { get; set; }
        public int LunarMonth { get; set; }
        public int LunarDay { get; set; }
        public int LunarLeap { get; set; }

        public CanChi GetCanChiNam()
        {
            // Mod 10 => 0=Canh, 1=Tân, 2=Nhâm, ..., 9=Kỷ
            // + 6 mod 10 => 0=Giap, ...
            var canIndex = (LunarYear + 6) % 10;

            // Mod 12 => 0=Thân, 1=Dậu, 2=Tuất, ..., 11=Mùi.
            // + 8 mod 12 => 0=Ti, ...
            var chiIndex = (LunarYear + 8) % 12;

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
        }

        public CanChi GetCanChiThang()
        {
            // 0=Giap, 1=At, ...
            var canIndex = (LunarYear * 12 + LunarMonth + 3) % 10;

            // 0=Ti, 1=Suu, ..., 11=Hoi.
            var chiIndex = (LunarMonth + 1) % 12;

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
        }

        public CanChi GetCanChiNgay()
        {
            long jd = Calendar.jdFromDate(SonarDate);
            var canIndex = (int)(jd + 9) % 10;
            var chiIndex = (int)(jd + 1) % 12;

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
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
    }
}
