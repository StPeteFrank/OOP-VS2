using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Knight2 : Warrior2
    {
        public Knight2() : base(new Sword2()) // Dependancy injection of IWeapon
        {

        }
    }
}
