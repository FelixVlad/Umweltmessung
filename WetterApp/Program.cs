using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Models;
using WetterApp.Operations;

namespace WetterApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var days = DaysGenerator.GetDays();

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

            while (command.ToUpper() != "EX")
            {
                Console.Write(">");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    Environment.Exit(0);

                command = input.Substring(0, 2);
                WeatherOperations.GetInfo(input, days);
            }
            Environment.Exit(0);
        }
    }
}