using Problem_4.BL;
using Problem_4.DL;
using Problem_4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                { 
                    Console.Clear();
                    RectangleUI r = new RectangleUI();
                    Rectangle rt = r.takeInput();
                    ShapeCRUD.AddInList(rt);
                }
                else if(option ==2)
                {
                    Console.Clear();
                    SquareUI sq = new SquareUI();
                    Square s = sq.takeInput();
                    ShapeCRUD.AddInList(s);
                }

                else if(option == 3)
                {
                    Console.Clear();
                    CircleUI c = new CircleUI();
                    Circle c1 = c.takeInput();
                    ShapeCRUD.AddInList(c1);
                }
                else if(option == 4)
                {
                    Console.Clear();
                    ShapeUI.showAll();
                }
            } while (option != 4);
        }

        static int Menu()
        {
            
            Console.WriteLine("1.Draw rectangle");
            Console.WriteLine("2.Draw square");
            Console.WriteLine("3.Draw circle");
            Console.WriteLine("4.Show areas");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter option: ");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
}
