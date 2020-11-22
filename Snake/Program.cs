using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point d = new Point(1, 3, '*');
            d.Draw();

            Point d2 = new Point(5, 2, '#');
            d2.Draw();

            Console.ReadLine();
        }
    }
}
