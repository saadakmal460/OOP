using Self_Assesment_1.BL;
using Self_Assesment_1.DL;
using Self_Assesment_1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int option = 0;
            CoffeeShopUI c = new CoffeeShopUI();
            MenuItemUI menu = new MenuItemUI();
            OrdersUI u = new OrdersUI();
            do
            {
                Console.Clear();
                option = CoffeeMenu();
                if(option == 1)
                {
                    Console.Clear();
                    MenuItem m = c.AddMenu();
                    CoffeeShopCRUD.AddInList(m);
                }

                else if(option == 2)
                {
                    Console.Clear();
                    int cheapest = CoffeeShopCRUD.CheapestItem();
                    menu.ViewCheapestItem(cheapest);
                }

                else if(option == 3)
                {
                    Console.Clear();
                    menu.ViewDrinks();
                }

                else if(option == 4)
                {
                    Console.Clear();
                    menu.ViewFood();
                }

                else if(option == 5)
                {
                    Console.Clear();
                    Orders o = u.TakeOrders();
                    OrdersCRUD.AddInList(o);
                }

                else if(option == 6)
                {
                    Console.Clear();
                    u.FullFillOrder();
                }

                else if(option == 7)
                {
                    Console.Clear();
                    u.ViewOrders();
                }

                else if(option == 8)
                {
                    Console.Clear();
                    u.DueAmount();
                }

            } while (option != 9);
        }

        static int CoffeeMenu()
        {
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View cheapest item in menu");
            Console.WriteLine("3.View drinks's menu");
            Console.WriteLine("4.View food's menu");
            Console.WriteLine("5.Add order");
            Console.WriteLine("6.Fulfill the order");
            Console.WriteLine("7.View order list");
            Console.WriteLine("8.Total payable amount");
            Console.WriteLine("9.Exit");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
}
