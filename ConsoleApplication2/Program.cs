using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Renderer rend = new Renderer(8, 8);
            Player person = new Player();

            person.Draw(rend.X, rend.Y);
        }
    }

    class Renderer
    {
        private int _x;
        // private int _y; //----because: public int Y { get; private set; }

        public int X
        {
            get { return _x; }
            private set
            {
                if (X > 0 && X < 10) _x = value;
            }
        }

        public int Y { get; private set; }

        public Renderer(int x, int y)
        {
            _x = x;
            Y = y;
        }
    }

    class Player
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);
            Console.ReadKey(true);
        }
    }
}