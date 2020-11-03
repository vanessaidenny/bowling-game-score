using System;

namespace BowlingGameScore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BowlingGame game = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                game.ThrowBall(10);
            }
            int result = game.CalculateScore();
            Console.WriteLine(result);
        }            
    }
}
