using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    class GamePLayer : GameObject
    {
        bool flag = true;
        public GamePLayer(Image image , GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
            flag = true;
        }
        public GameCell move(GameDirection direction)
        {

            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                GameClass.AddScore();

            }

            if (CurrentCell.CurrentGameObject.GameObjectType == GameObjectType.EnemyFire)
            {
                SetPlayerFlag(false);

            }

            this.CurrentCell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(GameClass.getBlankGameObject());
            }


            return nextCell;
        }

        public void SetPlayerFlag(bool flag)
        {
            this.flag = flag;
        }
        public bool GetFlag()
        {
            return flag;
        }
    }
}
