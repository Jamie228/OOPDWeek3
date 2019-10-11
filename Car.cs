using System;
using System.Collections.Generic;

namespace week3
{
    class Car : Vehicle
    {
        int currentGear;
        public Car(string make, string model) : base(make, model)
        {
            currentGear = 0;
        }

        public void Reverse()
        {
            if (speed > 0)
            {
                Console.WriteLine($"Unable to reverse at speed {speed}");
            }
            else
            {
                speed -= acceleration;
                Console.WriteLine("Reversing");
            }
        }
    }
}