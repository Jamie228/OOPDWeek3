using System;
using System.Collections.Generic;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Ford", "Fiesta"));
            cars.Add(new Car("BMW", "X5"));

            List<Motorbike> motorbikes = new List<Motorbike>();

            motorbikes.Add(new Motorbike("Yamaha", "R1"));

            foreach (Car car in cars)
            {
                Console.WriteLine($"Car is a {car.Make} {car.Model}");
            }

            foreach (Car car in cars)
            {
                for (int i = 0; i < 3; i++)
                {
                    AccelerateAndGetSpeed(car);
                }
            }

            motorbikes[0].Accelerate();
            motorbikes[0].Update();
            motorbikes[0].Accelerate();
            motorbikes[0].Update();
            motorbikes[0].PullAWheelie();
        }

        static void AccelerateAndGetSpeed(Car car)
        {
            car.Accelerate();
            Console.WriteLine($"The {car.Make} {car.Model} is travelling at speed {car.Speed}");
        }
    }
}
