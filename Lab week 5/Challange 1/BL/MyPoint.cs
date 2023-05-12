using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1.BL
{
    class MyPoint
    {
        public double DistanceFromObject(MyPoint another)
        {
            double distance = Math.Sqrt(Math.Pow(another.x - x, 2) + Math.Pow(another.y - y, 2));
            return distance;
        }
        public double DistanceFromCoord(int x2 , int y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
            return distance;
        }
        public double DistanceFromZero()
        {
            double distance = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
            return distance;
        }
        public int GetY()
        {
            return y;
        }
        public int GetX()
        {
            return x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public MyPoint(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public int x;
        public int y;
    }
}
