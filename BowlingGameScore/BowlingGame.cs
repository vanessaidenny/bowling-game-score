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
                if(isStrike(roundIndex))
                {
                    score += 10 + strikeBonus(roundIndex);
                    roundIndex++;
                }
                else if (isSpare(roundIndex))
                {
                    score += 10 + spareBonus(roundIndex);
                    roundIndex += 2;
                }
                else
                {
                    score += sumBallsInRound(roundIndex);
                    roundIndex += 2;
                }
            }
            return score;
        }

        private bool isStrike(int roundIndex)
        {
            return rolls[roundIndex] == 10;
        }

        private bool isSpare(int roundIndex)
        {
            return rolls[roundIndex] + rolls[roundIndex+1] == 10;
        }

        private int strikeBonus(int roundIndex)
        {
            return rolls[roundIndex+1] + rolls[roundIndex+2];
        }

        private int spareBonus(int roundIndex)
        {
            return rolls[roundIndex+2];
        }

        private int sumBallsInRound(int roundIndex)
        {
            return rolls[roundIndex] + rolls[roundIndex+1];
        }
    }
}