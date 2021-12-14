using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class VehicleFactor
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() {color ="Red", isDriveable = true };
                case "Motorcycle":
                    return new Motorcycle();
                case "Truck":
                    return new Truck();
                    
                case "BigRig":
                    return new BigRig();
                   
                case "SUV":
                    return new SUV();
                  
                default:
                    return new Car();
            }
        }
    }
}
