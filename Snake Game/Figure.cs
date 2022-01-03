using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Game
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        
        public bool IsHit(Figure targetFigure)
        {
            foreach (var p in pList)
            {
                if (targetFigure.IsHit(p))
                    return true;
            }
            return false;
        }
        public bool IsHit(Point targetPoint)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(targetPoint))
                    return true;
            }
            return false;
        }
    }
}
