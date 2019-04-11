using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public interface IDetermineValue
    {
        int Value { get; set; }
        void IncreaseValue(int increase);

        void DecreaseValue(int decrease);
    }

}
