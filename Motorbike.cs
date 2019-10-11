using System;
using System.Collections.Generic;

namespace week3
{
    class Motorbike : Vehicle
    {
        int currentGear;

        public Motorbike(string make, string model) : base(make, model)
        {
            currentGear = 0;
        }

        public void PullAWheelie()
        {
            if(speed >= 0.3m)
            {
                Console.WriteLine("Pulling a wheelie");
            }
            else
            {
                Console.WriteLine($"Can't pull a wheelie when motorbike is travelling at {speed}");
            }
        }    
    }
}