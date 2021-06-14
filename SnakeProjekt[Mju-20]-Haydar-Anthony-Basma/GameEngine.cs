using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    class GameEngine
    {
        public static MainMenu mainMenu = new MainMenu();
        public static GameGround gameGround = new GameGround();
        public static SnakeFood snakeFood = new SnakeFood();
        public static snakeObj snake = new snakeObj();

        public static void StartGame(MainMenu mainMenu, SnakeFood snakeFood, snakeObj snake)
        {
            while (true)
            {
                mainMenu.ViewMainMenu();
                if (mainMenu.start == true)
                {
                    while (true)
                    {
                        GameGround.BuildGround();

                        snake.Input();
                        snakeFood.DrawFood();

                        snake.DrawSnake();

                        snake.MoveSnake();
                        snake.SnakeGrow(snakeFood);
                        if (snake.DeadSnake())
                        {
                            mainMenu.start = false;
                            break;
                        }
                    }

                }



            }
        }
    }
}

