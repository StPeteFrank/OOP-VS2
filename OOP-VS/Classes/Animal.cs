using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public abstract class Animal  // Base class. It is a parent class to Mule. It is also locked down as abstract class now. It can only be used for inheritance.
    {
        public string Greeting { get; set; }
        public string Name { get; set; }
        public string FavoriteFood { get; set; }

       /* public override string ToString()
        {
            return $"This animal's name is {this.Name}, it's favorite food is {this.FavoriteFood}, and it says {this.Greeting}.";
        }*/

       /* public Animal(string name, string greeting, string favoriteFood)
        {
            Name = name;
            Greeting = greeting;
            FavoriteFood = favoriteFood;
        }*/

        public void Speak()
        {
            Console.WriteLine(this.Greeting);
        }
        public void Eat()
        {
            Console.WriteLine($"My Favorite food is {FavoriteFood}.");
        }

    }
}
