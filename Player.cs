using System;
using System.Collections.Generic;

namespace Dart_Simulator
{
    class Player
    {
        private string name;
        private int skill;
        //Determines the range at which the "Player" can hit the target, if skill is 10, it will be very unlikelly that the player misses
        private int length;
        // the lenght will make the reach of the player longer or shorter increasing the accuracy by a little bit
        private List<Turn> turns = new List<Turn>();
        private Random r = new Random();

        public Player(string _name, int _skill, int _length)
        {
            name = _name;
            skill = _skill;
            length = _length;
        }

        private int GetScore()
        {
            double x;
            double y;
            x = r.NextDouble();
            y = r.NextDouble();
            double xy = Math.Pow(x, 2) + Math.Pow(y, 2);
            double score = Math.Sqrt(xy) * 10;
            return (int)score;
        }

        public void AddTurn()
        {
            foreach(var turn in turns)
            {
                GetScore();
            }
        }
        public void PrintTurns()
        {
            
        }

        public override string ToString()
        {
            return string.Format($"Name: {name}, Skill: {skill}, Height: {length}");
        }
    }
}