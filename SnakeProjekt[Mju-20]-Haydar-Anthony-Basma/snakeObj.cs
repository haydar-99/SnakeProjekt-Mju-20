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
        public void restart()
        {
            SnakeCordinates.Clear();
            X = 20;
            Y = 5;
            SnakeCordinates = new List<Cordinate>();
            SnakeCordinates.Add(new Cordinate(X, Y));
        }
        public override void DrawSnake()
        {
            try
            {
                foreach (var pos in SnakeCordinates)
                {
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.WriteLine("@");
                }
            }
            catch (Exception)
            {

                DeadSnake();
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
            Thread.Sleep(100);
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
        public void SnakeGrow(SnakeFood food)
        {
            if (SnakeCordinates[SnakeCordinates.Count-1].X==food.FoodX && SnakeCordinates[SnakeCordinates.Count - 1].Y == food.FoodY)
            {
                SnakeCordinates.Add(new Cordinate(X, Y));
                food.FoodNewPos();
            }
        }

        public bool DeadSnake()
        {
            bool dead =false;
            if (SnakeCordinates[SnakeCordinates.Count - 1].X == GameGround.Width + 2 || SnakeCordinates[SnakeCordinates.Count - 1].Y == GameGround.Height + 2)
            {
                ConsoleKeyInfo presschoice = new ConsoleKeyInfo();
                int choiceReboot;

                Console.SetCursorPosition(10, 10);
                Console.WriteLine(" The snake is dead LOSER ");
                Console.WriteLine("  ");
                Console.WriteLine("        Press 1 - Restart");
                Console.WriteLine("        Press 2 - Quit");
                Console.ReadKey();
                while (true)
                {
                    presschoice = Console.ReadKey(true);
                    if (presschoice.Key == ConsoleKey.D1)
                    {
                        choiceReboot = 1;
                        break;
                    }
                    else if (presschoice.Key == ConsoleKey.D2)
                    {
                        choiceReboot = 2;
                        break;
                    }
                }

                switch (choiceReboot)
                {
                    case 1:
                        restart();
                        break;


                    case 2:
                        Environment.Exit(0);
                        break;
                }

                
                dead = true;
            }
            else if (SnakeCordinates[SnakeCordinates.Count - 1].X == 0 || SnakeCordinates[SnakeCordinates.Count - 1].Y == 0)
            {
                ConsoleKeyInfo presschoice = new ConsoleKeyInfo();
                int choiceReboot;

                Console.SetCursorPosition(10, 10);
                Console.WriteLine(" The snake is dead LOSER ");
                Console.WriteLine("|  ");
                Console.WriteLine("|             Press 1 - Restart   ");
                Console.WriteLine("|             Press 2 - Quit      ");
                Console.ReadKey();
                while (true)
                {
                    presschoice = Console.ReadKey(true);
                    if (presschoice.Key == ConsoleKey.D1)
                    {
                        choiceReboot = 1;
                        break;
                    }
                    else if (presschoice.Key == ConsoleKey.D2)
                    {
                        choiceReboot = 2;
                        break;
                    }
                }

                switch (choiceReboot)
                {
                    case 1:
                        restart();
                        break;


                    case 2:
                        Environment.Exit(0);
                        break;
                }
                dead = true;
            }
            //else if(HeadCrash())
            //{
            //    Console.SetCursorPosition(10, 10);
            //    Console.WriteLine(" The snake is dead LOSER ");
            //    Thread.Sleep(4000);
            //    dead = true;
            //}
           
            return dead;

           

        }
        //public bool HeadCrash()
        //{
        //    bool headCrash=false;
        //    for (int i = 0; i < SnakeCordinates.Count; i++)
        //    {
        //        if (SnakeCordinates[SnakeCordinates.Count - 1].X==SnakeCordinates[i].X-2 || SnakeCordinates[SnakeCordinates.Count - 1].Y == SnakeCordinates[i].Y-2)
        //        {
        //            headCrash = true;
        //        }
        //    }
        //    return headCrash;
        //}

    }
}
