using System;

namespace Factory_Pattern
{
    class Program
    {
        private static object myVehicle;

        static void Main(string[] args)
        {
            Console.WriteLine("What type of car do you want to make");

            string userInput = Console.ReadLine();


            VehicleFactor factory = new VehicleFactor();
            IVehicle myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Let's make a batman vehicle");

            userInput = Console.ReadLine();

            Console.WriteLine("WHY are you texting and driving");

            userInput = Console.ReadLine();

        }
    }
}
