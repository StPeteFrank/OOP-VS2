using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Bird : ICanFly 
    {
        public string Color { get; set; }
        public int WingSpan { get; set; }
        public int FlySpeed { get; set; }
        public int CurrentFlyingSpeed { get; set; }

        public override string ToString()
        {
            return $"This bird has a flyspeed of {CurrentFlyingSpeed} mph.";
        }

        public Bird(int currentFlySpeed)
        {
            CurrentFlyingSpeed = currentFlySpeed;
        }


        public void FlapWings(int accel)
        {
            this.CurrentFlyingSpeed += accel;
        }

        public void Glide(int deccel)
        {
            this.CurrentFlyingSpeed -= deccel;
        }
    }
}
