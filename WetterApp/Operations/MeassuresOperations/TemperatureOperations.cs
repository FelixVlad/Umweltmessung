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
                        Console.WriteLine("Please, enter amount of days:");
                        numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                        days = dayList.Take(numOfDays);
                        foreach (var day in days)
                        {
                            Console.WriteLine("Day {0} - Temperature: {1}∘C", dayList.IndexOf(day) + 1,
                                day.Temperature);
                        }

                        break;

                    case "CD":
                        Console.WriteLine("Please, enter day number:");
                        var dayNumber = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                        Console.WriteLine("Day {0} - Temperature: {1}∘C", dayNumber, dayList[dayNumber - 1].Temperature);
                        break;
                    case "AT":
                        Console.WriteLine("Please, enter amount of days:");
                        numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                        days = dayList.Take(numOfDays);
                        foreach (var day in days)
                        {
                            temperatureSum += day.Temperature;
                        }

                        var average = temperatureSum / days.Count();
                        Console.WriteLine("Average temperature for last {0} days: {1}", days.Count(), average);
                        break;

                    case "DF":
                        days = dayList.Take(10);
                        foreach (var day in days)
                        {
                            Console.WriteLine("Day {0} - Temperature: {1}∘C", dayList.IndexOf(day) + 1,
                                day.Temperature);
                            temperatureSum += day.Temperature;
                        }

                        var defaultAverage = temperatureSum / days.Count();
                        Console.WriteLine("Average temperature for last 10: {0}∘C", defaultAverage);
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
