using Nancy;
using WeekdayFinder.Objects;
using System;
using System.Collections.Generic;

namespace WeekdayFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        int userDay = int.Parse(Request.Form["day"]);
        int userMonth = int.Parse(Request.Form["month"]);
        int userYear = int.Parse(Request.Form["year"]);
        Weekday newWeekday = new Weekday(userDay, userMonth, userYear);
        string userOutput = newWeekday.IsWeekday();
        return View["index.cshtml", userOutput];
      };
    }
  }
}
