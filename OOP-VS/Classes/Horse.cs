using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Horse : ICanGallop, ICanFly
    {
        public int NumberOfShoes { get; set; }
        public string ManeColor { get; set; }
        public string Breed { get; set; }
        public int MaxSpeed { get; set; }
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlyingSpeed { get ; set ; }

        public override string ToString()
        {
            return $"This horse has max speed of {MaxSpeed} mph. It can also fly at a speed of {CurrentFlyingSpeed} mph.";
        }

        public Horse(int maxSpeed, int currentFlySpeed)
        {
            MaxSpeed = maxSpeed;
            CurrentFlyingSpeed = currentFlySpeed;
        }

        public void DecreaseSpeed(int deccel)
        {
           this.MaxSpeed -= deccel;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel;
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
