using System;

namespace BowlingGameScore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BowlingGame game = new BowlingGame();
            do
            {
                Console.WriteLine("Insert number of dropped pins:");
                int droppedPins = Convert.ToInt32(Console.ReadLine());
                game.ThrowBall(droppedPins);
            }
            while (game.currentRoll<21);
            int result = game.CalculateScore();
            Console.WriteLine(result);
        }            
    }
}
