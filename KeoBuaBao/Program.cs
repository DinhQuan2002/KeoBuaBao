using System;

namespace KeoBuaBao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool PlayAgain = true;
            string Player;
            string Computer;
            string answer;

            while (PlayAgain)
            {
                Player = "";
                Computer = "";
                answer = "";

                while (Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS") {
                    Console.Write("Enter ROCK, PAPER or SCISSORS ");
                    Player = Console.ReadLine();
                    Player = Player.ToUpper();
                }

                switch (random.Next(1,4))
                {
                    case 1:
                        Computer = "ROCK";
                        break;
                    case 2:
                        Computer = "PAPER";
                        break;
                    case 3:
                        Computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player "+Player);
                Console.WriteLine("Computer "+Computer);

                switch (Computer)
                {
                    case "ROCK":
                        if(Player == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (Player == "PAPER")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "PAPER":
                        if (Player == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (Player == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;
                    case "SCISSORS":
                        if (Player == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else if (Player == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (Y/N) ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                    
                }
            }
            Console.WriteLine("Thanks to playing!");


            Console.ReadKey();
        }
    }
}
