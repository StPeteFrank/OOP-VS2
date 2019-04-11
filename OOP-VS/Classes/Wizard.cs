using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Wizard : Warrior
    {
        public Wizard() : base(new MagicMissile())
        {

        }
    }
}
