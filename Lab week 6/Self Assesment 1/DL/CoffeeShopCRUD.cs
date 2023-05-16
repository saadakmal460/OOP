using Self_Assesment_1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1.DL
{
    class CoffeeShopCRUD
    {

        public static int CheapestItem()
        {
            int cheapest = 100000;
            foreach (MenuItem i in menu)
            {
                if(i.price < cheapest)
                {
                    cheapest = i.price;
                }
            }
            return cheapest;
        }
        public static void AddInList(MenuItem m)
        {
            menu.Add(m);
        }

        public static List<MenuItem> menu = new List<MenuItem>();
    }
}
