using Problem_4.BL;
using Problem_4.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.UI
{
    class ShapeUI
    {
        public static void displayArea()
        {
            foreach (Shape i in ShapeCRUD.s)
            {
                Console.WriteLine(i.calculateArea());
            }
        }
        public static void showAll()
        {
            foreach(Shape i in ShapeCRUD.s)
            {
                Console.WriteLine(i.toString());
            }
            Console.ReadKey();
        }
    }
}
