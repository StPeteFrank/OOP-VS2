using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_VS.Classes
{
    public interface IScoringMethod
    {
        void ScorePoints();
    }
    public class Baseballbat : IScoringMethod
    {
        public void ScorePoints()
        {
            Console.WriteLine("Swing baseball bat");
        }
    }

    public class ThreePointer : IScoringMethod
    {
        public void ScorePoints()
         {
             Console.WriteLine("Shot three-point shot.");
         }
    }
    public class FieldgoalKick : IScoringMethod
    {
        public void ScorePoints()
         {
            Console.WriteLine("Kick field goal.");
          }
    }

    }

