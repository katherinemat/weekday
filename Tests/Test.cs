using Xunit;
using System;
using System.Collections.Generic;

namespace WeekdayFinder.Objects
{
  public class WeekdayFinderTest
  {
      [Fact]
      public void InputToday_ConvertToDateTime_ReturnDayOfWeek()
      {
          int day = 16;
          int month = 02;
          int year = 2017;
          Weekday newWeekday = new Weekday(day, month, year);
          string output = newWeekday.IsWeekday();
          Assert.Equal("Thursday", output);
      }
  }
}
