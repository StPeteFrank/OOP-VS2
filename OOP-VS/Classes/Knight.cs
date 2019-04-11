using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Knight : Warrior
    {
        public Knight() : base(new Sword())  // Injected dependancy of IWeapon.
        {

        }
    }
}
