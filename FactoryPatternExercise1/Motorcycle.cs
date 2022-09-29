using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    internal class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Bulding a new Motorcycle");
        }
    }
}
