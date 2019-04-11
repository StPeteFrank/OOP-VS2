using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Pants   //Class
    {
        public string Brand { get; set; }  //Properties
        public string Color { get; set; }
        public int WaistSize { get; set; }
        public int Length { get; set; }
        public bool AreNew { get; set; }

        public string OwnerName { get; set; }

        public Pants(string brand, string color, int waistSize, int length)  //Constructor for newing up instances
        {
            Brand = brand;
            Color = color;
            WaistSize = waistSize;
            Length = length;
        }

        public override string ToString()
        {
            return $"These are {OwnerName}'s {this.Color} {this.Brand} slacks. They they are {this.WaistSize} by {this.Length}. It is {this.AreNew} that they are worn.";
        }
        public Boolean Worn(string owner)
        {
            AreNew = true;
            OwnerName = owner;
            return AreNew;
        }

    }
}
