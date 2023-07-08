﻿using PacMan.GameGL;
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
        GameCell previous;
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

        public override GameCell MoveGhost(GameGrid grid)
        {
            GameCell currentCell = this.CurrentCell;
            
            if (direction == GameDirection.Left)
            {
                GameCell nextCell = grid.getCell(CurrentCell.X, CurrentCell.Y - 1);
                

                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    Game.SetFlag();
                }
                if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                   
                    if (nextCell != null)
                    {
                        
                        currentCell.setGameObject(Game.getCurrentObject(nextCell));
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
                    Game.SetFlag();
                }
                if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    if (nextCell != null)
                    {
                       
                        currentCell.setGameObject(Game.getCurrentObject(nextCell));
                        CurrentCell = nextCell;
                        return nextCell;
                    }
                    if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                    {
                        Game.SetFlag();
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
