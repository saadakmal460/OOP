using Challange_1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1.UI
{
    class MyPointUI
    {
        public static void DistanceOfBegin()
        {
            MyPoint mp = new MyPoint(MyLine.begin.x, MyLine.begin.y);
            double length = mp.DistanceFromZero();
            Console.WriteLine("Distance is: " + length);
            Console.ReadKey();
        }

        public static void DistanceOfEnd()
        {
            MyPoint mp = new MyPoint(MyLine.end.x, MyLine.end.y);
            double length = mp.DistanceFromZero();
            Console.WriteLine("Distance is: " + length);
            Console.ReadKey();
        }
    }
}
