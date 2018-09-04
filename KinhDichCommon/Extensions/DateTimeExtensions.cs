using System;

namespace KinhDichCommon
{
    public static class DateTimeExtensions
    {
        public static AmLich ToAmLich(this DateTime date)
        {
            DateTime selectedDate = date;

            var selectedTime = selectedDate.TimeOfDay;
            if (selectedTime >= TimeSpan.FromHours(23))
            {
                // Increase 1 day if it passed 11PM.
                selectedDate = selectedDate.AddDays(1);
            }

            return Calendar.ConvertSolar2Lunar(selectedDate);
        }
    }
}
