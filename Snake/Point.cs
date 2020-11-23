using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char s;
        public Point ()
        {

        }
        public Point (int _x, int _y, char _s)
        {
            x = _x;
            y = _y;
            s = _s;
        }
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            s = p.s;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public void Move (int offset, Directions direction)
        {
            if (direction == Directions.RIGHT)
            {
                x += offset;
            }
            else if(direction == Directions.LEFT)
            {
                x -= offset;
            }
            else if (direction == Directions.UP)
            {
                y -= offset;
            }
            else if (direction == Directions.DOWN)
            {
                y += offset;
            }
        }
        internal void clear()
        {
            s = ' ';
            Draw();
        }
    }
}
