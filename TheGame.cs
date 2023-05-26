using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KillEmAll
{
    public class TheGame
    {
        private int gameWindowWidth = 80;
        private int gameWindowHeight = 30;
        private Me me = new Me(39, 40, 41);
        private List<Bullet> bullets = new List<Bullet>();
        private List<Rock> rocks = new List<Rock>();
        private int score = 0;
        private bool isGameOver = false;
        private int rockSpeed = 1200;
        private int numOfRocksPerline = 3;
        private bool isLevelTwo = true;
        private bool isSingleShot = true;
        private bool isLevelThree = true;
        private void CheckForCrash()
        {
            for (int i = 0; i < this.rocks.Count; i++)
            {
                for (int j = 0; j < this.bullets.Count; j++)
                {
                    if ((this.rocks[i].Row == this.bullets[j].Row) && (this.rocks[i].Col == this.bullets[j].Col))
                    {
                        Console.SetCursorPosition(this.bullets[j].Col, this.bullets[j].Row);
                        Console.Write(" ");
                        this.rocks.RemoveAt(i);
                        this.bullets.RemoveAt(j);
                        this.score++;
                        this.PrintScore();
                        return;
                    }
                }
            }
        }

        private void ClearRock()
        {
            foreach (var item in this.rocks)
            {
                Console.SetCursorPosition(item.Col, item.Row - 1);
                Console.WriteLine(" ");
            }
        }

        private void MoveRocks()
        {
            for (int i = 0; i < this.rocks.Count; i++)
            {
                if (this.rocks[i].Row < this.gameWindowHeight - 1)
                {
                    this.rocks[i].Row++;
                }
                else
                {
                    Console.SetCursorPosition(this.rocks[i].Col, this.rocks[i].Row);
                    Console.Write(" ");
                    this.isGameOver = true;
                }
            }
        }

        private void PrintRocks()
        {
            foreach (var item in this.rocks)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(item.Col, item.Row);
                Console.Write("@");
            }
            Console.ResetColor();
        }

        private void CreateRocksLevelThree()
        {
            this.rocks.Add(new Rock(0, 9));
            this.rocks.Add(new Rock(0, 10));
            this.rocks.Add(new Rock(0, 11));
            this.rocks.Add(new Rock(1, 8));
            this.rocks.Add(new Rock(1, 9));
            this.rocks.Add(new Rock(1, 10));
            this.rocks.Add(new Rock(1,11));
            this.rocks.Add(new Rock(1, 12));
            this.rocks.Add(new Rock(2, 6));
            this.rocks.Add(new Rock(2, 7));
            this.rocks.Add(new Rock(2, 8));
            this.rocks.Add(new Rock(2, 9));
            this.rocks.Add(new Rock(2, 10));
            this.rocks.Add(new Rock(2, 11));
            this.rocks.Add(new Rock(2, 12));
            this.rocks.Add(new Rock(2, 13));
            this.rocks.Add(new Rock(2, 14));
            this.rocks.Add(new Rock(3, 8));
            this.rocks.Add(new Rock(3, 9));
            this.rocks.Add(new Rock(3, 10));
            this.rocks.Add(new Rock(3, 11));
            this.rocks.Add(new Rock(3, 12));
            this.rocks.Add(new Rock(4, 6));
            this.rocks.Add(new Rock(4, 7));
            this.rocks.Add(new Rock(4, 8));
            this.rocks.Add(new Rock(4, 9));
            this.rocks.Add(new Rock(4, 10));
            this.rocks.Add(new Rock(4, 11));
            this.rocks.Add(new Rock(4, 12));
            this.rocks.Add(new Rock(4, 13));
            this.rocks.Add(new Rock(4, 14));
            this.rocks.Add(new Rock(5, 8));
            this.rocks.Add(new Rock(5, 9));
            this.rocks.Add(new Rock(5, 10));
            this.rocks.Add(new Rock(5, 11));
            this.rocks.Add(new Rock(5, 12));
            this.rocks.Add(new Rock(6, 6));
            this.rocks.Add(new Rock(6, 7));
            this.rocks.Add(new Rock(6, 8));
            this.rocks.Add(new Rock(6, 9));
            this.rocks.Add(new Rock(6, 10));
            this.rocks.Add(new Rock(6, 11));
            this.rocks.Add(new Rock(6, 12));
            this.rocks.Add(new Rock(6, 13));
            this.rocks.Add(new Rock(6, 14));
            this.rocks.Add(new Rock(7, 8));
            this.rocks.Add(new Rock(7, 9));
            this.rocks.Add(new Rock(7, 10));
            this.rocks.Add(new Rock(7, 11));
            this.rocks.Add(new Rock(7, 12));
            this.rocks.Add(new Rock(8, 9));
            this.rocks.Add(new Rock(8, 10));
            this.rocks.Add(new Rock(8, 11));
            this.rocks.Add(new Rock(9, 9));
            this.rocks.Add(new Rock(9, 11));

            this.rocks.Add(new Rock(0, 39));
            this.rocks.Add(new Rock(0, 40));
            this.rocks.Add(new Rock(0, 41));
            this.rocks.Add(new Rock(1, 38));
            this.rocks.Add(new Rock(1, 39));
            this.rocks.Add(new Rock(1, 40));
            this.rocks.Add(new Rock(1, 41));
            this.rocks.Add(new Rock(1, 42));
            this.rocks.Add(new Rock(2, 36));
            this.rocks.Add(new Rock(2, 37));
            this.rocks.Add(new Rock(2, 38));
            this.rocks.Add(new Rock(2, 39));
            this.rocks.Add(new Rock(2, 40));
            this.rocks.Add(new Rock(2, 41));
            this.rocks.Add(new Rock(2, 42));
            this.rocks.Add(new Rock(2, 43));
            this.rocks.Add(new Rock(2, 44));
            this.rocks.Add(new Rock(3, 38));
            this.rocks.Add(new Rock(3, 39));
            this.rocks.Add(new Rock(3, 40));
            this.rocks.Add(new Rock(3, 41));
            this.rocks.Add(new Rock(3, 42));
            this.rocks.Add(new Rock(4, 36));
            this.rocks.Add(new Rock(4, 37));
            this.rocks.Add(new Rock(4, 38));
            this.rocks.Add(new Rock(4, 39));
            this.rocks.Add(new Rock(4, 40));
            this.rocks.Add(new Rock(4, 41));
            this.rocks.Add(new Rock(4, 42));
            this.rocks.Add(new Rock(4, 43));
            this.rocks.Add(new Rock(4, 44));
            this.rocks.Add(new Rock(5, 38));
            this.rocks.Add(new Rock(5, 39));
            this.rocks.Add(new Rock(5, 40));
            this.rocks.Add(new Rock(5, 41));
            this.rocks.Add(new Rock(5, 42));
            this.rocks.Add(new Rock(6, 36));
            this.rocks.Add(new Rock(6, 37));
            this.rocks.Add(new Rock(6, 38));
            this.rocks.Add(new Rock(6, 39));
            this.rocks.Add(new Rock(6, 40));
            this.rocks.Add(new Rock(6, 41));
            this.rocks.Add(new Rock(6, 42));
            this.rocks.Add(new Rock(6, 43));
            this.rocks.Add(new Rock(6, 44));
            this.rocks.Add(new Rock(7, 38));
            this.rocks.Add(new Rock(7, 39));
            this.rocks.Add(new Rock(7, 40));
            this.rocks.Add(new Rock(7, 41));
            this.rocks.Add(new Rock(7, 42));
            this.rocks.Add(new Rock(8, 39));
            this.rocks.Add(new Rock(8, 40));
            this.rocks.Add(new Rock(8, 41));
            this.rocks.Add(new Rock(9, 39));
            this.rocks.Add(new Rock(9, 41));

            this.rocks.Add(new Rock(0, 59));
            this.rocks.Add(new Rock(0, 60));
            this.rocks.Add(new Rock(0, 61));
            this.rocks.Add(new Rock(1, 58));
            this.rocks.Add(new Rock(1, 59));
            this.rocks.Add(new Rock(1, 60));
            this.rocks.Add(new Rock(1, 61));
            this.rocks.Add(new Rock(1, 62));
            this.rocks.Add(new Rock(2, 56));
            this.rocks.Add(new Rock(2, 57));
            this.rocks.Add(new Rock(2, 58));
            this.rocks.Add(new Rock(2, 59));
            this.rocks.Add(new Rock(2, 60));
            this.rocks.Add(new Rock(2, 61));
            this.rocks.Add(new Rock(2, 62));
            this.rocks.Add(new Rock(2, 63));
            this.rocks.Add(new Rock(2, 64));
            this.rocks.Add(new Rock(3, 58));
            this.rocks.Add(new Rock(3, 59));
            this.rocks.Add(new Rock(3, 60));
            this.rocks.Add(new Rock(3, 61));
            this.rocks.Add(new Rock(3, 62));
            this.rocks.Add(new Rock(4, 56));
            this.rocks.Add(new Rock(4, 57));
            this.rocks.Add(new Rock(4, 58));
            this.rocks.Add(new Rock(4, 59));
            this.rocks.Add(new Rock(4, 60));
            this.rocks.Add(new Rock(4, 61));
            this.rocks.Add(new Rock(4, 62));
            this.rocks.Add(new Rock(4, 63));
            this.rocks.Add(new Rock(4, 64));
            this.rocks.Add(new Rock(5, 58));
            this.rocks.Add(new Rock(5, 59));
            this.rocks.Add(new Rock(5, 60));
            this.rocks.Add(new Rock(5, 61));
            this.rocks.Add(new Rock(5, 62));
            this.rocks.Add(new Rock(6, 56));
            this.rocks.Add(new Rock(6, 57));
            this.rocks.Add(new Rock(6, 58));
            this.rocks.Add(new Rock(6, 59));
            this.rocks.Add(new Rock(6, 60));
            this.rocks.Add(new Rock(6, 61));
            this.rocks.Add(new Rock(6, 62));
            this.rocks.Add(new Rock(6, 63));
            this.rocks.Add(new Rock(6, 64));
            this.rocks.Add(new Rock(7, 58));
            this.rocks.Add(new Rock(7, 59));
            this.rocks.Add(new Rock(7, 60));
            this.rocks.Add(new Rock(7, 61));
            this.rocks.Add(new Rock(7, 62));
            this.rocks.Add(new Rock(8, 59));
            this.rocks.Add(new Rock(8, 60));
            this.rocks.Add(new Rock(8, 61));
            this.rocks.Add(new Rock(9, 59));
            this.rocks.Add(new Rock(9, 61));
        }

        private void CreateRocksLevelTwo()
        {
            this.rocks.Add(new Rock(0, 16));
            this.rocks.Add(new Rock(0, 17));
            this.rocks.Add(new Rock(0, 18));
            this.rocks.Add(new Rock(0, 19));
            this.rocks.Add(new Rock(0, 20));
            this.rocks.Add(new Rock(0, 21));
            this.rocks.Add(new Rock(0, 22));
            this.rocks.Add(new Rock(0, 23));
            this.rocks.Add(new Rock(0, 24));
            this.rocks.Add(new Rock(1, 16));
            this.rocks.Add(new Rock(1, 17));
            this.rocks.Add(new Rock(1, 18));
            this.rocks.Add(new Rock(1, 19));
            this.rocks.Add(new Rock(1, 20));
            this.rocks.Add(new Rock(1, 21));
            this.rocks.Add(new Rock(1, 22));
            this.rocks.Add(new Rock(1, 23));
            this.rocks.Add(new Rock(1, 24));
            this.rocks.Add(new Rock(2, 18));
            this.rocks.Add(new Rock(2, 19));
            this.rocks.Add(new Rock(2, 20));
            this.rocks.Add(new Rock(2, 21));
            this.rocks.Add(new Rock(2, 22));
            this.rocks.Add(new Rock(3, 18));
            this.rocks.Add(new Rock(3, 19));
            this.rocks.Add(new Rock(3, 20));
            this.rocks.Add(new Rock(3, 21));
            this.rocks.Add(new Rock(3, 22));
            this.rocks.Add(new Rock(4, 18));
            this.rocks.Add(new Rock(4, 19));
            this.rocks.Add(new Rock(4, 20));
            this.rocks.Add(new Rock(4, 21));
            this.rocks.Add(new Rock(4, 22));
            this.rocks.Add(new Rock(5, 16));
            this.rocks.Add(new Rock(5, 17));
            this.rocks.Add(new Rock(5, 18));
            this.rocks.Add(new Rock(5, 19));
            this.rocks.Add(new Rock(5, 20));
            this.rocks.Add(new Rock(5, 21));
            this.rocks.Add(new Rock(5, 22));
            this.rocks.Add(new Rock(5, 23));
            this.rocks.Add(new Rock(5, 24));
            this.rocks.Add(new Rock(6, 19));
            this.rocks.Add(new Rock(6, 20));
            this.rocks.Add(new Rock(6, 21));
            this.rocks.Add(new Rock(7, 19));
            this.rocks.Add(new Rock(7, 20));
            this.rocks.Add(new Rock(7, 21));

            this.rocks.Add(new Rock(0, 56));
            this.rocks.Add(new Rock(0, 57));
            this.rocks.Add(new Rock(0, 58));
            this.rocks.Add(new Rock(0, 59));
            this.rocks.Add(new Rock(0, 60));
            this.rocks.Add(new Rock(0, 61));
            this.rocks.Add(new Rock(0, 62));
            this.rocks.Add(new Rock(0, 63));
            this.rocks.Add(new Rock(0, 64));
            this.rocks.Add(new Rock(1, 56));
            this.rocks.Add(new Rock(1, 57));
            this.rocks.Add(new Rock(1, 58));
            this.rocks.Add(new Rock(1, 59));
            this.rocks.Add(new Rock(1, 60));
            this.rocks.Add(new Rock(1, 61));
            this.rocks.Add(new Rock(1, 62));
            this.rocks.Add(new Rock(1, 63));
            this.rocks.Add(new Rock(1, 64));
            this.rocks.Add(new Rock(2, 58));
            this.rocks.Add(new Rock(2, 59));
            this.rocks.Add(new Rock(2, 60));
            this.rocks.Add(new Rock(2, 61));
            this.rocks.Add(new Rock(2, 62));
            this.rocks.Add(new Rock(3, 58));
            this.rocks.Add(new Rock(3, 59));
            this.rocks.Add(new Rock(3, 60));
            this.rocks.Add(new Rock(3, 61));
            this.rocks.Add(new Rock(3, 62));
            this.rocks.Add(new Rock(4, 58));
            this.rocks.Add(new Rock(4, 59));
            this.rocks.Add(new Rock(4, 60));
            this.rocks.Add(new Rock(4, 61));
            this.rocks.Add(new Rock(4, 62));
            this.rocks.Add(new Rock(5, 56));
            this.rocks.Add(new Rock(5, 57));
            this.rocks.Add(new Rock(5, 58));
            this.rocks.Add(new Rock(5, 59));
            this.rocks.Add(new Rock(5, 60));
            this.rocks.Add(new Rock(5, 61));
            this.rocks.Add(new Rock(5, 62));
            this.rocks.Add(new Rock(5, 63));
            this.rocks.Add(new Rock(5, 64));
            this.rocks.Add(new Rock(6, 59));
            this.rocks.Add(new Rock(6, 60));
            this.rocks.Add(new Rock(6, 61));
            this.rocks.Add(new Rock(7, 59));
            this.rocks.Add(new Rock(7, 60));
            this.rocks.Add(new Rock(7, 61));
        }

        private void CreateRocksLevelOne()
        {
            this.rocks.Add(new Rock(0, 18));
            this.rocks.Add(new Rock(0, 19));
            this.rocks.Add(new Rock(0, 20));
            this.rocks.Add(new Rock(0, 21));
            this.rocks.Add(new Rock(0, 22));
            this.rocks.Add(new Rock(1, 19));
            this.rocks.Add(new Rock(1, 20));
            this.rocks.Add(new Rock(1, 21));
            this.rocks.Add(new Rock(2, 20));

            this.rocks.Add(new Rock(0, 38));
            this.rocks.Add(new Rock(0, 39));
            this.rocks.Add(new Rock(0, 40));
            this.rocks.Add(new Rock(0, 41));
            this.rocks.Add(new Rock(0, 42));
            this.rocks.Add(new Rock(1, 39));
            this.rocks.Add(new Rock(1, 40));
            this.rocks.Add(new Rock(1, 41));
            this.rocks.Add(new Rock(2, 40));

            this.rocks.Add(new Rock(0, 58));
            this.rocks.Add(new Rock(0, 59));
            this.rocks.Add(new Rock(0, 60));
            this.rocks.Add(new Rock(0, 61));
            this.rocks.Add(new Rock(0, 62));
            this.rocks.Add(new Rock(1, 59));
            this.rocks.Add(new Rock(1, 60));
            this.rocks.Add(new Rock(1, 61));
            this.rocks.Add(new Rock(2, 60));
        }

        private void CreateRocks()
        {
            Random rndGenerator = new Random();
            int col = rndGenerator.Next(this.gameWindowWidth - 2);
            int numOfRockForLine = rndGenerator.Next(this.numOfRocksPerline);
            for (int i = 0; i < numOfRockForLine; i++)
            {
                this.rocks.Add(new Rock(0, col));
                col = rndGenerator.Next(this.gameWindowWidth - 2);
            }
        }

        private void ClearBullets()
        {
            foreach (var item in this.bullets)
            {
                Console.SetCursorPosition(item.Col, item.Row + 1);
                Console.WriteLine(" ");
            }
        }

        private void PrintBullets()
        {
            foreach (var item in this.bullets)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(item.Col, item.Row);
                Console.Write("*");
            }
            Console.ResetColor();
        }

        private void MoveBullets()
        {
            for (int i = 0; i < this.bullets.Count; i++)
            {
                if (this.bullets[i].Row > 0)
                {
                    this.bullets[i].Row--;
                }
                else
                {
                    Console.SetCursorPosition(this.bullets[i].Col, this.bullets[i].Row);
                    Console.Write(" ");
                    this.bullets.RemoveAt(i);
                }
            }
        }

        private void SingleShot()
        {
            this.bullets.Add(new Bullet(this.gameWindowHeight - 3, this.me.MiddleElement));
        }

        private void DoubleShot()
        {
            this.bullets.Add(new Bullet(this.gameWindowHeight - 2, this.me.LeftElement));
            this.bullets.Add(new Bullet(this.gameWindowHeight - 3, this.me.MiddleElement));
            this.bullets.Add(new Bullet(this.gameWindowHeight - 2, this.me.RightElement));
        }

        public void RunGame()
        {
            int rocksStart = Environment.TickCount;
            int rocksStop = rocksStart + this.rockSpeed;
            int bulletsStart = Environment.TickCount;
            int bulletsStop = bulletsStart + 40;
            this.CreateRocksLevelOne();
            while (!this.isGameOver)
            {
                rocksStart = Environment.TickCount;
                if (rocksStart > rocksStop)
                {
                    if (this.score < 27)
                    {
                        if (this.score >= 18 )
                        {
                            this.isSingleShot = false;
                        }
                        this.CheckForCrash();
                        this.MoveRocks();
                        this.ClearRock();
                        this.PrintRocks();
                        rocksStart = Environment.TickCount;
                        rocksStop = rocksStart + this.rockSpeed;
                    }
                    else if (this.score >= 27 && this.score < 123)
                    {
                        if (this.isLevelTwo)
                        {
                            this.CreateRocksLevelTwo();
                            this.isLevelTwo = false;
                            this.isSingleShot = true;
                            this.PrintRocks();
                        }
                        if (this.score >= 40)
                        {
                            this.isSingleShot = false;
                        }
                        this.CheckForCrash();
                        this.MoveRocks();
                        this.ClearRock();
                        this.PrintRocks();
                        rocksStart = Environment.TickCount;
                        rocksStop = rocksStart + this.rockSpeed;
                    }
                    else if (this.score >= 123 && this.score < 288)
                    {
                        if (this.isLevelThree)
                        {
                            this.CreateRocksLevelThree();
                            this.isLevelThree = false;
                            this.PrintRocks();
                        }
                        this.CheckForCrash();
                        this.MoveRocks();
                        this.ClearRock();
                        this.PrintRocks();
                        rocksStart = Environment.TickCount;
                        rocksStop = rocksStart + this.rockSpeed;
                    }
                    else
                    {
                        this.CreateRocks();
                        this.PrintRocks();
                        this.CheckForCrash();
                        this.MoveRocks();
                        this.ClearRock();
                        this.PrintRocks();
                        rocksStart = Environment.TickCount;
                        rocksStop = rocksStart + 1000;
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.LeftArrow && this.me.LeftElement > 0)
                    {
                        this.ClearMe();
                        this.me.LeftElement--;
                        this.me.MiddleElement--;
                        this.me.RightElement--;
                        this.PrintMe();
                    }
                    else if (userInput.Key == ConsoleKey.RightArrow && this.me.RightElement < this.gameWindowWidth - 2)
                    {
                        this.ClearMe();
                        this.me.LeftElement++;
                        this.me.MiddleElement++;
                        this.me.RightElement++;
                        this.PrintMe();
                    }
                    else if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (this.isSingleShot)
                        {
                            this.SingleShot();
                        }
                        else
                        {
                            this.DoubleShot();

                        }
                    }
                }

                bulletsStart = Environment.TickCount;
                if (bulletsStart > bulletsStop)
                {
                    this.PrintBullets();
                    this.CheckForCrash();
                    this.MoveBullets();
                    this.ClearBullets();
                    this.PrintBullets();
                    bulletsStart = Environment.TickCount;
                    bulletsStop = bulletsStart + 40;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("Game Over");
            Console.ResetColor();
            Thread.Sleep(2500);
        }

        private void ClearMe()
        {
            Console.SetCursorPosition(this.me.LeftElement, this.gameWindowHeight - 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.me.MiddleElement, this.gameWindowHeight - 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.me.RightElement, this.gameWindowHeight - 1);
            Console.Write(" ");
        }

        public void PrintMe()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(this.me.LeftElement, this.gameWindowHeight - 1);
            Console.Write("^");
            Console.SetCursorPosition(this.me.MiddleElement, this.gameWindowHeight - 2);
            Console.Write("^");
            Console.SetCursorPosition(this.me.RightElement, this.gameWindowHeight - 1);
            Console.Write("^");
            Console.ResetColor();
        }

        private void PrintScore()
        {
            Console.SetCursorPosition(93, 5);
            Console.Write(this.score);
        }

        public void CreateScreen()
        {
            Console.BufferWidth = Console.WindowWidth = 100;
            Console.BufferHeight = Console.WindowHeight = 30;
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(80, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(85, 5);
            Console.Write("Score: ");
        }
    }
}
