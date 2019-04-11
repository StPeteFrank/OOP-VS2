using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public interface IWeapon2
    {
        void DoDamage();
    }
    public class Sword2 : IWeapon2
    {
        public void DoDamage()
        {
            Console.WriteLine("Swinging sword2.");
        }
    }
    public class BowAndArrow2 : IWeapon2
    {
        public void DoDamage()
        {
            Console.WriteLine("Shoots arrow2.");
        }
    }
    public class MagicMissile2 : IWeapon2
    {
        public void DoDamage()
        {
            Console.WriteLine("Fires missle2.");
        }
    }
    public class Boulder2 : IWeapon2   // Implement the interface.
    {
        public void DoDamage()
        {
            Console.WriteLine("Launches boulder2 at your army.");
        }
    }
    public class Lance2 : IWeapon2
    {
        public void DoDamage()
        {
            Console.WriteLine("Thrusts lance2 at enemy.");
        }
    }

}
