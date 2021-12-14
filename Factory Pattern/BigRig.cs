using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class BigRig : IVehicle 
    {
        public string color { get; set; }

        public bool ManyWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("How Many Wheels!");
        }

    }
}
