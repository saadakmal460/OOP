using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Grid
    {
        public Cell FindGhost(char ghostCharacter)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    if (maze[x, y].value == ghostCharacter)
                    {
                        Cell c = new Cell(x, y, maze[x, y].value);
                        return c;

                    }
                }
            }
            return null;
        }
        public Cell FindPacman()
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    if(maze[x,y].value == 'p')
                    {
                        Cell c = new Cell(x, y, maze[x, y].value);
                        return c;
                        
                    }
                }
            }
            return null;
        }

        public Cell GetDownCell(Cell c)
        {
            int x, y;
            char value;
            x = c.x;
            y = c.y + 1;
            value = maze[x, y].value;
            Cell c2 = new Cell(x, y, value);
            return c2;
        }
        public Cell GetUpCell(Cell c)
        {
            int x, y;
            char value;
            x = c.x;
            y = c.y - 1;
            value = maze[x, y].value;
            Cell c2 = new Cell(x, y, value);
            return c2;
        }
        public Cell GetRightCell(Cell c)
        {
            int x, y;
            char value;
            x = c.x + 1;
            y = c.y;
            value = maze[x, y].value;
            Cell c2 = new Cell(x, y, value);
            return c2;

        }
        public Cell GetLeftCell(Cell c)
        {
            int x, y;
            char value;
            x = c.x - 1;
            y = c.y;
            value = maze[x , y].value;
            Cell c2 = new Cell(x, y, value);
            return c2;
        }
        public void Draw()
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x, y].value);
                    
                }
                Console.WriteLine();
                
            }
           
        }
        public Grid(string path , int rowSize, int colomnSize)
        {
            this.rowSize = rowSize;
            this.colomnSize = colomnSize;
            StreamReader file = new StreamReader(path);
            string record;
            int row = 0;
            maze = new Cell[rowSize , colomnSize];
            while ((record = file.ReadLine()) != null)
            {
                for (int x = 0; x < colomnSize; x++)
                {
                    char v = record[x];
                    Cell c = new Cell(x, row, v);
                    maze[row , x] = c;
                }
                row++;
            }

            file.Close();

        }
        public Cell[,] maze;
        public int rowSize;
        public int colomnSize;
    }
}
