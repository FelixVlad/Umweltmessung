using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Measurements;

namespace WetterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Welcome to the Weather App!");
            Console.WriteLine("============================================");
            // The string that will represent the entered command.
            // Will be a substring of input.

            var command = string.Empty;
            Console.WriteLine("Choose a command(first two letters): ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("tc : <Temperature> - Temperature in ∘C");
            Console.WriteLine("ap : <Air Pressure> - Air Pressure in mbar");
            Console.WriteLine("pm : <Precipitation> - Precipitation in mm");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("ex : - Exit");
            Console.WriteLine("============================================");

            // The ex command will automatically exit the application.
            while (command.ToUpper() != "EX")
            {
                // Read the command.
                Console.Write(">");
                var input = Console.ReadLine();

                if (input == null) continue;
                command = input.Substring(0, 2);

                switch (command.ToUpper())
                {
                    case "TC":
                    {
                        Console.WriteLine("<Temperature>");
                        Console.WriteLine("Enter a amount of days, please!");
                        try
                        {
                            var dayCount = Convert.ToInt32(Console.ReadLine());

                            if (dayCount <= 366 && dayCount > 0)
                            {
                                Console.WriteLine("Weather in the last {0} days: ", dayCount);

                                var temperatur = new Temperatur(dayCount);
                                temperatur.GetTemperatur();
                                temperatur.PrintArray();
                                temperatur.PrintMiddleValue();

                                //Console.WriteLine("Enter an exact tag: ");
                            }
                            else
                            {
                                Console.WriteLine("There was an error processing the request.");
                                Console.WriteLine("Max days number of the days is 366");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("{0} Please, make sure that you entered a number or try again later.", e);
                        }
                      break;
                    }

                    case "AP":
                    {
                        Console.WriteLine("<Air Pressure>");
                        Console.WriteLine("Enter a amount of days, please!");
                        try
                        {
                            var dayCount = Convert.ToInt32(Console.ReadLine());

                            if (dayCount <= 366 && dayCount > 0)
                            {
                                Console.WriteLine("Air pressure in the last {0} days: ", dayCount);

                                var airPressure = new LuftDruck(dayCount);
                                airPressure.GetPressure();
                                airPressure.PrintArray();
                                airPressure.PrintMiddleValue();

                                //Console.WriteLine("Enter an exact tag: ");
                            }
                            else
                            {
                                Console.WriteLine("There was an error processing the request.");
                                Console.WriteLine("Max days number of the days is 366");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("{0} Please, make sure that you entered a number or try again later.", e.Message);
                        }
                        break;
                    }
                    case "PM":
                    {
                        Console.WriteLine("<Precipitation>");
                        Console.WriteLine("Enter a amount of days, please!");
                        try
                        {
                            var dayCount = Convert.ToInt32(Console.ReadLine());

                            if (dayCount <= 366 && dayCount > 0)
                            {
                                Console.WriteLine("Air pressure in the last {0} days: ", dayCount);

                                var niederschlag = new Niederschlag(dayCount);
                                niederschlag.GetPrecipitation();
                                niederschlag.PrintArray();
                                niederschlag.PrintMiddleValue();

                                //Console.WriteLine("Enter an exact tag: ");
                            }
                            else
                            {
                                Console.WriteLine("There was an error processing the request.");
                                Console.WriteLine("Max days number of the days is 366");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("{0} Please, make sure that you entered a number or try again later.", e.Message);
                        }
                        break;
                        }
                    case "EX":
                    {
                        Console.WriteLine("Application closing...");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Unknown Command " + command.ToLower());
                        Console.WriteLine("Please, make sure you are using the correct command or try again later.");
                        break;
                    }
                }
            } 
            // Exit the application with exit code 0 (no errors).
            Environment.Exit(0);  
        }
    }
}
