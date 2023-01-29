using System;

namespace Reuzun.DB.SQLHelper
{
    public interface ISQLDateHelper
    {
        string FixSQLDate(string Date);
        string GetDate(DateTime Date, char seperator = ':', DateStyleEnum DateStyle = DateStyleEnum.YearToDay);
        string GetClock(DateTime Date, char seperator = ':');
    }
}
