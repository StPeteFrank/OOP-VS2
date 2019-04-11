using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public interface ICanFly  // An interface is a contract of actions.
    {
        int WingSpan { get; set; }
        int FlySpeed { get; set; }
        int CurrentFlyingSpeed { get; set; }

        void FlapWings(int accel);  // Methods
        void Glide(int deccel);

    }
}
