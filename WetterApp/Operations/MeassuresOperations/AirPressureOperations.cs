using System;
using System.Collections.Generic;
using System.Linq;
using WetterApp.Models;

namespace WetterApp.Operations.MeassuresOperations
{
    public static class AirPressureOperations
    {
        public static void CommandSwitchAP(string input, List<Day> dayList)
        {
            int numOfDays;
            IEnumerable<Day> days;
            var airPressureSum = 0;
            switch (input.ToUpper())
            {
                case "AD":
                    Console.WriteLine("Please, enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        Console.WriteLine("Day {0} - Air Pressure: {1} mbar", dayList.IndexOf(day) + 1,day.AirPressure);
                    }
                    break;
                case "CD":
                    Console.WriteLine("Please, enter day number:");
                    var dayNumber = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    Console.WriteLine("Day {0} - Air Pressure: {1} mbar", dayNumber, dayList[dayNumber - 1].AirPressure);
                    break;
                case "AA":
                    Console.WriteLine("Please, enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        airPressureSum += day.AirPressure;
                    }

                    var average = airPressureSum / days.Count();
                    Console.WriteLine("Average air Pressure for last {0} days: {1} mbar", days.Count(), average);
                    break;
                case "DF":
                    days = dayList.Take(10);
                    foreach (var day in days)
                    {
                        Console.WriteLine("Day {0} - Air Pressure: {1} mbar", dayList.IndexOf(day) + 1,day.AirPressure);
                        airPressureSum += day.AirPressure;
                    }

                    var defaultAverage = airPressureSum / days.Count();
                    Console.WriteLine("Average air Pressure for last 10 days: {0} mbar", defaultAverage);
                    Console.WriteLine();
                    break;
                case "EX":
                {
                    Console.WriteLine("Application closing...");
                    Environment.Exit(0);
                    break;
                }
                default:
                    Console.WriteLine("Unknown Command " + input.ToLower());
                    Console.WriteLine("Please, make sure you are using the correct command or try again later.");
                    break;
            }
        }
    }
}
