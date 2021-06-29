using System;

namespace SnakeandLadderProgram
{
    /// <summary>
    /// UC1: Initializing Player and start position.
    /// UC2: Using Random to give dice values.
    /// UC3: To perform player move actions using switch case.
    /// UC4: Repeat the steps until player reaches 100 and not less than 0.
    /// UC5: Avoiding negative positioning
    /// UC6: Return each steps and no of Die Rolls.
    /// UC7: Included Player 2 and returned the player won.
    /// </summary>
    class Program
    {
        public const int START_POSITION = 0;
        public const int BOARD_SIZE = 100;
        public static int player = 0;
        public static int wining = 0;
        public static int player1Position = START_POSITION;
        public static int player2Position = START_POSITION;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Snake Ladder Program!");
            Program.PlayerOne();
            if (wining == 1)
            {
                Console.WriteLine("***************PLAYER 1 WINS***************");
            }
            else if (wining == 2)
            {
                Console.WriteLine("***************PLAYER 2 WINS***************");
            }
            else
            {
                Console.WriteLine("No one won");
            }
        }
        public static void PlayerOne()
        {
            
            while (player1Position != BOARD_SIZE && player == 0)
            {
                
                Program.RollDice();
                PlayerTwo();

            }


        }
        public static void PlayerTwo()
        {
            while (player2Position != BOARD_SIZE && player == 1)
            {
                
                Program.RollDice();
                PlayerOne();

            }

        }
        public static void Options(int diceValue)
        {
            int samplePosition = player1Position;
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case 1:
                    if (player == 0)
                    {
                        if (player1Position != 100)
                        {
                            Console.WriteLine("P1 No play :" + player1Position);
                            player = 1;
                        }
                        else
                        {

                            wining = 1;
                            return;

                        }
                    }
                    else
                    {
                        if (player2Position != 100)
                        {
                            Console.WriteLine("P2 No play :" + player2Position);
                            player = 0;
                        }
                        else
                        {

                            wining = 2;
                            return;

                        }
                    }
                    break;

                case 2:
                    if (player == 0)
                    {
                        if (player2Position == 100)
                        {
                            return;
                        }
                     
                        if (player1Position + diceValue <= BOARD_SIZE)
                         {
                            Console.WriteLine("P1 Ladder and current position is : " + (player1Position += diceValue));
                            if (player1Position != 100)
                            {
                                Console.WriteLine("P1 Roll again:");
                                player = 0;
                                PlayerOne();
                            }
                            else
                            {
                                wining = 1;
                                return;
                            }

                         }
                         else
                         {
                            player1Position = samplePosition;
                         }
                    }
                    else
                    {
                        if (player1Position == 100)
                        {
                            return;
                        }

                            if (player2Position + diceValue <= BOARD_SIZE)
                            {
                                Console.WriteLine("P2 Ladder and current position is : " + (player2Position += diceValue));
                                if (player2Position != 100)
                                {
                                    Console.WriteLine("P2 Roll again:");
                                    player = 1;
                                    PlayerTwo();

                                }
                                else
                                {
                                    wining = 2;
                                    return;
                                }

                            }
                            else
                            {
                                player2Position = samplePosition;
                            }



                        }
                    

                        break;
                    
                case 3:
                    if (player == 0)
                    {
                        if ((player1Position - diceValue) < 0)
                        {
                            player1Position = 0;
                            Console.WriteLine("P1 Snake Bite pushed down to: " + player1Position);
                            player = 1;
                           
                        }
                        else
                        {
                            Console.WriteLine("P1 Snake Bite pushed down to : " + (player1Position -= diceValue));
                            player = 1;
                        }
                    }
                    else
                    {

                        if ((player2Position - diceValue) < 0)
                        {
                            player2Position = 0;
                            Console.WriteLine("P2 Snake Bite pushed down to: " + player2Position);
                            player = 0;

                        }
                        else
                        {

                            Console.WriteLine("P2 Snake Bite pushed down to : " + (player2Position -= diceValue));
                            player = 0;
                        }

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
