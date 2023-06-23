using EZInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameGrid grid = new GameGrid("maze.txt", 24, 71);

            GameCell start = new GameCell(12, 22, grid);
            

            GamePacManPlayer pacman = new GamePacManPlayer('P', start , GameObjectType.Player);
            
            
            printMaze(grid);
            printGameObject(pacman);


            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.Up);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.Down);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);
                }


                
                
            }
        }


        
        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            
            
            Console.SetCursorPosition(gameCell.y, gameCell.x);
            Console.Write(newGameObject.DisplayCharacter);

        }
        static void printGameObject(GameObject gameObject)
        {
  
            Console.SetCursorPosition(gameObject.CurrentCell.y, gameObject.CurrentCell.x);
            Console.Write(gameObject.DisplayCharacter);

        }
        
        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.NextCell(direction);
            
            if (nextCell != null)
            {
                GameObject newGO = new GameObject(' ' , GameObjectType.None);
                GameCell currentCell = gameObject.CurrentCell;
                
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
                
            }
        }

        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.rows; x++)
            {
                
                for (int y = 0; y < grid.colomns; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.y, cell.x);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

    }
}
