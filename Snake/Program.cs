using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            // Point d = new Point(1, 3, '*');
            //d.Draw();

            //Point d2 = new Point(5, 2, '#');
            //d2.Draw();

            int x = 1;
            int y = 3;

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.s = '*';

            Point p2 = new Point(2, 4, '#');

            p1 = p2;
            p2.x = 9;
            p2.y = 7;
            p1.x = 3;
            p1.y = 2;

            static void Func1 (int Value)
            {
                Value += 1;
            }
            Func1(x);

            Point p3 = new Point(2, 1, '%');
            Move(p3, 10, 10);
            
            static void Move (Point p3, int dx, int dy)
            {
                p3.x += dx;
                p3.y += dy;
            }

            Point p4 = new Point(1, 5, '^');
            Reset(p4);

            static void Reset (Point p)
            {
                p = new Point();
            }

            Console.ReadLine();
        }
    }
}
