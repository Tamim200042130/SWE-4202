using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Car
    {
        public int seats;
        public int wheels;
        public int engine;
        public int doors;
        public int theMaximumAcceleration;
        public int fuelCapacity;

        public void CarInformation()
        {
           
            Console.WriteLine(" ");
            Console.WriteLine("...........................................................");
            Console.WriteLine(" ");
            Console.WriteLine("This Car has:");
            Console.WriteLine(" ");
            Console.WriteLine("Car Information:");
            Console.WriteLine(".........");
            Console.WriteLine(" Seats:"+seats );
            Console.WriteLine("wheels:" +wheels);
            Console.WriteLine(" Doors:" +doors);
            Console.WriteLine(".........");
            Console.WriteLine("");
            Console.WriteLine("..................................");
            Console.WriteLine("              Engine:"+engine + " "+ "HP"); 
            Console.WriteLine("Maximum Acceleration:"+theMaximumAcceleration + " "+"m/s");
            Console.WriteLine("       Fuel Capacity:"+fuelCapacity + " " + "Litre");
            Console.WriteLine("..................................");
            Console.WriteLine(" ");
            Console.WriteLine("Click Enter For More Details!!!");
            Console.WriteLine(" ");
            Console.ReadKey();

        }

    }
}
