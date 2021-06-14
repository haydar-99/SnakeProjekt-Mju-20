using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            GameGround gameGround = new GameGround();
            SnakeFood snakeFood = new SnakeFood();
            snakeObj snake = new snakeObj();


            mainMenu.ViewMainMenu();
            while (mainMenu.start == true)
            {
                GameGround.BuildGround();

                snake.Input();
                snakeFood.DrawFood();

                snake.DrawSnake();

                snake.MoveSnake();
                snake.SnakeGrow(snakeFood);

                if (snake.DeadSnake())
                {
                    break;
                }
                

            }


            Console.ReadKey();
           
            

        }
    }
}
