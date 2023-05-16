using Self_Assesment_1.BL;
using Self_Assesment_1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1.UI
{
    class CoffeeShopUI
    {
        public MenuItem AddMenu()
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter type of item: ");
            string type = Console.ReadLine();

            Console.Write("Enter price of item: ");
            int price = int.Parse(Console.ReadLine());

            MenuItem m = new MenuItem(name, type, price);
            return m;
        }
    }
}
