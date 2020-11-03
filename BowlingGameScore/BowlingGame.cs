using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameScore
{
    public class BowlingGame
    {
        private int[] rolls {get;set;} = new int[21];
        private int currentRoll = 0;
        
        public void ThrowBall(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int CalculateScore()
        {
            int score = 0;
            for (int i = 0; i < rolls.Length; i++)
            {
                score += rolls[i];
            }
            return score;
        }
    }
}