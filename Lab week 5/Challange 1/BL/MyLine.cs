using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1.BL
{
    class MyLine
    {
        public static double GetGradient()
        {
            double gradient = (end.y - begin.y) / (end.x - begin.x);
            return gradient;
        }
        public static double GetLength()
        {
            double distance = Math.Sqrt(Math.Pow(end.x - begin.x, 2) + Math.Pow(end.y - begin.y, 2));
            return distance;
        }
        public MyPoint GetEnd()
        {
            return end;
        }
        public MyPoint GetBegin()
        {
            return begin;
        }
        public void SetEnd(MyPoint e)
        {
            end = e;
        }
        public void SetBegin(MyPoint b)
        {
            begin = b;
        }
        
        public MyLine(MyPoint b , MyPoint e)
        {
            begin = b;
            end = e;
        }
        public static MyPoint begin;
        public static MyPoint end;

    }
}
