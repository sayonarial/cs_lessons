using System;
using System.Threading;

namespace Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            Walls Wall = new Walls(78, 24,'+');
            Wall.Draw();

            Snake snake = new Snake(new Point(10, 10, '*'), 5, Direction.RIGHT);
            snake.Draw();

            FoodSpawner food = new FoodSpawner(78, 24,'&');
            food.Spawn();

            while (true)
            {

                snake.HandleControl();
                snake.Move();

                //if (Wall.IsHit(snake) || snake.IsHit(snake))
                //{
                //    menu.GameOver();
                //    Console.ReadLine();
                //    break;
                //}
                if (snake.IsHit(food.foodPoint))
                {
                    snake.score++;
                    menu.ShowScore(snake.score);
                    food.Spawn();

                }



                Thread.Sleep(150);

            }
            
        }
    }
}
