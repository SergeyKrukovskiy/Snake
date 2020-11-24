using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallist;
        public Walls (int length, int width)
        {
            wallist = new List<Figure>();

            HorizontalLine upline = new HorizontalLine(0, length-2, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, length - 2, width-1, '+');
            VerticalLine leftline = new VerticalLine(0, width - 1, 0, '+');
            VerticalLine rightline = new VerticalLine(0, width - 1, length-2, '+');

            wallist.Add(upline);
            wallist.Add(downline);
            wallist.Add(leftline);
            wallist.Add(rightline);
        }

        internal bool IsHit ( Figure figure )
        {
            foreach (var wall in wallist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallist)
            {
                wall.Drow();
            }
        }
    }
}
