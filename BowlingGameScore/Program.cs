using System;

namespace BowlingGameScore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BowlingGame game = new BowlingGame();

            Console.WriteLine("Insert number of throw ball:");
            int repeatDroppedPins = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeatDroppedPins; i++)
            {
                Console.WriteLine("Insert number of dropped pins:");
                int droppedPins = Convert.ToInt32(Console.ReadLine());
                game.ThrowBall(droppedPins);
            }
            int result = game.CalculateScore();
            Console.WriteLine(result);
        }            
    }
}
