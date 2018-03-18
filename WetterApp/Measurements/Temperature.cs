using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.Measurements
{
    public class Temperature : IMeasurable
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public List<int> MeassureList { get; set; }
        private int _dayCount;

        private Temperature(int minValue = 0, int maxValue = 30)
        {
            MaxValue = maxValue;
            MinValue = minValue;
            MeassureList = new List<int>();
        }

        public Temperature(int dayCount)
           : this()
        {
            this._dayCount = dayCount;
        }

        public List<int> GetWeatherDates()
        {
            var temperaturRandomizer = new Random();

            for (var i = 0; i < _dayCount; i++)
            {
                MeassureList.Add(temperaturRandomizer.Next(MinValue, MaxValue));
            }
            return MeassureList;
        }

        public void PrintArray()
        {
            foreach (var x in MeassureList)
                Console.WriteLine("Day {0} - Temperature: {1} ∘C", MeassureList.IndexOf(x) + 1, x);
        }

        public void PrintMiddleValue()
        {
            Console.WriteLine("Average temperature: {0} ∘C", MeassureList.Sum() / MeassureList.Count);
        }
    }
}
