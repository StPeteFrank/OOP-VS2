using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public abstract class Warrior2 : IAttacker2 // Parent abstract class.
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Rank { get; set; }

        public IWeapon2 Weapon { get; set; }

        public Warrior2(IWeapon2 weapon)
        {
            this.Weapon = weapon;
        }

        public void Attack()
        {
            this.Weapon.DoDamage();
        }

    }
}
