using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ParstebWhatsapp
{
    public class PersianCalendarTools
    {
        private static string _regex = @"^[1-1]\d{3}\/((0?[1-6]\/((3[0-1])|([1-2][0-9])|(0?[1-9])))|((1[0-2]|(0?[7-9]))\/(30|([1-2][0-9])|(0?[1-9]))))$";

        public static bool Validate(string inputDate)
        {
            bool result = false;
            try
            {
                Regex regex = new Regex(_regex);
                Match match = regex.Match(inputDate);
                if (match.Success)
                {
                    result = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public static string toPersianDate(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            string pDateTime = pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt).ToString() + "/" + pc.GetDayOfMonth(dt).ToString();
            return pDateTime;
        }

        public static string toPersianDateTime(DateTime dt)
        {
            string pDateTime = toPersianDate(dt);
            return pDateTime + " " + dt.ToString("HH:mm:ss");
        }

        public static string toPersianDate(string strDt)
        {
            string[] date = strDt.Split('/');
            DateTime dt = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
            PersianCalendar pc = new PersianCalendar();
            string pDateTime = pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt).ToString() + "/" + pc.GetDayOfMonth(dt).ToString();
            return pDateTime;
        }

        public static DateTime toGregorianDate(string date)
        {
            if (string.IsNullOrEmpty(date))
                return new DateTime();
            try
            {
                string[] parsedDate = date.Split('/');
                PersianCalendar pc = new PersianCalendar();
                DateTime result = new DateTime(int.Parse(parsedDate[0]), int.Parse(parsedDate[1]), int.Parse(parsedDate[2]), pc);
                return result;
            }
            catch
            {
                return new DateTime();
            }
        }

        public static string gregorianToShortDate(DateTime dt)
        {
            return dt.Year + "/" + dt.Month + "/" + dt.Day;
        }
    }
}
