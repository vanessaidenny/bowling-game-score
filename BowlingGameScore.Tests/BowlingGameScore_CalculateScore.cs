using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingGameScore.Tests
{
    public class BowlingGameScore_CalculateScore
    {
        [Fact]
        public void CalculateScore_Input0_Return0()
        {
            BowlingGame game = new BowlingGame();
            List<int[]> scoreBoard = new List<int[]>();
            while(scoreBoard.Count<9)
            {
                scoreBoard.Add(new int[] {0, 0});              
            }
            scoreBoard.Add(new int[] {0, 0, 0});
            Assert.Equal(0, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input1_Return1()
        {
            BowlingGame game = new BowlingGame();
            List<int[]> scoreBoard = new List<int[]>();
            while(scoreBoard.Count<9)
            {
                scoreBoard.Add(new int[] {1, 1});              
            }
            scoreBoard.Add(new int[] {1, 1, 0});
            Assert.Equal(20, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input4P_6_Return19()
        {
            BowlingGame game = new BowlingGame();
            List<int[]> scoreBoard = new List<int[]>();
            scoreBoard.Add(new int[] {4, 6});
            scoreBoard.Add(new int[] {3, 0});
            while(scoreBoard.Count<9)
            {
                scoreBoard.Add(new int[] {0, 0});              
            }
            scoreBoard.Add(new int[] {0, 0, 0});
            Assert.Equal(19, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input10_4_6_Return31()
        {
            BowlingGame game = new BowlingGame();
            List<int[]> scoreBoard = new List<int[]>();
            scoreBoard.Add(new int[] {10, 0});
            scoreBoard.Add(new int[] {3, 4});
            while(scoreBoard.Count<9)
            {
                scoreBoard.Add(new int[] {0, 0});              
            }
            scoreBoard.Add(new int[] {0, 0, 0});
            Assert.Equal(31, game.CalculateScore(scoreBoard));
        }

        [Fact]
        public void CalculateScore_Input12Strike_Return300()
         {
            BowlingGame game = new BowlingGame();
            List<int[]> scoreBoard = new List<int[]>();
            while(scoreBoard.Count<9)
            {
                scoreBoard.Add(new int[] {10, 0});              
            }
            scoreBoard.Add(new int[] {10, 10, 10});
            Assert.Equal(300, game.CalculateScore(scoreBoard));
        }
    }
}
