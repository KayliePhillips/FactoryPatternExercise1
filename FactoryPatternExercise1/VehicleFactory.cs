using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    //purpose of the VehicleFactory is to ask the user for # of tires and then create a vehicle for them with that 
    //many tires.  
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {

            Console.WriteLine($"Please enter the number of tires you wish your vehicle to have:");
            var response = Console.ReadLine();

            //I started to use TryParse but got a little confused.  Didn't want to waste time right now solving
            //this issue because that isn't the lesson I'm trying to learn.
            //
            //bool isParsable;
            //do
            //{
            //    Console.WriteLine($"Please enter the number of tires you wish your vehicle to have:");
            //    var response = Console.ReadLine();

            //    isParsable = int.TryParse(response, out numberOfTires);
            //}
            //while (isParsable == false);


            switch (response.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return new Motorcycle();
                default:
                    return new Car();


            }
        }
    }
}
