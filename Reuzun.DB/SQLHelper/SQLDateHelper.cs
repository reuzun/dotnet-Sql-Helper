namespace Reuzun.DB.SQLHelper
{
    public class SQLDateHelper
    {

        public string FixSQLDate(string Date)
        {
            return Date.Replace("T", " ");
        }

    }
}
