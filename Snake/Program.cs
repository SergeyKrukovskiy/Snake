using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Drow();
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Drow();

            Point d = new Point(1, 3, '*');
            d.Draw();

            Console.ReadLine();
        }
    }
}
