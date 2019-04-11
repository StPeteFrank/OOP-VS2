using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public abstract class Warrior : IAttacker // Base class set to abstract.
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Rank { get; set; }

        public IWeapon Weapon { get; set; }

        public Warrior(IWeapon weapon)  // Warrior class is dependant on this IWeapon.
        {
            this.Weapon = weapon;
        }

        public void Attack()
        {
            this.Weapon.DoDamage();
        }
    }


}
