using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class Game
    {
        public static GameObject GetBlank()
        {
            GameObject g = new GameObject(Properties.Resources.simplebox, GameObjectType.None);
            return g;
        }
        public static Image GetImage(char x)
        {
            Image i = null;
            if (x == 'p' || x == 'P')
            {
                i = Properties.Resources.pacman_open;
            }
            else if (x == '.')
            {
                i = Properties.Resources.pallet;

            }
            else if (x == ' ')
            {
                i = Properties.Resources.simplebox;

            }
            else if (x == '|')
            {
                i = Properties.Resources.vertical;
            }
            else if (x == '%' || x == '#')
            {
                i = Properties.Resources.horizontal;
            }

            return i;
        }
    }
}
