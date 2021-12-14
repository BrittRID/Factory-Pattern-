using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Motorcycle : IVehicle
    {
        public string color { get; set; }

        public bool hasHandBreak { get; set; }

        public void Drive()
        {
            Console.WriteLine("Motorcycle!");
        }
    }
}
