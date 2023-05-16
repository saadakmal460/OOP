﻿using Self_Assesment_1.BL;
using Self_Assesment_1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1.UI
{
    class MenuItemUI
    {
        public void ViewFood()
        {
            Console.WriteLine("Item\t\tType\t\tPrice");
            foreach (MenuItem i in CoffeeShopCRUD.menu)
            {
                if (i.type.ToLower() == "food")
                {
                    Console.WriteLine(i.item + "\t\t" + i.type + "\t\t" + i.price);
                }
            }
            Console.ReadKey();
        }
        public void ViewDrinks()
        {
            Console.WriteLine("Item\t\tType\t\tPrice");
            foreach (MenuItem i in CoffeeShopCRUD.menu)
            {
                if (i.type.ToLower() == "drink")
                {
                    Console.WriteLine(i.item + "\t\t" + i.type + "\t\t" + i.price);
                }
            }
            Console.ReadKey();
        }
        public void ViewCheapestItem(int cheapest)
        {
            Console.WriteLine("Item\t\tType\t\tPrice");
            foreach (MenuItem i in CoffeeShopCRUD.menu)
            {
                if (i.price == cheapest)
                {
                    Console.WriteLine(i.item + "\t\t" + i.type + "\t\t" + i.price);
                }
            }
            Console.ReadKey();
        }
    }
}
