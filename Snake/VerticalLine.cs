using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine: Figure
    {
        public VerticalLine (int highy, int lowy, int x, char c)
        {
            pList = new List<Point>();
            for (int i = highy; i <= lowy; i++)
            {
                Point p = new Point(x, i, c);
                pList.Add(p);
            }
        }
    }
}
