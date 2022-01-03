using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Game
{
    class Snake : Figure
    {
        Direction direction;
        Point tail;
        Point head;
        public int score;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
            this.tail = tail;
            score = 0;
        }

        internal void Move()
        {
            Point tail = pList[0];
            pList.Remove(tail);
            head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point p = new Point(pList[pList.Count-1]);
            p.Move(1,direction);
            return p;
        }
        public void HandleControl()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        direction = Direction.LEFT;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.RIGHT;
                        break;
                    case ConsoleKey.UpArrow:
                        direction = Direction.UP;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Direction.DOWN;
                        break;

                }
            }
        }

        public bool IsHit(Point targetPoint)
        {
            return head.IsHit(targetPoint);
        }
        
        

    }
}
