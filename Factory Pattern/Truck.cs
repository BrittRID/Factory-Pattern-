using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Truck : IVehicle 
    {
        public string color { get; set; }

        public bool BedSize { get; set; }

        public void Drive()
        {
            Console.WriteLine("Truck bed size!");
        }

    }


}



