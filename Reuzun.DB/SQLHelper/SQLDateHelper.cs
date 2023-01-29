using System;

namespace Reuzun.DB.SQLHelper
{
    public class SQLDateHelper : ISQLDateHelper
    {

        /// <summary>
        /// Simply replace the 'T' letter in Date.
        /// </summary>
        /// <param name="Date"></param>
        /// <returns>string: Date without including 'T'</returns>
        public string FixSQLDate(string Date)
        {
            return Date.Replace("T", " ");
        }

        /// <summary>
        /// Returns the date part of DateTime Object.
        /// E.g 2022.12.12
        /// Supports YearToDay and DayToYear
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="seperator"></param>
        /// <param name="DateStyle"></param>
        /// <returns></returns>
        public string GetDate(DateTime Date, char seperator = ':', DateStyleEnum DateStyle = DateStyleEnum.DayToYear)
        {
            return DateStyle.Equals(DateStyleEnum.DayToYear) ?
                string.Join(seperator, new int[] { Date.Day, Date.Month, Date.Year }) :
                string.Join(seperator, new int[] { Date.Year, Date.Month, Date.Day });
        }

        /// <summary>
        /// Returns the clock part of DateTime.
        /// 14.23.18
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public string GetClock(DateTime Date, char seperator = ':')
        {
            return string.Join(seperator, new int[] { Date.Hour, Date.Minute, Date.Second });
        }
    }
}
