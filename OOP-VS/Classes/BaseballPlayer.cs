using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class BaseballPlayer : ScoringAthlete
    {
        public BaseballPlayer() : base(new Baseballbat())
        {

        }
    }
}
