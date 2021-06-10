using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    class GameGround
    {
        public static  int Width { get; set; }
        public static   int Height { get; set; }
        public GameGround()
        {
            Width = 50;
            Height = 20;
        }

        public static void BuildGround()
        {
            Console.Clear();
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, (Height + 1));
                Console.Write("-");
            }
            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }
            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition((Width + 1), i);
                Console.Write("|");
            }

            Console.SetCursorPosition(0, 0);
            Console.Write("+");
            Console.SetCursorPosition(Width + 1, 0);
            Console.Write("+");
            Console.SetCursorPosition(0, Height + 1);
            Console.Write("+");
            Console.SetCursorPosition(Width + 1, Height + 1);
            Console.Write("+");


        }

    }
}
