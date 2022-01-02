using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Game
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
        
    }
}
