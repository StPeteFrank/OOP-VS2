using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
   public interface IWeapon
    {
        void DoDamage();
    }

    public class Sword : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Swinging sword.");
        }
    }

    public class BowAndArrow : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shooting arrow.");
        }
    }

    public class MagicMissile : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shoots fireball.");
        }
    }

}
