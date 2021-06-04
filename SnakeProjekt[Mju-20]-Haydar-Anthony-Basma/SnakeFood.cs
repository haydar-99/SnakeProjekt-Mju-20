using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    
    class SnakeFood
    {
        public int FoodX { get; set; }
        public int FoodY { get; set; }
        public static Random Random = new Random();
        
        public SnakeFood()
        {
            FoodX = Random.Next(5, 48);
            FoodY = Random.Next(5, 48);
        }

        public  void DrawFood()
        {
          
                Console.SetCursorPosition(FoodX, FoodY);
                Console.WriteLine("¤");
           
        }
    }
}
