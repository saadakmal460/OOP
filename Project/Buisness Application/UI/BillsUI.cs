using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class BillsUI
    {
        public static Bills TakeInputForExpense()
        {
            Console.Write("\t Enter expense name: ");
            string name = Console.ReadLine();

            Console.Write("\t Enter amount: ");
            string amount = Console.ReadLine();

            Bills b = new Bills(name, amount , "Expense");
            return b;

        }

        public static Bills TakeInputForRevenue()
        {
            Console.Write("\t Enter revenue name: ");
            string name = Console.ReadLine();

            Console.Write("\t Enter amount: ");
            string amount = Console.ReadLine();

            Bills b = new Bills(name, amount, "Revenue");
            return b;
        }
        public static string BillsMenu()
        {
            Console.WriteLine("\t 1.Add an expense");
            Console.WriteLine("\t 2.View expenses");
            Console.WriteLine("\t 3.Remove an expense");

            string option = Console.ReadLine();
            return option;
        }

        public static void ShowExpense()
        { 
            int count = 0;
            
            Console.WriteLine("\tExpense\t\tAmount");
            foreach (Bills i in BillsCRUD.billsList)
            {
                if (i.GetBillType() == "Expense")
                {
                    count++;
                    Console.WriteLine("\t" + count + "." + i.GetBillName() + "\t\t" + i.GetAmount());
                }
            }
            
        }

        public static void ShowCalculatedExpenses()
        {
            int sum = 0;
            foreach (Bills i in BillsCRUD.billsList)
            {
                if (i.GetBillType() == "Expense")
                {
                    sum = sum + i.GetTotalAmount();
                }
            }
            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t\tTotal: " + sum);
        }

        public static int TakeInputForNumber()
        {
            Console.Write("\tWhich expense you want to delete , Enter its number: ");
            int i = int.Parse(Console.ReadLine());

            return i;
        }
    }
}
