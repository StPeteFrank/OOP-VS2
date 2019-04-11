using OOP_VS.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public abstract class ScoringAthlete : IScorer
    {
        public string SportPlayed { get; set; }
        public string PlayerName { get; set; }
        public int PointPerGame { get; set; }

        public IScoringMethod ScoringMethod { get; set; }

        public ScoringAthlete(IScoringMethod scoringMethod)
        {
            this.ScoringMethod = scoringMethod;
        }

        public void Score()
        {
            this.ScoringMethod.ScorePoints();
        }
    }


}
