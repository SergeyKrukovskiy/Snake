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
            Walls walls = new Walls(80, 25);
            walls.Draw();

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
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Write("Игра закончена!");
                    Console.ReadLine();
                    break;
                }
                
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
