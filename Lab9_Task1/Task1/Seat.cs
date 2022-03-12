using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Seat
    {
        public string comfortibility;
        public string presence;

        public void SeatInformation()
        {
            Console.WriteLine("...........................................................");
            Console.WriteLine();
            Console.WriteLine("Seat Information:");
            Console.WriteLine("..................................");
            Console.WriteLine("Seat Comfortibility:" + " " + comfortibility);
            Console.WriteLine("   Presence of seat:" + " " + presence);
            Console.WriteLine("..................................");
            Console.WriteLine(" ");
            Console.WriteLine("Click Enter For More Details!!!");
           
            Console.ReadLine();

        }
    }
}
