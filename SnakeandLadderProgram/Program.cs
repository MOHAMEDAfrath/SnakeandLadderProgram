using System;

namespace SnakeandLadderProgram
{
    /// <summary>
    /// UC1: Initializing Player and start position.
    /// UC2: Using Random to give dice values.
    /// UC3: To perform player move actions using switch case.
    /// </summary>
    class Program
    {
        public const int START_POSITION = 0;
        public const int BOARD_SIZE = 100;
        public static int player1Position = START_POSITION;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Snake Ladder Program!");
            Program.PlayerOne();
        }
        public static void PlayerOne()
        {
            Program.RollDice();
        }
        public static void Options(int diceValue)
        {
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("No play :" + player1Position);
                    break;

                case 2:
                   Console.WriteLine("Ladder and current position is : " + (player1Position += diceValue));
                   break;
                    
                case 3:
                   
                    player1Position = 0;
                    Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                    break;
                   
            }
        }
        public static void RollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Program.Options(dice);
        }

    }
}
