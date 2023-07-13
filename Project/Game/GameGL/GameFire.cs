using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.GameGL
{
    class GameFire : GameObject
    {
        GameDirection direction;
        bool flag = true;
        bool flag2 = true;
        public GameFire(char DisplayCharacter, GameObjectType type, GameCell cell) : base(type, DisplayCharacter)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.GameObjectType = type;
        }

        public GameFire(Image img, GameObjectType type, GameDirection direction, GameCell cell) : base(type, img)
        {
            this.CurrentCell = cell;
            this.direction = direction;
            this.GameObjectType = type;
            this.Image = img;
        }



        public GameCell MoveEnemyFire(GameGrid grid)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = grid.getCell(CurrentCell.X + 1, CurrentCell.Y);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                GameClass.SetFlag();
            }
            if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                if (nextCell != null)
                {

                    currentCell.setGameObject(GameClass.getBlankGameObject());
                    CurrentCell = nextCell;
                    return nextCell;
                }
            }

            
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                SetFlag();

            }
            return null;

        }
        public GameCell MovePlayerFire(GameGrid grid)
        {
            GameCell currentCell = this.CurrentCell;

            GameCell nextCell = grid.getCell(CurrentCell.X - 1, CurrentCell.Y);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                GameClass.SetFlag();
            }
            if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                if (nextCell != null)
                {

                    currentCell.setGameObject(GameClass.getBlankGameObject());
                    CurrentCell = nextCell;
                    return nextCell;
                }


            }

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                SetFlag();
                
            }
            
            return null;


        }

        public void SetFlag2()
        {
            flag2 = false;
        }
        public bool GetFlag2()
        {
            return flag2;
        }

        public void SetFlag()
        {
            flag = false;
        }
        public bool GetFlag()
        {
            return flag;
        }

    }
}
