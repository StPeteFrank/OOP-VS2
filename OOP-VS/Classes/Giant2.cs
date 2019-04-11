using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Giant2 : Warrior2  // Must inherit Warrior2 parent class(abstract) which inherits the IAttacker2 interface.
    {
        public Giant2() : base(new Boulder2())  // Dependency injection of Boulder2 class which inehrits IWeapon2 interface.
        {

        }
    }
}
