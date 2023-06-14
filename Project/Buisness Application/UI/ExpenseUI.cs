using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class ExpenseUI
    {
        public static void ShowExpense()
        {
            int count = 0;
            Console.WriteLine("\tExpense\t\tAmount\t\tTax");
            foreach (Expense i in ExpenseCRUD.expenseList)
            {
                count++;
                Console.WriteLine("\t" + count + "." + i.GetBillName()+ "\t\t" + i.GetAmount() + "\t\t" + i.GetTax());
            }
            
        }
        public static Expense TakeInputForExpense()
        {
            Console.Write("\t Enter expense name: ");
            string name = Console.ReadLine();

            Console.Write("\t Enter amount: ");
            string amount = Console.ReadLine();

            Console.Write("\t Enter tax amount: ");
            string tax = Console.ReadLine();

            Expense e = new Expense(name, amount, tax , "Expense");
            return e;
        }
    }
}
