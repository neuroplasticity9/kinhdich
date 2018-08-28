using System;
using static KinhDichCommon.DiaChi;
using static KinhDichCommon.ThienCan;

namespace KinhDichCommon
{
    public static class DateTimeExtensions
    {
        public static AmLich GetAmLich(this DateTime date)
        {
            return Calendar.ConvertSolar2Lunar(date);
        }
    }
}
