using System;
using System.Collections.Generic;
using WetterApp.Models;

namespace WetterApp.Operations
{
    public static class DaysGenerator
    {
        public static List<Day> GetDays()
        {
            var days = new List<Day>();
            var rnd = new Random();

            for (var i = 0; i < 367; i++)
            {
                days.Add(new Day(rnd.Next(0, 10), rnd.Next(800, 1100), rnd.Next(0, 30)));
            }
            return days;
        }
    }
}
