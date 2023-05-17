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
            topLeft = p1;

            topRight = p2;

            bottomLeft = p3;

            bottomRight = p4;
        }

        public Point topLeft;
        public Point topRight;
        public Point bottomLeft;
        public Point bottomRight;
        Point p1 = new Point();
        Point p2 = new Point(60 , 90);
        Point p3 = new Point(90, 0);
        Point p4 = new Point(90, 90);
    }
}
