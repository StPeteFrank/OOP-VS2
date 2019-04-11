using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public interface ICanGallop
    {
        int NumberOfShoes { get; set; }
        int MaxSpeed { get; set; }

        void IncreaseSpeed(int accel);
        void DecreaseSpeed(int deccel);

       // void IncreaseSpeed { get; set; }
       // void DecreaseSpeed { get; set; }
    }
}
