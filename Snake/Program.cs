using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание границ окна
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            
            // границы карты
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Drow();
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Drow();

            //создание еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            //создание змейки
            Point d2 = new Point(6, 9, '*');
            Snake snake = new Snake(d2, 3, Directions.RIGHT);
            snake.Drow();

            //управляемое движение змейки 
            while (true)
            {
                if (snake.Eat(food) )
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
