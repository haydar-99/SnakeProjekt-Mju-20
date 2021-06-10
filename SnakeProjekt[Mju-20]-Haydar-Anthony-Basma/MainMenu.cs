﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt_Mju_20__Haydar_Anthony_Basma
{
    public class MainMenu
    {
        public ConsoleKeyInfo press = new ConsoleKeyInfo();
        public Random rand = new Random();
        public bool start = false;

        public void ViewMainMenu()
        {
            int choiceNum;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                              ");
            Console.WriteLine("     ▄████████ ███▄▄▄▄      ▄████████    ▄█   ▄█▄    ▄████████");
            Console.WriteLine("    ███    ███ ███▀▀▀██▄   ███    ███   ███ ▄███▀   ███    ███");
            Console.WriteLine("    ███    █▀  ███   ███   ███    ███   ███▐██▀     ███    █▀ ");
            Console.WriteLine("    ███        ███   ███   ███    ███  ▄█████▀     ▄███▄▄▄    ");
            Console.WriteLine("  ▀███████████ ███   ███ ▀███████████ ▀▀█████▄    ▀▀███▀▀▀    ");
            Console.WriteLine("           ███ ███   ███   ███    ███   ███▐██▄     ███    █▄ ");
            Console.WriteLine("     ▄█    ███ ███   ███   ███    ███   ███ ▀███▄   ███    ███");
            Console.WriteLine("   ▄████████▀   ▀█   █▀    ███    █▀    ███   ▀█▀   ██████████");
            Console.WriteLine("                                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("                         1- Let's Play               ");
            Console.WriteLine("                         2- Quit The Game            ");
            Console.WriteLine();


            while (true)
            {
                press = Console.ReadKey(true);
                if (press.Key == ConsoleKey.D1)
                {
                    choiceNum = 1;
                    break;
                }
                else if (press.Key == ConsoleKey.D2)
                {
                    choiceNum = 2;
                    break;
                }
            }

            switch (choiceNum)
            {
                case 1:
                    start = true;
                    break;


                case 2:
                    AreUsure("quit");
                    break;
            }
        }
        void AreUsure(string Case)
        {
            while (true)
            {
                if (Case == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.CursorTop = 15;
                    Console.WriteLine();
                    Console.WriteLine("                                                         ");
                    Console.WriteLine("                  Do You Want To Quit The Game?          ");
                    Console.WriteLine("                       1- Yes                            ");
                    Console.WriteLine("                       2- No                             ");
                    Console.Write("                                                         ");

                    press = Console.ReadKey(true);
                    if (press.Key == ConsoleKey.D1)
                        Environment.Exit(0);
                    if (press.Key == ConsoleKey.D2)
                        ViewMainMenu();
                }

            }
        }
    }

}