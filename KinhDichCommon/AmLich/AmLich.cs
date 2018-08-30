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

        public Can GetCanNgay(Chi chi)
        {
            return ThienCan.Giap;
        }
    }
}
