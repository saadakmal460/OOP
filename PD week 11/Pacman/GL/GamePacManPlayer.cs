using System;
using System.Collections.Generic;
using System.Drawing;
using Pacman.GL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(char displayCharacter, GameCell CurrentCell, GameObjectType type) : base(displayCharacter, type)
        {
            this.DisplayCharacter = displayCharacter;
            this.CurrentCell = CurrentCell;
            this.type = type;
        }

        public GamePacManPlayer(Image character, GameCell CurrentCell) : base(character, GameObjectType.Player)
        {
            this.CurrentCell = CurrentCell;
        }

        public GameCell Move(GameDirection direction)
        {
            return this.CurrentCell.NextCell(direction);
        }

        public GameCell MovePacman(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.GetBlank());

            }
            return nextCell;

        }
    }
}
