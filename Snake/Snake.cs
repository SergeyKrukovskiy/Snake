using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Directions direction;

        public Snake(Point tail, int lenght, Directions direction_)
        {
            direction = direction_;
            pList = new List<Point>();
            for (int i = 0; i< lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, direction);
            return (nextpoint);
        }
    }
}
