using System;
using System.Collections.Generic;
using System.Linq;
using WetterApp.Models;

namespace WetterApp.Operations.MeassuresOperations
{
    public static class PrecipitationsOperations
    {
        public static void CommandSwitchPm(string input, List<Day> dayList)
        {
            int numOfDays;
            IEnumerable<Day> days;
            var precipitationsSum = 0;
            switch (input.ToUpper())
            {
                case "AD":
                    Console.WriteLine("Please, enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        Console.WriteLine("Day {0} - Precipitation: {1} mm", dayList.IndexOf(day) + 1, day.Precipitation);
                    }
                    break;
                case "CD":
                    Console.WriteLine("Please, enter day number:");
                    var dayNumber = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    Console.WriteLine("Day {0} - Precipitation: {1} mm", dayNumber, dayList[dayNumber - 1].Precipitation);

                    Console.WriteLine("Do you want to edit this entry? (Y/N)");
                    var answer = Console.ReadLine();

                    if (answer != null && (answer.ToUpper() == "Y" || answer.ToUpper() == "YES"))
                    {
                        Console.WriteLine("Please, enter a new value for this day: ");
                        var newDay = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                        dayList[dayNumber - 1].Precipitation = newDay;

                        Console.WriteLine("Value changed successfully! : Day {0} - Precipitation: {1} mm", dayNumber, dayList[dayNumber - 1].Precipitation);

                        Console.WriteLine("Do you want to save changes in a external file? (Y/N)");
                        var saveAnswer = Console.ReadLine();

                        if (saveAnswer != null && (saveAnswer.ToUpper() == "Y" || saveAnswer.ToUpper() == "YES"))
                        {
                            SaveData.SavePrecipitation(dayList);
                            Console.WriteLine("Value saved successfully!");
                        }

                        else if (saveAnswer != null && (saveAnswer.ToUpper() == "N" || saveAnswer.ToUpper() == "NO"))
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Unknown Command " + answer.ToLower());
                            Console.WriteLine("Please, make sure you are using the correct command or try again later.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No changes commited");
                    }

                    break;
                case "AP":
                    Console.WriteLine("Please, enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        precipitationsSum += day.Precipitation;
                    }

                    var average = precipitationsSum / days.Count();
                    Console.WriteLine("Average precipitation for last {0} days: {1} mm", days.Count(), average);
                    break;
                case "DF":
                    days = dayList.Take(10);
                    foreach (var day in days)
                    {
                        Console.WriteLine("Day {0} - Precipitation: {1} mm", dayList.IndexOf(day) + 1, day.Precipitation);
                        precipitationsSum += day.Precipitation;
                    }

                    var defaultAverage = precipitationsSum / days.Count();
                    Console.WriteLine("Average precipitation for last 10: {0} mm", defaultAverage);
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
