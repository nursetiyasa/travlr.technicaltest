using System;

namespace Travlr.TechnicalTest.Core
{
    public class StringExtensions
    {
        public static string TravlrDateFormat(string dateValue, string hour, string minute)
        {
            var convertToDate = Convert.ToDateTime(dateValue);
            var travlrDateFormat = convertToDate.ToString("yyyy-MM-dd");
            var travlrDateTimeFormat = $"{travlrDateFormat}T{hour}{minute}:00";

            return travlrDateTimeFormat;
        }

        public static int TotalNights(string startDate, string startHour, string startMinute, string endDate, string endHour, string endMinute)
        {
            var startDateTime = DateTimeValue(startDate, startHour, startMinute);
            var endDateTime = DateTimeValue(endDate, endHour, endMinute);

            var objTimeSpan = endDateTime - startDateTime;

            return Convert.ToInt32(objTimeSpan.TotalDays);;
        }

        public static DateTime DateTimeValue(string dateValue, string hour, string minute)
        {
            return Convert.ToDateTime($"{dateValue} {hour}:{minute}");
        }
    }
}
