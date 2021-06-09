using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    abstract class Snake_abstract
    {
        public ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        public char key = 'w';
        public char dir = 'u';
        public List<Cordinate> SnakeCordinates;
        public int X { get; set; }
        public int Y{ get; set; }
        public Snake_abstract()
        {
           
           
        }

        public abstract void DrawSnake();
        public abstract void MoveSnake();


    }
}
