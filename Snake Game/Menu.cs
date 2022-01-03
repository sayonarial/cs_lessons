using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Game
{
    class Menu
    {
       
        public void ShowScore(int score)
        {
            Console.SetCursorPosition(90, 12);

            Console.Write(score);
        }
        public void GameOver()
        {
            Console.SetCursorPosition(39, 12);
            Console.Write("Game Over");
        }
    }
}
