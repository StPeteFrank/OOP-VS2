using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Mule : Animal  // Mule is child class.
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfHorseShoes { get; set; }

        public Mule() // Constructor
        {
            this.Greeting = "Bazinga";  // Properties inherited from Animal.
            this.FavoriteFood = "Apples";
        }


        public int ShoeMyHorse()
        {
            this.CountOfHorseShoes = 4;
            return this.CountOfHorseShoes;
        }
    }
}
