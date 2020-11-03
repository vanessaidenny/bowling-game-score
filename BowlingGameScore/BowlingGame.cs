using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameScore
{
    public class BowlingGame
    {
        private int score = 0;
        
        public void ThrowBall(int pins)
        {
            this.score += pins;
        }

        public int CalculateScore()
        {
            return score;
        }
    }
}