using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Pegasus : ICanGallop, ICanFly //Inheritance of Interfaces
    {
        public int WingSpan { get; set; }
        public int FlySpeed { get; set; }
        public int CurrentFlyingSpeed { get; set; }
        public int NumberOfShoes { get; set; }
        public int MaxSpeed { get; set; }

        public override string ToString()
        {
            return $"The Pegasus has a run speed of {this.MaxSpeed} mph. It is faster than horse1 and can fly at {this.CurrentFlyingSpeed} mph.";
        }
        public Pegasus(int maxSpeed, int currentFlySpeed) // Constructor
        {
            MaxSpeed = maxSpeed;
            CurrentFlyingSpeed = currentFlySpeed;
        }

        public void DecreaseSpeed(int deccel) // Methods being inherited from ICanGallop interface.
        {
            this.MaxSpeed -= deccel;
        }

        public void FlapWings(int accel)   // Methods being inherited form ICanFly interface.
        {
            this.CurrentFlyingSpeed += accel;   
        }

        public void Glide(int deccel)
        {
            this.CurrentFlyingSpeed -= deccel;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel;
        }
    }
}
