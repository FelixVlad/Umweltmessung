using System;
using System.Collections.Generic;
using System.Linq;
using WetterApp.Models;

namespace WetterApp.Operations.MeassuresOperations
{
    public static class PrecipitationsOperations
    {
        public static void CommandSwitchPM(string input, List<Day> dayList)
        {
            int numOfDays;
            IEnumerable<Day> days;
            int precipitationsSum = 0;
            switch (input.ToUpper())
            {
                case "AD":
                    Console.WriteLine("Enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        Console.WriteLine(day.Precipitation);
                    }
                    break;
                case "CD":
                    Console.WriteLine("Enter day number:");
                    var dayNumber = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    Console.WriteLine(dayList[dayNumber - 1].Precipitation);
                    break;
                case "AT":
                    Console.WriteLine("Enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        precipitationsSum += day.Precipitation;
                    }

                    var average = precipitationsSum / days.Count();
                    Console.WriteLine("Average: " + average);
                    break;
                case "DF":
                    days = dayList.Take(10);
                    foreach (var day in days)
                    {
                        Console.WriteLine(day.Precipitation);
                        precipitationsSum += day.Precipitation;
                    }

                    var average2 = precipitationsSum / days.Count();
                    Console.WriteLine("Average: " + average2);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
