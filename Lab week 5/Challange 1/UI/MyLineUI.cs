using Challange_1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1.UI
{
    class MyLineUI
    {

        public static void ShowGradient()
        {
            double gradient = MyLine.GetGradient();
            Console.WriteLine("Gradient is: " + gradient);
            Console.ReadKey();
        }
        public static void ShowLength()
        {
            double length = MyLine.GetLength();
            Console.WriteLine("Length is: " + length);
            Console.ReadKey();
        }
        public static void ShowBegin()
        {
            Console.WriteLine(MyLine.begin.x + "  " + MyLine.begin.y);
            Console.ReadKey();
        }
        public static void ShowEnd()
        {
            Console.WriteLine(MyLine.end.x + "  " + MyLine.end.y);
            Console.ReadKey();

        }
        public static void UpdatePoint()
        {

            Console.WriteLine("Enter x: ");
            MyLine.begin.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            MyLine.begin.y = int.Parse(Console.ReadLine());

        }
        public static void UpdateEnd()
        {

            Console.WriteLine("Enter x: ");
            MyLine.end.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            MyLine.end.y = int.Parse(Console.ReadLine());

        }
        public void MakeLine()
        {
            MyPoint mp1 = new MyPoint();
            MyPoint mp2 = new MyPoint();


            Console.WriteLine("Enter x1: ");
            mp1.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1: ");
            mp1.y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2: ");
            mp2.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2: ");
            mp2.y = int.Parse(Console.ReadLine());

            MyLine ml = new MyLine(mp1, mp2);

        }
    }
}
