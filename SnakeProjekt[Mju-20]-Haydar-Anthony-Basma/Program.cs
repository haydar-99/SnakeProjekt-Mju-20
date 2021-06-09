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
            
            GameGround gameGround = new GameGround();
            SnakeFood snakeFood = new SnakeFood();
            snakeObj snake = new snakeObj();

            while (true)
            {
                GameGround.BuildGround();

                snake.Input();
                snake.DrawSnake();

                snake.MoveSnake();

            }


            Console.ReadKey();
           
            

        }
    }
}
