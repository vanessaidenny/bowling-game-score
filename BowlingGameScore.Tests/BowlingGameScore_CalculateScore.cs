using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingGameScore.Tests
{
    public class BowlingGameScore_CalculateScore
    {
        BowlingGame game = new BowlingGame();
        List<int[]> scoreBoard = new List<int[]>();

        [Fact]
        public void CalculateScore_Input0_Return0()
        {
            addListRound(0, 0, 9);
            addLastRoundWithExtra(0, 0, 0);
            Assert.Equal(0, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input1_Return1()
        {
            addListRound(1, 1, 9);
            addLastRoundWithExtra(1, 1, 0);
            Assert.Equal(20, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input4P_6_Return19()
        {
            addRound(4, 6);
            addRound(3, 0);
            addListRound(0, 0, 9);
            addLastRoundWithExtra(0, 0, 0);
            Assert.Equal(19, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input10_4_6_Return31()
        {
            addRound(10, 0);
            addRound(3, 4);
            addListRound(0, 0, 9);
            addLastRoundWithExtra(0, 0, 0);
            Assert.Equal(31, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input12Strike_Return300()
         {
            addListRound(10, 0, 9);
            addLastRoundWithExtra(10, 10, 10);
            Assert.Equal(300, game.CalculateScore(scoreBoard));
        }
        
        private void addRound(int firstThrow, int secondThrow)
        {
            scoreBoard.Add(new int[] {firstThrow, secondThrow});
        }

        private void addListRound(int firstThrow, int secondThrow, int stopAtRound)
        {
            while(scoreBoard.Count<stopAtRound)
            {
                addRound(firstThrow,secondThrow);             
            }
        }

        private void addLastRoundWithExtra(int firstThrow, int secondThrow, int thirdThrow)
        {
            scoreBoard.Add(new int[] {firstThrow, secondThrow, thirdThrow});
        }
    }
}
