using System;

namespace Karātavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.WriteLine(String.Join(" ", game.userInput));

            while (!game.IsOver())
            {
                Console.Write("Ievadi burtu: ");
                char input = Console.ReadLine()[0];

                if(game.Guess(input) == true)
                {
                    Console.WriteLine(String.Join(" ", game.userInput));
                }
                else
                {
                    Console.WriteLine("Burts nav šajā vārdā ");
                }
            }
            Console.WriteLine("Vārds ir veiksmīgi atminēts ");
            Console.ReadLine();
        }
    }
}
