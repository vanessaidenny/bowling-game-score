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
            int i = 0;
            for (int round = 0; round < Config.MAXROUND; round++)
            {
                score += rolls[i] + rolls[i+1];
                i += 2;
            }
            return score;
        }
    }
}