using System;
using Xunit;

namespace Reuzun.DB.SQLHelper.Tests
{
    public class SQLDateHelper
    {
        private readonly SQLHelper.SQLDateHelper _sqlDateHelper;


        public SQLDateHelper()
        {
            _sqlDateHelper = new SQLHelper.SQLDateHelper();
        }

        [Fact]
        public void FixSQLDate_ConstantDate_RemoveT()
        {
            string Date = "2022-12-05T22:22:19";
            string ExpectedResult = "2022-12-05 22:22:19";

            string FixedDate = _sqlDateHelper.FixSQLDate(Date);

            Assert.Equal(FixedDate, ExpectedResult);
        }

        [Theory]
        [InlineData(':')]
        [InlineData('.')]
        public void GetDate_DifferentSeperators(char Seperator)
        {
            DateTime Date = DateTime.Now;
            string ExpectedResult = "" + Date.Day + Seperator + Date.Month + Seperator + Date.Year;

            string DateWithSeperator = _sqlDateHelper.GetDate(Date, Seperator);

            Assert.Equal(DateWithSeperator, ExpectedResult);
        }

        [Theory]
        [InlineData(DateStyleEnum.DayToYear)]
        [InlineData(DateStyleEnum.YearToDay)]
        public void GetDate_DifferentDateStyleEnums_Return(DateStyleEnum DateStyle)
        {
            DateTime Date = DateTime.Now;
            string ExpectedResult = DateStyle == DateStyleEnum.DayToYear ?
                "" + Date.Day + ":" + Date.Month + ":" + Date.Year :
                "" + Date.Year + ":" + Date.Month + ":" + Date.Day;

            string DateWithDateStyle = _sqlDateHelper.GetDate(Date, ':', DateStyle);

            Assert.Equal(DateWithDateStyle, ExpectedResult);
        }

        [Theory]
        [InlineData('.')]
        [InlineData(':')]
        public void GetClock_ConstantDate(char Seperator)
        {
            DateTime Date = DateTime.Now;
            string ExpectedResult = "" + Date.Hour + Seperator + Date.Minute + Seperator + Date.Second;

            string Clock = _sqlDateHelper.GetClock(Date, Seperator);

            Assert.Equal(Clock, ExpectedResult);
        }
    }

}


