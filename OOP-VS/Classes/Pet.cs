using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
   public class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int Age { get; set; } = 0;
        public string OwnerName { get; set; }
        public bool IsAdopted { get; set; } = false;  // Setting default values

        public override string ToString()
        {
            return $"{OwnerName} has adopted {Name}";
        }

        // Constructor
        public Pet(string name, string breed) // Passing parameters
        {
            Name = name;
            Breed = breed;
        }

        // Methods
        public Boolean Adopt(string owner)
        {
            IsAdopted = true;
            OwnerName = owner;
            return IsAdopted;
        }

    }
}
