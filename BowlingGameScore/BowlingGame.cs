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
            int roundIndex = 0;
            for (int round = 0; round < Config.MAXROUND; round++)
            {
                if (rolls[roundIndex] + rolls[roundIndex+1] == 10) //spare
                {
                    score += 10 + rolls[roundIndex+2];
                    roundIndex += 2;
                } else {
                    score += rolls[roundIndex] + rolls[roundIndex+1];
                    roundIndex += 2;
                }
            }
            return score;
        }
    }
}