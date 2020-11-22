using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> vertline;

        public VerticalLine (int x, int highy, int lowy, char c)
        {
            vertline = new List<Point>();
            for (int i = highy; i >= lowy; i--)
            {
                Point p = new Point(x, i, c);
                vertline.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in vertline)
            {
                p.Draw();
            }
        }
    }
}
