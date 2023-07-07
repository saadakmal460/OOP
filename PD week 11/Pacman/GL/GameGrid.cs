using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class GameGrid
    {
        public GameCell[,] gameCell;
        public int rows;
        public int colomns;


        public GameGrid(string fileName, int rows, int colomns)
        {
            this.rows = rows;
            this.colomns = colomns;
            gameCell = new GameCell[rows, colomns];
            this.LoadGrid(fileName);
        }

        private void LoadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record = "";
            int row = 0;

            while ((record = fp.ReadLine()) != null)
            {
                for (int i = 0; i < record.Count(); i++)
                {

                    GameCell cell = new GameCell(row, i, this);
                    GameObjectType type = GetGameObject(record[i]);
                    Image img = Game.GetImage(record[i]);
                    GameObject g = new GameObject(img, type);
                    cell.CurrentGameObject = g;
                    cell.setGameObject(g);
                    gameCell[row, i] = cell;

                }

                row++;
            }

            fp.Close();
        }


        public GameObjectType GetGameObject(char x)
        {
            GameObjectType type;
            if (x == 'p')
            {
                type = GameObjectType.Player;
            }
            else if (x == '.')
            {
                type = GameObjectType.Reward;
            }
            else if (x == 'G')
            {
                type = GameObjectType.Enemy;
            }
            else if (x == ' ')
            {
                type = GameObjectType.None;
            }
            else
            {
                type = GameObjectType.Wall;
            }

            return type;

        }
        public GameCell GetCell(int x, int y)
        {
            return gameCell[x, y];

        }
    }
}
