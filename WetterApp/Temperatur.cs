using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
    class Temperatur
    {
        Random temperaturRandomizer = new Random();
        private const int MinNumber = 0;
        private const int MaxNumber = 30;

        public int[] GetRandomTemperaturArray(int arraySize)
        {

            var intArray = new int[arraySize];

            for (var i = 0; i < arraySize; i++)
            {
                intArray[i] = temperaturRandomizer.Next(MinNumber, MaxNumber + 1);
            }

            return intArray;
        }

        public void ShowTemperatur(Array array)
        {
            foreach (int x in array)
            {
                Console.WriteLine("Tag {0} - Temperatur: {1} ∘C", Array.IndexOf(array, x) + 1 , x );
            }
        }

        public int TemperaturMittelWert(params int[] array)
        {
            var sum = 0;
            var result = 0;

            foreach (var tage in array)
            {
                sum += tage;
                result = sum / array.Length;
            }

            return result;
        }
    }
}
