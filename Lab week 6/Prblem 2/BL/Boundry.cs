using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prblem_2.BL
{
    class Boundry
    {
        public Boundry(Point topLeft , Point topRight , Point bottomLeft , Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
        public Boundry()
        {
            topLeft = new Point();

            topRight = new Point(30, 90);

            bottomLeft = new Point(90, 0);

            bottomRight = new Point(90, 90);
        }

        public Point topLeft;
        public Point topRight;
        public Point bottomLeft;
        public Point bottomRight;
        
    }
}
