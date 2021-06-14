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


            while(true)
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

   


            Console.ReadKey();
           
            

        }
    }
}
