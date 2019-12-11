using System;
using System.Collections.Generic;


namespace Dart_Simulator
{
    class Game
    {
        private List<Player> players = new List<Player>();
        private Random r = new Random();

        public void PlayGame()
        {
            Console.WriteLine("Welcome to the Dart Simulator." +
                "\nIn this game, your goal will be to reach 301 points by throwing dart.");
            ConsoleKeyInfo key;
            Console.Clear();
            do
            {
                if (players.Count > 0)
                {
                    foreach(var info in players)
                    {
                        Console.WriteLine(info.ToString());
                    }
                }

                Console.WriteLine("[1]Add Character");
                key = Console.ReadKey(true);
                switch(key.KeyChar)
                {
                    case '1':
                        Console.Write("Choose a name: ");
                        string name = Console.ReadLine();
                        AddPlayer(name);
                        break;
                }
            } while (true);
        }

        public void AddPlayer(string name)
        {
            players.Add(new Player(name, r.Next(1, 10), r.Next(100, 200)));
        }
    }
}