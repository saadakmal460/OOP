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
            foreach (FinancialRecord i in Finance.GetFinancialRecordList())
            {
                if (i is Revenue)
                {
                    Revenue revenueRecord = (Revenue)i;
                    count++;
                    Console.WriteLine("\t" + count + "." + i.GetBillName() + "\t\t" + i.GetAmount() + "\t\t" + revenueRecord.GetExtraChargesRevenue());
                }
            }

        }
        public static Revenue TakeInputForRevenue()
        {
            Console.Write("\t Enter expense name: ");
            string name = Console.ReadLine();
            name = Validations.ValidateName(name);

            Console.Write("\t Enter amount: ");
            string amount = Console.ReadLine();
            amount = Validations.ValidateNumber(amount);


            Console.Write("\t Extra charge revenue include (Yes or No): ");
            string t = Console.ReadLine();
            t = Validations.ValidateChoice(t);

            Revenue e = new Revenue(name, amount, t, "Revenue");
            return e;
        }
    }
}
