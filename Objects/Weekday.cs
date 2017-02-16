using Nancy;
using System;
using System.Collections.Generic;

namespace WeekdayFinder.Objects
{
    public class Weekday
    {
        private int _day;
        private int _month;
        private int _year;
        private DateTime _dateTime;

        public Weekday (int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
            _dateTime = new DateTime(year, month, day);
        }

        public string IsWeekday()
        {
            return _dateTime.DayOfWeek.ToString();
        }
    }
}
