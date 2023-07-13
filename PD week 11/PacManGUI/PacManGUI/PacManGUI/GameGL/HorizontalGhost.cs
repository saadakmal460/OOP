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
        GameObject previousGameObject;
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
            previousGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox);
        }

        public override GameCell MoveGhost(GameGrid grid)
        {
            GameCell currentCell = this.CurrentCell;
            
            if (direction == GameDirection.Left)
            {
                GameCell nextCell = grid.getCell(CurrentCell.X, CurrentCell.Y - 1);


                

                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    nextCell.CurrentGameObject.GameObjectType = GameObjectType.NONE;
                    Game.SetFlag(true);
                }
                if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {

                    if (nextCell != null)
                    {
                        currentCell.setGameObject(previousGameObject);
                        this.previousGameObject = nextCell.CurrentGameObject;
                        CurrentCell = nextCell;

                        return nextCell;
                    }

                }
                
                
                else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                {
                    direction = GameDirection.Right;
                }
            }

            if (direction == GameDirection.Right)
            {
                GameCell nextCell = grid.getCell(CurrentCell.X, CurrentCell.Y + 1);

                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    nextCell.CurrentGameObject.GameObjectType = GameObjectType.NONE;
                    Game.SetFlag(true);
                }
                if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    
                    if (nextCell != null)
                    {
                        currentCell.setGameObject(previousGameObject);
                        this.previousGameObject = nextCell.CurrentGameObject;
                        CurrentCell = nextCell;

                        return nextCell;
                    }


                }
                
                else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                {

                    direction = GameDirection.Left;
                }

            }

            
            return null;


        }

       
        
    }
}
