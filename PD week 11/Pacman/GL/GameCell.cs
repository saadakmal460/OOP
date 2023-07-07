using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman.GL
{
    class GameCell
    {
        public int x;
        public int y;
        public GameObject CurrentGameObject;
        public GameGrid gameGrid;
        const int height = 20;
        const int width = 20;
        public PictureBox pb;
        public GameCell(int x, int y, GameGrid gameGrid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = gameGrid;
            pb = new PictureBox();
            pb.Height = height;
            pb.Width = width;
            pb.Left = width * y;
            pb.Top = height * x;
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void setGameObject(GameObject gameObject)
        {
            CurrentGameObject = gameObject;
            pb.Image = gameObject.charcter;

        }

        public GameCell NextCell(GameDirection gameDirection)
        {
            if (GameDirection.Up == gameDirection)
            {
                if (this.x > 0)
                {
                    GameCell next = gameGrid.GetCell(this.x - 1, this.y);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
            }
            else if (GameDirection.Down == gameDirection)
            {
                if (this.x < gameGrid.rows - 1)
                {
                    GameCell next = gameGrid.GetCell(this.x + 1, this.y);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
            }
            else if (GameDirection.Left == gameDirection)
            {
                if (this.y > 0)
                {
                    GameCell next = gameGrid.GetCell(this.x, this.y - 1);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }

            }
            else if (GameDirection.Right == gameDirection)
            {
                if (this.y < gameGrid.colomns - 1)
                {
                    GameCell next = gameGrid.GetCell(this.x, this.y + 1);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
            }

            return this;
        }
    }
}
