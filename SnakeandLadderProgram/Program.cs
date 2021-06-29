using System;

namespace SnakeandLadderProgram
{
    /// <summary>
    /// UC1: Initializing Player and start position.
    /// UC2: Using Random to give dice values.
    /// </summary>
    class Program
    {
        public const int START_POSITION = 0;
        public const int BOARD_SIZE = 100;
        static void Main(string[] args)
        {
            int player1Position = START_POSITION;
            Console.WriteLine("Welcome to Snake Ladder Program!");
            Program.PlayerOne();
        }
        public static void PlayerOne()
        {
            Console.WriteLine(Program.RollDice());
        }
        public static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

    }
}
