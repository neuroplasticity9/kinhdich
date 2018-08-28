using System;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon
{
    public static class DateTimeExtensions
    {
        public static CanChi GetNgayAm(this DateTime date)
        {
            return new CanChi { Can = Nham, Chi = Thin };
        }

        public static CanChi GetThangAm(this DateTime date)
        {
            return new CanChi { Can = Canh, Chi = Than };
        }

        public static CanChi GetNamAm(this DateTime date)
        {
            // Mod 10 => 0=Canh, 1=Tân, 2=Nhâm, ..., 9=Kỷ
            var canIndex = date.Year % 10 + 6;
            if (canIndex >= 10)
            {
                canIndex -= 10;
            }

            // Mod 12 => 0=Thân, 1=Dậu, 2=Tuất, ..., 11=Mùi.
            var chiIndex = date.Year % 12 - 4;
            if (chiIndex < 0)
            {
                chiIndex += 12;
            }

            return new CanChi { Can = ThienCan.All[canIndex], Chi = DiaChi.All[chiIndex] };
        }
    }
}
