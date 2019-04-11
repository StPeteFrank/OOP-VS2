using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class BackPack
    {
        public string Owner { get; set; }  // Properties
        public string Color { get; set; }
        public int NumberOfItems { get; set; } = 0;
        public int MaxNumberOfItems { get; set; }

        public override string ToString()
        {
            return $"This {this.Color} backpack belongs to {this.Owner} and it has {this.NumberOfItems}/{this.MaxNumberOfItems} items.";
        }

        public BackPack(string owner, string color, int maxItems) //Constructor
        {
            Owner = owner;
            Color = color;
            MaxNumberOfItems = maxItems;
        }

        public int AddItem()   // Methods
        {
            if (NumberOfItems < MaxNumberOfItems) // Condition
            {
                NumberOfItems++;  // This will increment number of item by one.
                return NumberOfItems;
            }
            else
            {
                return NumberOfItems; // Return
            }
        }

        public int RemoveItem()
        {
            if (NumberOfItems > 0)
            {
                NumberOfItems--;
            }
            return NumberOfItems;
        }

    }
}
