using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Car : IVehicle
    {

        public string color { get; set; }

        public bool isDriveable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Do not disturb I am driving{color}!");
        }



    }
}
