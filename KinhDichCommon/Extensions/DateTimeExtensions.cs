using System;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon
{
    public static class DateTimeExtensions
    {
        public static CanChi GetNgayAm(this DateTime date)
        {
            return new CanChi { Can = Mau, Chi = Thin };
        }

        public static CanChi GetThangAm(this DateTime date)
        {
            return new CanChi { Can = Nham, Chi = Than };
        }
    }
}
