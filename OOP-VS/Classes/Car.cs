using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Car : ICanGallop, IDetermineValue, IManageHP
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsImported { get; set; }
        public string OwnerName { get; set; }
        public int NumberOfShoes { get; set; }
        public int MaxSpeed { get; set; }
        public int Value { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"The {Make} {Model} is a {Year} and it is {IsImported} that it is imported and it is owned by {OwnerName}. " +
                $"Max speed of {MaxSpeed} mph. It has a value of ${Value}. It has {Horsepower}HP.";
        
        }

        public Car(string make, string model, int year, bool isImported, int maxSpeed, int value, int horsepower)
        {
            Make = make;
            Model = model;
            Year = year;
            IsImported = isImported;
            MaxSpeed = maxSpeed;
            Value = value;
            Horsepower = horsepower;
        }

        public String Driver(string owner)
        {
            OwnerName = owner;
            return OwnerName;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel;
        }

        public void DecreaseSpeed(int deccel)
        {
            this.MaxSpeed -= deccel;
        }

        public void IncreaseValue(int increase)
        {
            this.Value += increase;
        }

        public void DecreaseValue(int decrease)
        {
            this.Value -= decrease;
        }

        public void IncreaseHP(int increase)
        {
            this.Horsepower += increase;
        }

        public void DecreaseHP(int decrease)
        {
            this.Horsepower -= decrease;
        }
    }
}
