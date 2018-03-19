using System;
using System.Collections.Generic;
using WetterApp.Models;
using WetterApp.Operations.MeassuresOperations;

namespace WetterApp.Operations
{
    public static class WeatherOperations
    {
        public static void GetInfo(string input, List<Day> daysList)
        {
            while (input.ToUpper() != "EX")
            {
                if (string.IsNullOrWhiteSpace(input))
                    Environment.Exit(0);

                string commandInput;
                switch (input.ToUpper())
                {
                    case "TC":
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("<Temperature>");
                        Console.WriteLine("ad : Weather on a certain amount of days" + "\r\n" +
                                          "(for each day separately)");
                        Console.WriteLine("cd : Weather on a certain day");
                        Console.WriteLine("at : Average temperrature over a period");
                        Console.WriteLine("df : Default weather data (last 10 days)");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("ex : - Exit");
                        Console.WriteLine("============================================");
                        Console.Write(">");
                        commandInput = Console.ReadLine();
                        if (commandInput != null)
                        {
                            commandInput = commandInput.Substring(0, 2);
                            TemperatureOperations.CommandSwitchTc(commandInput, daysList);
                        }

                        break;

                    case "AP":
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("<Air Pressure>");
                        Console.WriteLine("ad : Weather on a certain amount of days" + "\r\n" +
                                          "(for each day separately)");
                        Console.WriteLine("cd : Weather on a certain day");
                        Console.WriteLine("aa : Average pressure over a period");
                        Console.WriteLine("df : Default weather data (last 10 days)");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("ex : - Exit");
                        Console.Write(">");
                        commandInput = Console.ReadLine();
                        if (commandInput != null)
                        {
                            commandInput = commandInput.Substring(0, 2);
                            AirPressureOperations.CommandSwitchAp(commandInput, daysList);
                        }

                        break;

                    case "PM":
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("<Precipitation>");
                        Console.WriteLine("ad : Weather on a certain amount of days" + "\r\n" +
                                          "(for each day separately)");
                        Console.WriteLine("cd : Weather on a certain day");
                        Console.WriteLine("ap : Average precipitation over a period");
                        Console.WriteLine("df : Default weather data (last 10 days)");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("ex : - Exit");
                        Console.Write(">");
                        commandInput = Console.ReadLine();
                        if (commandInput != null)
                        {
                            commandInput = commandInput.Substring(0, 2);
                            PrecipitationsOperations.CommandSwitchPm(commandInput, daysList);
                        }

                        break;

                    case "EX":
                    {
                        Console.WriteLine("Application closing...");
                        break;
                    }

                    default:
                        Console.WriteLine("Unknown Command " + input.ToLower());
                        Console.WriteLine("Please, make sure you are using the correct command or try again later.");
                        break;
                }
            }
        }

        public static int GetNumberOfDays(string input)
        {
            try
            {
                var days = Convert.ToInt32(input);

                if (days < 367 && days >0)  
                    return days;
                
                else
                {
                    Console.WriteLine("Please write a valid number of days (between 1 and 366)");
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Make sure you wrote a positive number {0}", e.Message);
                return 0;
            }
        }
        public static int GetNumberOfPressure(string input)
        {
            try
            {
                var pressure = Convert.ToInt32(input);

                if (pressure < 1200 && pressure > 700)  
                    return pressure;
                
                else
                {
                    Console.WriteLine("Please write a valid number (between 700 and 1200)");
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Make sure you wrote a positive number {0}", e.Message);
                return 0;
            }
        }
        public static int GetNumberOfTemerature(string input)
        {
            try
            {
                var temperature = Convert.ToInt32(input);

                if (temperature < -50 && temperature > 50)  
                    return temperature;
                
                else
                {
                    Console.WriteLine("Please write a valid number (between -50 and 50)");
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static int GetNumberOfPrecipitation(string input)
        {
            try
            {
                var precipitation = Convert.ToInt32(input);

                if (precipitation < 11 && precipitation > -1)  
                    return precipitation;
                
                else
                {
                    Console.WriteLine("Please write a valid number (between 0 and 10)");
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Make sure you wrote a positive number {0}", e.Message);
                return 0;
            }
        }
    }
}
