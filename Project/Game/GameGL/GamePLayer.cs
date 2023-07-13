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
        
        public GamePLayer(Image image , GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction)
        {

            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                GameClass.AddScore();

            }

            this.CurrentCell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(GameClass.getBlankGameObject());
            }


            return nextCell;
        }
    }
}
