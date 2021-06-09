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
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine(".");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
            }
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.WriteLine(".");

            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.WriteLine("|");
            }
            
        }

    }
}
