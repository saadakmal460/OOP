using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class GameGrid
    {
        public GameCell[,] gameCell;
        public int rows;
        public int colomns;

        public GameGrid(string fileName , int rows , int colomns)
        {
            this.rows = rows;
            this.colomns = colomns;
            
            gameCell = new GameCell[colomns , rows];
            LoadGrid(fileName);
        }

        private void LoadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record=  "";
            int row = 0;
            
            while((record = fp.ReadLine()) != null)
            {
                for(int i=0;i < record.Count(); i++)
                {
                    
                    GameCell cell = new GameCell(i, row);
                    GameObject g = GetGameObject(record[i]);

                    
                    gameCell[i , row] = cell;
                    
                    
                    gameCell[i , row].CurrentGameObject = g; 
                    
                    
                }
                row++;
            }

            fp.Close();
        }

        public GameObject GetGameObject(char x)
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
            GameObject g = new GameObject(x, type);
            return g;

        }
        public GameCell GetCell(int x , int y)
        {
            return gameCell[y ,x];
            
        }
    }
}
