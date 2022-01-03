using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Game
{
    class FoodSpawner
    {
        int mapWidth;
        int mapHeight;
        char sym;
        public Point foodPoint;

        Random random = new Random();

        public FoodSpawner(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point GetRandomPoint()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            foodPoint = new Point(x, y, sym);
            return foodPoint;
        }

        public void Spawn()
        {
            GetRandomPoint().Draw();
        }
    }
}
