using System;
using System.Collections.Generic;
using System.Linq;
using WetterApp.Models;

namespace WetterApp.Operations.MeassuresOperations
{
    public static class TemperatureOperations
    {
        public static void CommandSwitchTC(string input, List<Day> dayList)
        {
            int numOfDays;
            IEnumerable<Day> days;
            var temperatureSum = 0;
            switch (input.ToUpper())
            {
                case "AD":
                    Console.WriteLine("Enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        Console.WriteLine(day.Temperature);
                    }
                    break;
                case "CD":
                    Console.WriteLine("Enter day number:");
                    var dayNumber = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    Console.WriteLine(dayList[dayNumber - 1].Temperature);
                    break;
                case "AT":
                    Console.WriteLine("Enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        temperatureSum += day.Temperature;
                    }

                    var average = temperatureSum / days.Count();
                    Console.WriteLine("Average: " + average);
                    break;
                case "DF":
                    days = dayList.Take(10);
                    foreach (var day in days)
                    {
                        Console.WriteLine(day.Temperature);
                        temperatureSum += day.Temperature;
                    }

                    var average2 = temperatureSum / days.Count();
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
