using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class RevenueUI
    {
        public static void ShowRevenue()
        {
            int count = 0;
            Console.WriteLine("\tExpense\t\tAmount\t\tTax");
            foreach (Revenue i in RevenueCRUD.revenueList)
            {
                count++;
                Console.WriteLine("\t"+ count+ "."+ i.GetBillName() + "\t\t" + i.GetAmount() + "\t\t" + i.GetExtraChargesRevenue());
            }

        }
        public static Revenue TakeInputForRevenue()
        {
            Console.Write("\t Enter expense name: ");
            string name = Console.ReadLine();

            Console.Write("\t Enter amount: ");
            string amount = Console.ReadLine();

            Console.Write("\t Extra charge revenue include (Yes or No): ");
            string t = Console.ReadLine();

            Revenue e = new Revenue(name, amount, t, "Revenue");
            return e;
        }
    }
}
