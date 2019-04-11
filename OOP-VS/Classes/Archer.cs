using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Archer : Warrior
    {
        public Archer() : base(new BowAndArrow())
        {

        }
    }
}
