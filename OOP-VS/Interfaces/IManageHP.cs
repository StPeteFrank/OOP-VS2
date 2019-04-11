using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public interface IManageHP
    {
        int Horsepower { get; set; }
        void IncreaseHP(int increase);
        void DecreaseHP(int decrease);
    }
}
