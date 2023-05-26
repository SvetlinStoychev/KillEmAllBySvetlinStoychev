using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll
{
     class StartGame
    {
         private static bool isGameExit = false;
         private static void Start()
         {
             Console.ForegroundColor = ConsoleColor.DarkGreen;
             for (int i = 0; i < Console.WindowWidth; i++)
             {
                 Console.SetCursorPosition(i, 5);
                 Console.Write("=");
             }
             for (int i = 6; i < 20; i++)
             {
                 Console.SetCursorPosition(0, i);
                 Console.Write("*");
             }
             for (int i = 6; i < 20; i++)
             {
                 Console.SetCursorPosition(Console.WindowWidth - 1, i);
                 Console.Write("*");
             }
             for (int i = 0; i < Console.WindowWidth; i++)
             {
                 Console.SetCursorPosition(i, 20);
                 Console.Write("=");
             }

             Console.ForegroundColor = ConsoleColor.DarkYellow;
             Console.SetCursorPosition(5, 9);
             Console.Write("Press: ");
             Console.SetCursorPosition(15, 11);
             Console.Write("1 - New Game");
             Console.SetCursorPosition(15, 14);
             Console.Write("2 - Exit");
             Console.ResetColor();
         }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //TheGame newGamee = new TheGame();
            //newGamee.CreateScreen();
            //newGamee.PrintMe();
            //newGamee.RunGame();
            while (!isGameExit)
            {
                Console.Clear();
                Start();
                ConsoleKeyInfo userInput = Console.ReadKey(true);
                if (userInput.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    TheGame newGamee = new TheGame();
                    newGamee.CreateScreen();
                    newGamee.PrintMe();
                    newGamee.RunGame();
                }
                else if (userInput.Key == ConsoleKey.D2)
                {
                    isGameExit = true;
                }
            }
        }
    }
}
