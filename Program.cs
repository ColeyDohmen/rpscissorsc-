using System;

namespace rpscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            string[] choices = new string[3] { "rock", "paper", "scissors" };
            Random choice = new Random();



            bool running = true;
            while (running)
            {
                int index = choice.Next(choices.Length);
                string PcChoice = choices[index];
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
                        if (PcChoice == "rock")
                            System.Console.WriteLine($"You chose rock, PC chose {choices[index]}, you tie!");
                        else if (PcChoice == "paper")
                            System.Console.WriteLine($"You chose rock, PC chose {choices[index]}, you lose!");
                        else if (PcChoice == "scissors")
                            System.Console.WriteLine($"You chose rock, PC chose {choices[index]}, you win!");
                    }
                    else if (usersInput.Key == ConsoleKey.P)
                    {
                        if (PcChoice == "rock")
                            System.Console.WriteLine($"You chose paper, PC chose {choices[index]}, you win!");
                        else if (PcChoice == "paper")
                            System.Console.WriteLine($"You chose paper, PC chose {choices[index]}, you tie!");
                        else if (PcChoice == "scissors")
                            System.Console.WriteLine($"You chose paper, PC chose {choices[index]}, you lose!");
                    }
                    else if (usersInput.Key == ConsoleKey.S)
                    {
                        if (PcChoice == "rock")
                            System.Console.WriteLine($"You chose scissors, PC chose {choices[index]}, you lose!");
                        else if (PcChoice == "paper")
                            System.Console.WriteLine($"You chose scissors, PC chose {choices[index]}, you win!");
                        else if (PcChoice == "scissors")
                            System.Console.WriteLine($"You chose scissors, PC chose {choices[index]}, you tie!");
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
