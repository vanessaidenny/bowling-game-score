using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameScore
{
    public class BowlingGame
    {        
        public int ThrowBall(int pins)
        {
            Console.WriteLine("Insert number of dropped pins:");
            int roll = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                if(roll<=pins && roll>=0) return roll;
                Console.WriteLine($"There are only {pins} pins left, how many to drop?:");
                roll = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PlayGame()
        {
            List<int[]> scoreBoard = new List<int[]>();
            // [{10, 0}, {4, 6} ... {10, 5, 5}]

            for (int i = 0; i < Config.MAXROUND; i++)
            {
                int pins = Config.MAXPIN;
                int firstThrow = ThrowBall(pins);
                pins-=firstThrow;
                if (i != 9)
                {
                    if (pins==0) // strike
                    {
                        scoreBoard.Add(new int[] {10, 0});
                    }
                    else
                    {
                        scoreBoard.Add(new int[] {firstThrow, 0});
                        int secondThrow = ThrowBall(pins);
                        pins-=secondThrow;
                        scoreBoard[i][1] = secondThrow;
                    }
                    Console.WriteLine($"End of round {i+1}");
                }
                else // last round
                {
                    if (pins==0) // strike!
                    {
                        scoreBoard.Add(new int[] {firstThrow, 0, 0});
                        pins=Config.MAXPIN;
                        int firstExtraThrow = ThrowBall(pins);
                        pins-=firstExtraThrow;
                        if (pins == 0){ // extra throw strike
                            pins = Config.MAXPIN;                            
                        }
                        scoreBoard[i][1] = firstExtraThrow;
                        int secondExtraThrow = ThrowBall(pins);
                        pins -= secondExtraThrow;
                        scoreBoard[i][2] = secondExtraThrow;                    
                    }
                    else{
                        scoreBoard.Add(new int[] {firstThrow, 0, 0});
                        int secondThrow = ThrowBall(pins);
                        pins-=secondThrow;
                        scoreBoard[i][1] = secondThrow;
                        if (pins == 0){ // spare!
                            pins = Config.MAXPIN;
                            int extraThrow = ThrowBall(pins);
                            scoreBoard[i][2] = extraThrow;
                        }
                    }
                }
            }
            Console.WriteLine(CalculateScore(scoreBoard));
        }

        public int CalculateScore(List<int[]> scoreBoard)
        {
            int finalScore = 0;
            for (int i = 0; i < Config.MAXROUND; i++)
            {
                bool isStrike = scoreBoard[i][0]==10;
                int roundResult = 0;
                if(i==9)
                {
                    roundResult = scoreBoard[i].Sum();
                    finalScore += roundResult;
                    Console.WriteLine($"Result of round {i+1}: [{scoreBoard[i][0]}, {scoreBoard[i][1]}, {scoreBoard[i][2]}] = {roundResult}");
                }
                else if (i==8)
                {
                    bool isSpare = scoreBoard[i].Sum() == 10;
                    if(isStrike || isSpare){
                        if(scoreBoard[i+1][0] == 10){ // checks if last round was a strike
                            roundResult = scoreBoard[i+1][0]*2+10;
                            finalScore += roundResult;
                        }
                    }
                    else{
                        roundResult = scoreBoard[i].Sum();
                        finalScore += roundResult;
                    }
                    Console.WriteLine($"Result of round {i+1}: [{scoreBoard[i][0]}, {scoreBoard[i][1]}] = {roundResult}");
                }
                else
                {
                    if(isStrike)
                    {
                        roundResult = scoreBoard[i+1].Sum()*2+10;
                        finalScore += roundResult;
                    }
                    else
                    {
                        bool isSpare = scoreBoard[i].Sum()==10;
                        if(isSpare)
                        {
                            roundResult = scoreBoard[i+1][0]*2+10;
                            finalScore += roundResult;
                        }
                        else
                        {
                            roundResult = scoreBoard[i].Sum();
                            finalScore += roundResult;
                        } 
                    }
                    Console.WriteLine($"Result of round {i+1}: [{scoreBoard[i][0]}, {scoreBoard[i][1]}] = {roundResult}");
                }
            }
            return finalScore;
        }
    }
}