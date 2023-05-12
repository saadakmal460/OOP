using Challange_1.BL;
using Challange_1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
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
                MyLineUI ml = new MyLineUI();
               
                if (option == 1)
                {
                    Console.Clear();
                    ml.MakeLine();
                }
                else if(option == 2)
                {
                    Console.Clear();
                    MyLineUI.UpdatePoint();
                }
                else if(option == 3)
                {
                    Console.Clear();
                    MyLineUI.UpdateEnd();
                }
                else if (option == 4)
                {
                  
                    Console.Clear();
                    MyLineUI.ShowBegin();
                }
                else if (option == 5)
                {
                    Console.Clear();
                    MyLineUI.ShowEnd();
                }
                else if(option == 6)
                {
                    
                    Console.Clear();
                    MyLineUI.ShowLength();
                }
                else if(option == 7)
                {
                    Console.Clear();
                    MyLineUI.ShowGradient();
                }
                else if(option == 8)
                {
                    Console.Clear();
                    MyPointUI.DistanceOfBegin();


                }
                else if(option == 9)
                {
                    Console.Clear();
                    MyPointUI.DistanceOfEnd();
                  
                }
                

            } while (option != 10);


        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.Make a line");
            Console.WriteLine("2.Update begin point");
            Console.WriteLine("3.Update end point");
            Console.WriteLine("4.Show begin point");
            Console.WriteLine("5.Show end point");
            Console.WriteLine("6.Get length of line");
            Console.WriteLine("7.Get gradient of line");
            Console.WriteLine("8.Find distance of begin point form zero");
            Console.WriteLine("9.Find distance of end point form zero");
            Console.WriteLine("Enter option: ");
            option = int.Parse(Console.ReadLine());
            return option;



        }
    }
}
