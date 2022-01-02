using System;
using System.Threading;

namespace Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Walls Wall = new Walls(78, 24,'+');
            Wall.Draw();

            Snake snake = new Snake(new Point(10, 10, '*'), 5, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                snake.HandleControl();
                snake.Move();
                Thread.Sleep(150);

            }
            
        }
    }
}
