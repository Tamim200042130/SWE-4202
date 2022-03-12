using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("We have the Cars which are given below:");
            Console.WriteLine("1.BMW"+ "\n"+"2.Toyta");
            Console.WriteLine("Enter the number or type the car name to get the Car Information");
            Console.WriteLine();
            
            string cars = Console.ReadLine();
            Console.WriteLine(" ");

            if (cars == "BMW" || cars=="bmw" || cars=="Bmw" || cars==Convert.ToString(1))
            {
                Console.WriteLine("Your Selected Car is 'BMW'");
                Car car = new Car();

                car.seats = 6;
                car.wheels = 4;
                car.engine = 250;
                car.doors = 4;
                car.theMaximumAcceleration = 300;
                car.fuelCapacity = 150;



                car.CarInformation();


                Seat seat = new Seat();

                seat.comfortibility = "pleasent";
                seat.presence = "Warmer";

                seat.SeatInformation();

                Engine engine = new Engine();
                engine.maximumEnergyProductionRate = 250;
                engine.maximumFuelConsumptionRate = 100;
                engine.averageRPM = 80;

                engine.EngineInformation();

                Door door = new Door();

                door.openingMode = "Upward Ways";
                door.DoorOpenInformation();

            }

            else if (cars == "Toyta" || cars=="toyta"  || cars=="TOYTA" || cars == Convert.ToString(2))
            {
                Console.WriteLine("Your Selected Car is 'TOYTA'");
                Car car = new Car();

                car.seats = 8;
                car.wheels = 4;
                car.engine = 200;
                car.doors = 4;
                car.theMaximumAcceleration = 210;
                car.fuelCapacity = 120;
                car.CarInformation();


                Seat seat = new Seat();

                seat.comfortibility = "pleasent";
                seat.presence = "Warmer";
                seat.SeatInformation();

                Engine engine = new Engine();

                engine.maximumEnergyProductionRate = 210;
                engine.maximumFuelConsumptionRate = 86;
                engine.averageRPM = 68;
                engine.EngineInformation();

                Door door = new Door();

                door.openingMode = "Side Ways";
                door.DoorOpenInformation();

            }
            
            else
            {
                Console.WriteLine("Sorry,We can't find your car!!!");
                Console.ReadLine();
            }




        }
    }



}
    

