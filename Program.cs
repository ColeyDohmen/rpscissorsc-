using System;

namespace rpscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            bool running = true;
            while (running)
            {
                System.Console.WriteLine(@"Would you like to play rock, paper, scissors?
                Y / N");
                ConsoleKeyInfo userInput = System.Console.ReadKey();
                Console.Clear();
                if (userInput.Key == ConsoleKey.Y)
                {
                    System.Console.WriteLine("YAY! Let's play!");
                    System.Console.WriteLine(@"Do you choose 
                    (R)ock
                    (P)aper
                    or
                    (S)cissors?");
                    ConsoleKeyInfo usersInput = System.Console.ReadKey();
                    Console.Clear();
                    if (usersInput.Key == ConsoleKey.R)
                    {
                        System.Console.WriteLine("You chose Rock, PC chose Rock, you tie!");
                    }
                    else if (usersInput.Key == ConsoleKey.P)
                    {
                        System.Console.WriteLine("You chose Paper, PC chose Rock, you win!");
                    }
                    else if (usersInput.Key == ConsoleKey.S)
                    {
                        System.Console.WriteLine("You chose Scissors, PC chose Rock, you lose!");
                    }
                    else
                    {
                        System.Console.WriteLine("invalid input");
                    }
                }
                else if (userInput.Key == ConsoleKey.N)
                {
                    System.Console.WriteLine("Sad days, maybe next time");
                    running = false;
                }
            }
        }
    }
}
