using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int x;
        int y;
        char c;

        Random random = new Random();
        public FoodCreator(int x, int y, char c)
        {
            this.x = x;
            this.y = y;
            this.c = c;

        }

        public Point CreateFood()
        {
            int x = random.Next(2, this.x - 2);
            int y = random.Next(2, this.y - 2);
            return new Point(x, y, c);
        }
    }
}
