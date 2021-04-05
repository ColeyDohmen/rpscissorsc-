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
