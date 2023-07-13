﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    class GameEnemyRandom : GameEnemy
    {
        Random r = new Random();
        public GameEnemyRandom(char DisplayCharacter, GameCell cell, GameObjectType type, GameDirection direction) : base(DisplayCharacter, type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.CurrentCell = cell;
            this.direction = direction;
            this.GameObjectType = type;
        }

        public GameEnemyRandom(Image img, GameCell cell, GameObjectType type, GameDirection direction) : base(img, type)
        {
            this.Image = img;
            this.CurrentCell = cell;
            this.direction = direction;
            this.GameObjectType = type;
        }


        public override GameCell MoveGhost(GameGrid gameGrid)
        {

            int value = r.Next(4);
            GameCell currentCell = this.CurrentCell;
            if (value == 0)
            {
                GameCell next = gameGrid.getCell(CurrentCell.X - 1, CurrentCell.Y);

                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameClass.SetFlag();
                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    if (next != null)
                    {
                        currentCell.setGameObject(GameClass.getBlankGameObject());
                        CurrentCell = next;
                        return next;
                    }

                }
            }
            else if (value == 1)
            {
                GameCell next = gameGrid.getCell(CurrentCell.X + 1, CurrentCell.Y);
                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameClass.SetFlag();
                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    if (next != null)
                    {
                        currentCell.setGameObject(GameClass.getBlankGameObject());
                        CurrentCell = next;
                        return next;
                    }
                }
            }

            else if (value == 2)
            {
                GameCell next = gameGrid.getCell(CurrentCell.X, CurrentCell.Y - 1);

                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameClass.SetFlag();
                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    if (next != null)
                    {
                        currentCell.setGameObject(GameClass.getBlankGameObject());
                        CurrentCell = next;
                        return next;
                    }
                }
            }

            else if (value == 3)
            {
                GameCell next = gameGrid.getCell(CurrentCell.X, CurrentCell.Y + 1);
                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameClass.SetFlag();
                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    if (next != null)
                    {
                        currentCell.setGameObject(GameClass.getBlankGameObject());
                        CurrentCell = next;
                        return next;
                    }
                }
            }

            return null;
        }
    }
}
