using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public void MyCar()
        {
            Console.WriteLine($"My car is a {Year} {Make} {Model}, and I'm keeping it until the wheels fall off!");
        }
    }
}
