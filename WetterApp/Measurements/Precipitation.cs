using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.Measurements
{
    public class Precipitation : IMeasurable
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public List<int> MeassureList { get; set; }
        private int _dayCount;

        private Precipitation(int minValue = 800, int maxValue = 1100)
        {
            MaxValue = maxValue;
            MinValue = minValue;
            MeassureList = new List<int>();
        }

        public Precipitation(int dayCount)
            : this()
        {
            this._dayCount = dayCount;
        }

        public List<int> GetWeatherDates()
        {
            var precipitationRandomizer = new Random();

            for (var i = 0; i < _dayCount; i++)
            {
                MeassureList.Add(precipitationRandomizer.Next(MinValue, MaxValue));
            }
            return MeassureList;
        }

        public void PrintArray()
        {
            foreach (var x in MeassureList)
                Console.WriteLine("Day {0} - Precipitation: {1} mm", MeassureList.IndexOf(x) + 1, x);
        }

        public void PrintMiddleValue()
        {
            Console.WriteLine("Average precipitation: {0} mm", MeassureList.Sum() / MeassureList.Count);
        }
    }
}
