using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class SUV : IVehicle
    {

        public string color { get; set; }

        public bool Gas { get; set; }

        public void Drive()
        {
            Console.WriteLine("How much gas does it cost to fill up a tank!");
        }
    }
}
