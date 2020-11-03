using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingGameScore.Tests
{
    public class BowlingGameScore_CalculateScore
    {
        BowlingGame game = new BowlingGame();

        [Fact]
        public void CalculateScore_GutterGame_Score0()
        {
            addListRound(0, 20);
            Assert.Equal(0, game.CalculateScore());
        }

        [Fact]
        public void CalculateScore_AllOnesGame_Score20()
        {
            addListRound(1, 20);
            Assert.Equal(20, game.CalculateScore());
        }

        [Fact]
        public void CalculateScore_SpareFollowedBy3_Score16()
        {
            addSpare();
            game.ThrowBall(3);
            Assert.Equal(16, game.CalculateScore());
        }

        [Fact]
        public void CalculateScore_StrikeFollowedBy7_Score24()
        {
            addStrike();
            game.ThrowBall(3);
            game.ThrowBall(4);
            addListRound(16, 0);
            Assert.Equal(24, game.CalculateScore());
        }

        private void addListRound(int repeatThrow, int pins)
        {
            for (int i = 0; i < repeatThrow; i++)
            {
                game.ThrowBall(pins);
            }
        }

        private void addSpare()
        {
                game.ThrowBall(5);
                game.ThrowBall(5);
        }

        private void addStrike()
        {
            game.ThrowBall(10);
        }
    }
}
