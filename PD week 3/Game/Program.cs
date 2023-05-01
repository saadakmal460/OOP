using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EZInput;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Program
    {
        class Game
        {
            
            public int hx = 10;
            public int hy = 1;

            public int enemyX = 15;
            public int enemyY = 21;
            public string enemyDirection = "left";
            public char previous = ' ';

            public int[] BulletX = new int[1000];
            public int[] BulletY = new int[1000];

            public int bulletCount = 0;

        }
        static void Main(string[] args)
        {
            char[,] maze = new char[28, 146];
            Game position = new Game();
            ReadData(maze);
            PrintMaze(maze);
            while (true)
            {
                Thread.Sleep(40);
                MoveEnemy(maze, position);
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    HeroLeft(maze, position);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    HeroRight(maze, position);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    HeroDown(maze, position);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    HeroUp(maze, position);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    GenerateBullet(position);
                }
                MoveBullet(maze, position);
            }

            Console.ReadKey();
        }


        static void MoveEnemy(char[,] maze, Game position)
        {
            if (position.enemyDirection == "left" && maze[position.enemyX, position.enemyY - 1] == ' ')
            {

                maze[position.enemyX, position.enemyY] = position.previous;
                Console.SetCursorPosition(position.enemyY, position.enemyX);
                Console.Write(position.previous);

                position.enemyY = position.enemyY - 1;

                position.previous = maze[position.enemyX, position.enemyY];
                Console.SetCursorPosition(position.enemyY, position.enemyX);
                Console.Write("J");
                if (maze[position.enemyX, position.enemyY - 1] == '|')
                {
                    position.enemyDirection = "right";
                }


            }

            else if (position.enemyDirection == "right" && maze[position.enemyX, position.enemyY + 1] == ' ')
            {
                maze[position.enemyX, position.enemyY] = position.previous;
                Console.SetCursorPosition(position.enemyY, position.enemyX);
                Console.Write(position.previous);

                position.enemyY = position.enemyY + 1;

                position.previous = maze[position.enemyX, position.enemyY];
                Console.SetCursorPosition(position.enemyY, position.enemyX);
                Console.Write("J");
                if (maze[position.enemyX, position.enemyY + 1] == '|')
                {
                    position.enemyDirection = "left";
                }
            }
        }
        static void MoveBullet(char[,] maze, Game position)
        {
            for (int i = 0; i < position.bulletCount; i++)
            {
                int bulletX = position.BulletX[i];
                int bulletY = position.BulletY[i];

                if (maze[bulletX + 1, bulletY] != ' ')
                {
                    EraseBullet(position);
                    RemoveBullet(position, i);
                    i--;
                }
                else
                {
                    EraseBullet(position);
                    position.BulletX[i] = bulletX + 1;
                    PrintBullet(position);
                }
            }
        }

        static void GenerateBullet(Game position)
        {
            position.BulletX[position.bulletCount] = position.hx;
            position.BulletY[position.bulletCount] = position.hy;
            Console.Write("*");
            position.bulletCount++;
        }


        static void RemoveBullet(Game position, int x)
        {
            for (int i = x; i < position.bulletCount - 1; i++)
            {
                position.BulletX[i] = position.BulletX[i + 1];
                position.BulletY[i] = position.BulletY[i + 1];

            }
            position.bulletCount--;
        }

        static void PrintBullet(Game position)
        {
            Console.SetCursorPosition(position.hy + 1, position.hx);
            Console.Write("*");
        }
        static void EraseBullet(Game position)
        {
            Console.SetCursorPosition(position.hy + 1, position.hx);
            Console.Write(" ");
        }

        static void HeroUp(char[,] maze, Game position)
        {
            if (maze[position.hx - 1, position.hy] == ' ')
            {
                maze[position.hx, position.hy] = ' ';
                Console.SetCursorPosition(position.hy, position.hx);
                Console.Write(" ");

                position.hx = position.hx - 1;
                Console.SetCursorPosition(position.hy, position.hx);
                maze[position.hx, position.hy] = ' ';
                Console.Write("H");

            }
        }

        static void HeroDown(char[,] maze, Game position)
        {
            if (maze[position.hx + 1, position.hy] == ' ')
            {
                maze[position.hx, position.hy] = ' ';
                Console.SetCursorPosition(position.hy, position.hx);
                Console.Write(" ");

                position.hx = position.hx + 1;
                Console.SetCursorPosition(position.hy, position.hx);
                maze[position.hx, position.hy] = ' ';
                Console.Write("H");

            }
        }


        static void HeroRight(char[,] maze, Game position)
        {
            if (maze[position.hx, position.hy + 1] == ' ')
            {
                maze[position.hx, position.hy] = ' ';
                Console.SetCursorPosition(position.hy, position.hx);
                Console.Write(" ");

                position.hy = position.hy + 1;
                Console.SetCursorPosition(position.hy, position.hx);
                maze[position.hx, position.hy] = ' ';
                Console.Write("H");

            }
        }
        static void HeroLeft(char[,] maze, Game position)
        {
            if (maze[position.hx, position.hy - 1] == ' ')
            {
                maze[position.hx, position.hy] = ' ';
                Console.SetCursorPosition(position.hy, position.hx);
                Console.Write(" ");

                position.hy = position.hy - 1;
                Console.SetCursorPosition(position.hy, position.hx);
                maze[position.hx, position.hy] = ' ';
                Console.Write("H");

            }
        }

        static void PrintMaze(char[,] maze)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x, y]);
                }
                Console.WriteLine();
            }

        }
        static void ReadData(char[,] maze)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 1\\Game\\maze.txt";
            StreamReader file = new StreamReader(path);
            string record;
            int row = 0;
            while ((record = file.ReadLine()) != null)
            {
                for (int x = 0; x < 145; x++)
                {
                    maze[row, x] = record[x];
                }
                row++;
            }

            file.Close();
        }
    }
}
