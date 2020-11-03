using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingGameScore.Tests
{
    public class BowlingGameScore_CalculateScore
    {
        BowlingGame game = new BowlingGame();

        [Fact]
        public void CalculateScore_GutterGame_ScoreZero()
        {
            addListRound(0, 20);
            Assert.Equal(0, game.CalculateScore());
        }

        [Fact]
        public void CalculateScore_AllOnesGame_ScoreTwenty()
        {
            addListRound(1, 20);
            Assert.Equal(20, game.CalculateScore());
        }
        
        private void addListRound(int repeatThrow, int pins)
        {
            for (int i = 0; i < repeatThrow; i++)
            {
                game.ThrowBall(pins);
            }
        }

        
        // private void addRound(int firstThrow, int secondThrow)
        // {
        //     scoreBoard.Add(new int[] {firstThrow, secondThrow});
        // }

        // private void addLastRoundWithExtra(int firstThrow, int secondThrow, int thirdThrow)
        // {
        //     scoreBoard.Add(new int[] {firstThrow, secondThrow, thirdThrow});
        // }
    }
}
