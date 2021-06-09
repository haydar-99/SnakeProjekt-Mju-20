using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    class snakeObj:Snake_abstract
    {
        

        public snakeObj()
        {
            X = 20;
            Y = 5;
            SnakeCordinates = new List<Cordinate>();
            SnakeCordinates.Add(new Cordinate(X, Y));
        }
        public override void DrawSnake()
        {
            foreach (var  pos in SnakeCordinates)
            {
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.WriteLine("@");
            }

        }
        private void direction()
        {
            if (key == 'w' && dir != 'd')
            {
                dir = 'u';
            }
            else if (key == 's' && dir != 'u')
            {
                dir = 'd';
            }
            else if (key == 'd' && dir != 'l')
            {
                dir = 'r';
            }
            else if (key == 'a' && dir != 'r')
            {
                dir = 'l';
            }
        }
        public override void MoveSnake()
        {
            direction();
            if (dir == 'u')
            {
                Y--;
            }
            else if (dir == 'd')
            {
                Y++;
            }
            else if (dir == 'r')
            {
                X++;
            }
            else if (dir == 'l')
            {
                X--;
            }
            SnakeCordinates.Add(new Cordinate(X, Y));
            Thread.Sleep(300);
            SnakeCordinates.RemoveAt(0);

        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

    }
}
