﻿using System;

namespace KinhDichCommon
{
    public static class DateTimeExtensions
    {
        public static AmLich ToAmLich(this DateTime date)
        {
            return Calendar.ConvertSolar2Lunar(date);
        }

        public static NgayLayQue ToNgayLayQue(this AmLich amLich)
        {
            return new NgayLayQue(amLich);
        }
    }
}
