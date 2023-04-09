using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] maze = new char[28, 146];
            int heroX = 9;
            int heroY = 31;

            ReadData(maze);
            PrintMaze(maze);
            while(true)
            {
                Thread.Sleep(10);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    HeroUp(maze, ref heroX, ref heroY);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    HeroDown(maze, ref heroX, ref heroY);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    HeroLeft(maze, ref heroX, ref heroY);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    HeroRight(maze, ref heroX, ref heroY);
                }

            }

            
            //Console.ReadKey();
        }

        static void HeroUp(char[,] maze, ref int heroX, ref int heroY)
        {
            if (maze[heroX - 1, heroY] == ' ')
            {
                maze[heroX, heroY] = ' ';
                Console.SetCursorPosition(heroY+2, heroX);
                Console.Write("   ");
                heroX = heroX - 1;
                Console.SetCursorPosition(heroY, heroX);

                maze[heroX, heroY] = ' ';

                character(ref heroX, ref heroY);

            }
        }

        static void HeroDown(char[,] maze, ref int heroX, ref int heroY)
        {
            if (maze[heroX + 4, heroY] == ' ')
            {
                maze[heroX, heroY] = ' ';
                Console.SetCursorPosition(heroY, heroX);
                Console.Write("   ");
                heroX = heroX + 1;
                Console.SetCursorPosition(heroY, heroX);
                maze[heroX, heroY] = ' ';
                character(ref heroX, ref heroY);

            }
        }

        static void HeroRight(char[,] maze, ref int heroX, ref int heroY)
        {
            if (maze[heroX, heroY + 4] == ' ')
            {
                maze[heroX, heroY] = ' ';
                Console.SetCursorPosition(heroY+1, heroX);
                Console.Write("   ");
                heroY = heroY + 1;
                Console.SetCursorPosition(heroY, heroX);
                maze[heroX, heroY] = ' ';
                
                character(ref heroX , ref heroY);

            }
        }

        static void HeroLeft(char[,] maze, ref int heroX, ref int heroY)
        {
            if (maze[heroX, heroY - 4] == ' ')
            {
                maze[heroX, heroY] = ' ';
                Console.SetCursorPosition(heroY -2, heroX+2);
                Console.Write(" ");
                
                heroY = heroY - 1;
                Console.SetCursorPosition(heroY, heroX);
                maze[heroX, heroY] = ' ';

                character(ref heroX, ref heroY);
            }
        }






        static void RemoveCharacter(ref int x, ref int y)
        {
            char[,] hero = new char[4, 4]  { {' ' , ' ', ' ' , ' ' },
                                            {' ' , ' ' , ' ' , ' ' },
                                            {' ' , ' ' , ' ' , ' ' },
                                            {' ' , ' ' , ' ' , ' ' }};
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.SetCursorPosition(y + j, x + i);
                    Console.Write(hero[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void character(ref int x , ref int y)
        {
            char[,] hero = new char[4, 4]  { {' ' , ' ', 'o' , ' ' },
                                            {' ' , '/' , '|' , '\\' },
                                            {' ' , ' ' , '|' , ' ' },
                                            {' ' , '/' , ' ' , '\\' }};
            for(int i =0; i<4; i++)
            {
                for(int j =0; j<4; j++)
                {
                    Console.SetCursorPosition(y+j , x+i);
                    Console.Write(hero[i,j]);
                }
                Console.WriteLine();
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
