using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Game
{
    class Walls
    {
        List<Figure> wallist;
        public Walls(int width, int height, char sym)
        {
            wallist = new List<Figure>();
            // Frame
            HorizontalLine upFrame = new HorizontalLine(0, width, 0, sym);
            HorizontalLine bottomFrame = new HorizontalLine(0, width, height, sym);
            VerticalLine leftFrame = new VerticalLine(0, 0, width, sym);
            VerticalLine rightFrame = new VerticalLine(width, 0, height, sym);

            wallist.Add(upFrame);
            wallist.Add(bottomFrame);
            wallist.Add(leftFrame);
            wallist.Add(rightFrame);

        }
        public void Draw()
        {
            foreach (var wall in wallist)
            {
                wall.Draw();
            }
        }
    }
}
