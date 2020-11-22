using System;
using System.Collections.Generic;

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

            List<int> numlis = new List<int>();
            numlis.Add(2);
            numlis.Add(3);

            List<char> charlis = new List<char>();
            charlis.Add('!');
            charlis.Add('@');

            foreach (char i in charlis)
            {
                Console.WriteLine(i);
            }

            List<Point> pointlist = new List<Point>();
            pointlist.Add(d);
            pointlist.Add(d2);

            Console.ReadLine();
        }
    }
}
