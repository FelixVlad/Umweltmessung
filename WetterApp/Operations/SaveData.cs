using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using WetterApp.Models;

namespace WetterApp.Operations
{
   public class SaveData
   {
       //hier muss noch das path geändert werden
        private static readonly string TemperatuePath = "C:\\Users\\Vladislav Sincariuc\\Desktop\\Temperatur.txt";
        private static readonly string AirPressurePath = "C:\\Users\\Vladislav Sincariuc\\Desktop\\Air Pressure.txt";
        private static readonly string PrecipitationPath = "C:\\Users\\Vladislav Sincariuc\\Desktop\\Precipitation.txt";

        public static void SaveTemperature(List<Day> days)
        {
            // Write multiple line to new file.
            using (var writer = new StreamWriter(TemperatuePath))
            {
                foreach (var day in days)
                {
                    writer.WriteLine("Day {0} - Temperature: {1}∘C", days.IndexOf(day) + 1, day.Temperature);
                }
            }
        }
        public static void SaveAirPressure(List<Day> days)
        {
            // Write multiple line to new file.
            using (var writer = new StreamWriter(AirPressurePath))
            {
                foreach (var day in days)
                {
                    writer.WriteLine("Day {0} - Air Pressure: {1} mbar", days.IndexOf(day) + 1, day.AirPressure);
                }
            }
        }
        public static void SavePrecipitation(List<Day> days)
        {
            // Write multiple line to new file.
            using (var writer = new StreamWriter(PrecipitationPath))
            {
                foreach (var day in days)
                {
                    writer.WriteLine("Day {0} - Precipitation: {1} mm", days.IndexOf(day) + 1, day.Precipitation);
                }
            }
        }
   }
}
