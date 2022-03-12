using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Engine
    {
        public int maximumFuelConsumptionRate;
        public int maximumEnergyProductionRate;
        public int averageRPM;

        public void EngineInformation()
        {
            Console.WriteLine("...........................................................");
            Console.WriteLine();
            Console.WriteLine("Engine Information:"); 
            Console.WriteLine(".........................................");
            Console.WriteLine(" "+"Maximum Fuel Consumption Rate:" + " " + maximumEnergyProductionRate + " " + "Lt/s");
            Console.WriteLine("Maximum Energy Production Rate:" + " " + maximumFuelConsumptionRate + " " + "HP/s");
            Console.WriteLine("\t"+ "\t"+ "   "+"Average RPM:" + " " + averageRPM + " " + "rad/s");
            Console.WriteLine(".........................................");
            Console.WriteLine();
            Console.WriteLine("Click Enter For More Details!!!");
            Console.ReadLine();

        }
    }
}
