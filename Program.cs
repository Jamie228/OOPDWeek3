using System;
using System.Collections.Generic;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car("Ford", "Fiesta"));
            vehicles.Add(new Car("BMW", "X5"));
            vehicles.Add(new Motorbike("Yamaha", "R1"));

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle is a {vehicle.Make} {vehicle.Model}");
            }

            foreach (Vehicle vehicle in vehicles)
            {
                for (int i = 0; i < 3; i++)
                {
                    AccelerateAndGetSpeed(vehicle);
                }
            }
        }

        static void AccelerateAndGetSpeed(Vehicle vehicle)
        {
            vehicle.Accelerate();
            Console.WriteLine($"The {vehicle.Make} {vehicle.Model} is travelling at speed {vehicle.Speed}");
        }
    }
}
