using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Wizard2 : Warrior2
    {
        public Wizard2() : base(new MagicMissile2())
        {

        }
    }
}
