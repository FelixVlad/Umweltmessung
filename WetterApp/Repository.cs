using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Models;

namespace WetterApp
{
    public class Repository
    {
        public Repository()
        {
            var rnd = new Random();

            for (var i=0; i<367; i++)
            {
                Days.Add(new Day(rnd.Next(800, 1000), rnd.Next(0, 10), rnd.Next(0, 30)));
            }
        }

        private List<Day> Days { get; set; }
    }
}
