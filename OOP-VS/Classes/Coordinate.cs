using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Coordinate
    {
        public decimal Latitude { get; set; }  //  Four Properties
        public decimal Longitude { get; set; }
        public string Label { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{Label} is located at {Latitude}, {Longitude} and is marked by {Color} pointer";
        }

    }
}
