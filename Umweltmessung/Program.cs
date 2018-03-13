using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Umweltmessung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a city please: ");

            var city = Console.ReadLine();
            const string key = "2785304a2ce3d2d4466384569feb76e8";
            var url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream() ?? throw new InvalidOperationException()))
            {
                response = streamReader.ReadToEnd();
            }

            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            Console.WriteLine("Weather in {0}: ", weatherResponse.Name);
            Console.WriteLine("Temperature : {0} °C",  weatherResponse.Main.Temp);
          

            Console.ReadLine();
        }
    }
 
}
