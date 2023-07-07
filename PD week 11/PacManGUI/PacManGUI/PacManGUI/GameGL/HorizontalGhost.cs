using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGUI.GameGL
{
    class HorizontalGhost : Ghost
    {
        public HorizontalGhost(char DisplayCharacter, GameCell cell, GameObjectType type, GameDirection direction) : base(DisplayCharacter, type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.CurrentCell = cell;
            this.direction = direction;
            this.GameObjectType = type;
        }

        public HorizontalGhost(Image img, GameCell cell, GameObjectType type, GameDirection direction) : base(img, type)
        {
            this.Image = img;
            this.CurrentCell = cell;
            this.direction = direction;
            this.GameObjectType = type;
        }

        public GameCell CheckCell(GameGrid grid)
        {

            if (direction == GameDirection.Left)
            {
                GameCell next = grid.getCell(CurrentCell.X, CurrentCell.Y - 1);
                
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    return next;
                }
                else if (next.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                {
                    direction = GameDirection.Right;
                }
            }

            if (direction == GameDirection.Right)
            {
                GameCell next = grid.getCell(CurrentCell.X, CurrentCell.Y + 1);
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    return next;
                }
                else if (next.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                {

                    direction = GameDirection.Left;
                }

            }

            return null;


        }

        public override GameCell MoveGhost(GameGrid grid)
        {
            GameCell nextCell = CheckCell(grid);
            GameCell currentCell = this.CurrentCell;
            if (nextCell != null)
            {
                currentCell.setGameObject(Game.getCurrentObject(nextCell));
                CurrentCell = nextCell;
            }
            return nextCell;
        }
        
    }
}
