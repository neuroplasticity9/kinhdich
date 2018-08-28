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
            var canIndex = LunarYear % 10 + 6;
            if (canIndex >= 10)
            {
                canIndex -= 10;
            }

            // Mod 12 => 0=Thân, 1=Dậu, 2=Tuất, ..., 11=Mùi.
            var chiIndex = LunarYear % 12 - 4;
            if (chiIndex < 0)
            {
                chiIndex += 12;
            }

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
        }

        public CanChi GetCanChiThang()
        {
            CanChi yearCanChi = GetCanChiNam();
            var canThang1Index = yearCanChi.Can.Id * 2;
            var canIndex = canThang1Index + LunarMonth - 1;
            if (canIndex >= 10)
            {
                canIndex %= 10;
            }

            // 0=Dần, 1=Mão, ..., 11=Sửu.
            var chiIndex = LunarMonth + 1;
            if (chiIndex >= 12)
            {
                chiIndex -= 12;
            }

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
        }

        public CanChi GetCanChiNgay()
        {
            long jd = Calendar.jdFromDate(SonarDate);
            var canIndex = (int)(jd + 9) % 10;
            var chiIndex = (int)(jd + 1) % 12;

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
        }
    }
}
