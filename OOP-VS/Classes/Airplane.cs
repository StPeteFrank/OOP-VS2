using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class Airplane
    {
        public string Make { get; set; }   // Properties
        public string Model { get; set; }
        public int PassengerCapacity { get; set; }
        public int Range { get; set; }
        public bool IsGrounded { get; set; } = false;
        public string Owner { get; set; } = "Jet Blue";  // Default values set. These may be overidden using Method inputs as arguments.

        public override string ToString()   // Public overide needed to return in this case an interpolated string with placeholders for values.
        {
            return $"This plane is a {Make} {Model}. The plane belongs to: {Owner}. Grounded status: {IsGrounded}.";  
        }

        public Airplane(string make, string model)  // Constructor. This will allow me to create instances of Airplane.
        {
            Make = make;
            Model = model;
        }

        public Boolean GroundedPlane(bool grounded, string owner)  // Method. Boolean for program inputs to output whether or not plane is grounded.
        {
            Owner = owner;
            IsGrounded = grounded;
            return IsGrounded;
        }

    }
}
