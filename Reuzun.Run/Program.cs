using Reuzun.DB.SQLHelper;
using System;

namespace Reuzun.Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLDateHelper SQLHelper = new SQLDateHelper();

            string Date = "2022-12-05T22:22:19";

            Console.WriteLine(SQLHelper.FixSQLDate(Date));
        }
    }
}
