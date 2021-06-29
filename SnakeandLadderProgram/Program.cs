using System;

namespace SnakeandLadderProgram
{
    /// <summary>
    /// UC1: Initializing Player and start position.
    /// UC2: Using Random to give dice values.
    /// UC3: To perform player move actions using switch case.
    /// UC4: Repeat the steps until player reaches 100 and not less than 0.
    /// UC5: Avoiding negative positioning
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
            int diceRolledP1 = 0;
            while (player1Position != BOARD_SIZE)
            {
                diceRolledP1 += 1;
                Program.RollDice();

            }
            Console.WriteLine("No of Times the Dice rolled By P1: " + diceRolledP1);

        }
        public static void Options(int diceValue)
        {
            int samplePosition = player1Position;
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("No play :" + player1Position);
                    break;

                case 2:
                    if (player1Position + diceValue <= BOARD_SIZE)
                    {
                        Console.WriteLine("Ladder and current position is : " + (player1Position += diceValue));
                    }
                    else
                    {
                        player1Position = samplePosition;
                    }

                    break;
                    
                case 3:
                    if ((player1Position - diceValue) < 0)
                    {
                        player1Position = 0;
                        Console.WriteLine("Snake Bite pushed down to: " + player1Position);
                    }
                    else
                    {
                        Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                    }
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
