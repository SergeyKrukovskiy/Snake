using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point d = new Point();
            d.x = 1;
            d.y = 3;
            d.s = '*';
            d.Draw();

            Point d2 = new Point();
            d2.x = 5;
            d2.y = 2;
            d2.s = '#';
            d2.Draw();
            Console.ReadLine();
        }
    }
}
