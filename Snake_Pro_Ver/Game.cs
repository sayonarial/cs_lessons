using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Pro_Ver
{
    public class Game
    {

        // Game properties

        int sizeX, sizeY; //game window  size
        int Speed; //game speed
        int Arena; //selected arena


        //Stats
        int currentScore = 0;
        int bestScore = 0;
        int pressCounts = 0;

        //Menus
        Menu StartMenu = new Menu("Main Menu", true);
        Menu EndMenu = new Menu("Game Over", true);


        Collisions Collisions = new Collisions();
        Snake Snake;
        Food Food = new Food(foodChar:'O');
        Figure FreeSpace = new Figure(' '); //space for placing apples or figures

        string nothingWasPressed = "Дело не сдвинется с места, если ничего не предпринимать";

        enum  Status
        {
            GAMING,
            START_MENU,
            PAUSE,
            END
            
        } 
        Status GameStatus = Status.START_MENU;  //Game status start screen by default

        

        List<string> Arenas = new List<string>{ 
            "Classic",
            "Labyrinth",
            "Structures",
        };
        

        List<string> Speeds = new List<string>
        {
            "Slow",
            "Normal",
            "Fast"
        };
        

        public Game(int sizeX, int sizeY) //New game window
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;

            Arena = 0; //default arena 
            Speed = 1; //Normal speed
            //create a main menus
            StartMenu.AddItems(new List<MenuItem> {
                    new MenuItem("Start Game", () => StartGame()),
                    new MenuItem("Arena", () => ChangeArena()),
                    new MenuItem("Speed", () => ChangeSpeed()),
                    new MenuItem("Exit", () => Environment.Exit(0))
                    });
            EndMenu.AddItems(new List<MenuItem> {
                    new MenuItem("Start Again", () => StartGame()),
                    new MenuItem("To Main Menu", () => Environment.Exit(0)),
                    new MenuItem("Exit", () => Environment.Exit(0))
                    });


        }

        public void StartGame() //creates new arena from settings
        {
            Console.Clear(); //clear all from screen

            GameStatus = Status.GAMING; //set Game status to gaming
            currentScore = 0; //reset current score
            pressCounts = 0; //reset press counts

            switch (Arena)
	        {
                case 0: //classic frame with one snake
                    //make simple frame
                    Figure Frame = new Figure('▓');
                    Frame.CreateFrame(new Pixel(0,0),new Pixel(sizeX,sizeY));
                    Frame.CreateFrame(new Pixel(0, sizeY), new Pixel(sizeX, sizeY+2));
                    //add figures to collision list
                    Collisions.Add(Frame);
                    //Show all collisions
                    Collisions.Show();

                    //Create Available space for placing apples
                    FreeSpace.CreateBox(new Pixel(0,0),new Pixel(sizeX, sizeY));
                    //Exclude collisions and snake from free space
                    FreeSpace.Remove(Frame);

                    //add snake to game
                    Snake = new Snake(new Pixel(sizeX / 2, sizeY / 2),2,'+');
                    //exclude snake from available space
                    FreeSpace.Remove(Snake);

                    ////show free space
                    //Console.BackgroundColor = ConsoleColor.Green;
                    //FreeSpace.Draw();
                    //Console.BackgroundColor = ConsoleColor.Black;

                    //add first food in available space
                    Food.Spawn(FreeSpace);

                    break;
                case 1:
                    break;
                case 2:
                    break;

		        default:
                    Console.WriteLine("Undefined game mode!");
                    break;
	        }
        }
        public void GameLoop() //main loop for game
        {
            
            //If its first run show menu
            //If game is Paused show pause resume menu
            //if game Over show Game ower screen
            //if game is still going, show game frame

            switch (GameStatus)
            {
                case Status.GAMING:
                    //Show Game frame
                    RenderFrame();
                    break;
                case Status.END:
                    //Show Game Over screen
                    break;
                case Status.PAUSE:
                    //Show Pause Screen
                    break;
                case Status.START_MENU:
                    //Show start Menu
                    StartMenu.Show();
                    break;
            }

        }

        void RenderFrame() {
            switch (Arena)
            {

                default: //default game logic
                    //add snake to free space
                    FreeSpace.Add(Snake);
                    // move snake
                    Snake.Move();
                    // remove from free space
                    FreeSpace.Remove(Snake);

                    if (Snake.IsHit(Food) == true)
                    {

                        Snake.Add(new Pixel(Food.x,Food.y));
                        Food.Spawn(FreeSpace);
                        currentScore++;
                    }
                    else if (Snake.IsHitItself())
                    {
                        GameOver("И такое бывает...");
                    }
                    else if (Snake.IsHit(Collisions))
                    {
                        if (Snake.GetPressCounts() == 0) GameOver(nothingWasPressed);
                        GameOver("Стены лбом не прошибешь");
                    }
                    //else { Snake.Show(); }
                    Snake.Show();
                    
                    break;
            }
        }

        public void Pause() //pause screen
        {

        }
        
        static int GetBestScoreFromFile()
        {
            return 0;
        }

        void SaveStatsAndSettings()
        {
            //Save stats and settings to text file
            
            
        }



        void GameOver(string message) {

            //Stop();
            Console.WriteLine(message);
            string score = $"Your score: {currentScore}";
            Console.WriteLine($"{score}");
            Console.WriteLine("Press F to start new game. Q for Exit");


        }

        void ChangeArena()
        {
            Menu Arena = new Menu("Select Arena");
            Arena.AddItems(new List<MenuItem> {
                    new MenuItem("Classic", () => SetArena(0)),
                    new MenuItem("Labirynth", () => SetArena(1))
                    });
            do
            {
                Arena.Show();
            } while (Arena.EnterIsPressed == false);
        }
        void SetArena(int arenaIndex)
        {
            Arena = arenaIndex;
        }
        void ChangeSpeed()
        {
            if (Speed == Speeds.Count() - 1) Speed = 0;
            else Speed++;
        }
    }
}
