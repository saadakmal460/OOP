using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;

namespace Game
{
    class Program
    {
        class Game
        {
            public void IncreaseX()
            {
                px++;
            }
            public Game()
            {
                px = 15;
                py = 4;
            }
            public int px;
            public int py;
        }
        static void Main(string[] args)
        {
            char[,] maze = new char[28, 146];
            char[,] Player = new char[,]
            {   {' ' , ' ' , 'o' , ' '},
                {' ' , '/' , '|' , '\\'},
                {' ' , ' ' , '|' , ' '},
                { ' ' , '/' , ' ' , '\\'} 
            };

            Game g = new Game();
            ReadData(maze);
            PrintPlayer(maze, Player , g);
            PrintMaze(maze);
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    MovePlayerRight(maze, Player, g);
                    Console.Clear();
                    PrintMaze(maze);
                }
                
                
            }
            
            Console.ReadKey(); 
        }


        static void MovePlayerRight(char[,] maze, char[,] player , Game g)
        {
            if (maze[g.py , g.px + 5] == ' ')
            {
                ErasePlayer(maze, g , player);
                g.IncreaseX();
                PrintPlayer(maze,player , g);
                
            }
        }

        static void ErasePlayer(char[,] maze , Game g , char[,] player)
        {
            for (int i = 0; i < player.GetLength(0); i++)
            {
                for (int j = 0; j < player.GetLength(1); j++)
                {

                    maze[g.py + i, g.px + j] = ' ';

                }
            }
        }
        static void PrintPlayer(char[,] maze, char[,] player, Game g)
        {
            for (int i = 0; i < player.GetLength(0); i++)
            {
                for (int j = 0; j < player.GetLength(1); j++)
                {

                    maze[g.py + i, g.px + j] = player[i, j];
                    
                }
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
            string path = "maze.txt";
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
