using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public class FootballPlayer : ScoringAthlete
    {
        public FootballPlayer() : base(new FieldgoalKick())
        {

        }
    }
}
