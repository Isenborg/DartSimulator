using System;

namespace Dart_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.PlayGame();

            Console.WriteLine("Thanks for playing the game \nPress any button to continue...");
        }
    }
}
