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
            GameGround.BuildGround();
            while (true)
            {
                snake.DrawSnake();
                snake.Input();
                snake.MoveSnake();

            }


            Console.ReadKey();
           
            

        }
    }
}
