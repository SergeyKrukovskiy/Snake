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

            List<int> numlist = new List<int>();
            numlist[0] = 1;

            
            Console.ReadLine();
        }
    }
}
