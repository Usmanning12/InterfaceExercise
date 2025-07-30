using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car();
            var Truck = new Truck();

            var vehicles = new List<IVehicle> { Car, Truck };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangedGears(true);
                vehicle.Reverse();

            } 
        }
    
        // Te
    }
    

}