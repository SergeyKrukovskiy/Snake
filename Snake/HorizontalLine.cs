using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xleft, int xright, int y, char c)
        {
            pList = new List<Point>();
            
            for (int i = xleft; i<= xright; i++)
            {
                Point p1 = new Point(i, y, c);
                pList.Add(p1);
            }

        }

        public void Draw ()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
