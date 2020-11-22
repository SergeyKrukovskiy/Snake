using System;

namespace Snake
{
    class Program
    {
        static void Draw (int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char c = '*';
            Draw(x1, y1, c);

            int x2 = 5;
            int y2 = 2;
            char c2 = '#';
            Draw(x2, y2, c2);

            Console.ReadLine();
        }
    }
}
