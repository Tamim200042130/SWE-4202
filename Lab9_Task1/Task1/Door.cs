using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Door
    {
        public string openingMode;

        public void DoorOpenInformation()
        {
            Console.WriteLine("...........................................................");
            Console.WriteLine();
            Console.WriteLine("Door Open Information:");
            Console.WriteLine("......................");
            Console.WriteLine("Door Open:"+" "+openingMode);
            Console.WriteLine("......................");
            Console.ReadKey();

        }
    }
}
