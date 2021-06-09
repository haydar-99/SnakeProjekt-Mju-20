using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    class snakeObj:Snake_abstract
    {
        

        public snakeObj()
        {
            
        }
        public override void DrawSnake()
        {
            foreach (KeyValuePair<int, int> pos in bodyList)
            {
                Console.SetCursorPosition(pos.Key, pos.Value);
                Console.WriteLine("@");
            }

        }
        public override void MoveSnake()
        {
            throw new NotImplementedException();
        }

    }
}
