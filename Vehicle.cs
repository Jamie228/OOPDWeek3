using System;
using System.Collections.Generic;

namespace week3
{
    abstract class Vehicle
    {
        protected decimal acceleration;
        protected decimal speed;
        protected string make;
        protected string model;
        protected decimal angle;

        public decimal Speed
        {
            get 
            {
                return speed;
            }
        }

        public string Make
        {
            get
            {
                return make;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public Vehicle(string make, string model)
        {
            acceleration = 0m;
            speed = 0m;
            angle = 0m;
            this.make = make;
            this.model = model;
        }

        public void Accelerate()
        {
            if (acceleration <= 5m)
            {
            acceleration += 0.1m;
            Console.WriteLine("Accelerating");
            }
            Update();
        }

        public void Decelerate()
        {
            acceleration -= 0.1m;
            Console.WriteLine("Decelerating");
            Update();
        }

        public void Brake()
        {
            acceleration = 0;
            speed -= 1;
        }

        public void Turn(decimal turningAngle)
        {
            angle += turningAngle;
        }

        public void Update()
        {
            speed += acceleration;
        }
    }
}