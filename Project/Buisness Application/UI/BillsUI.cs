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
            Console.WriteLine("\t 4.Exit");
            Console.Write("\t Enter option: ");
            string option = Console.ReadLine();
            return option;
        }

        public static string RevenueMenu()
        {
            Console.WriteLine("\t 1.Add an revenue");
            Console.WriteLine("\t 2.View revenues");
            Console.WriteLine("\t 3.Remove an revenue");
            Console.WriteLine("\t 4.Exit");
            Console.Write("\t Enter option: ");

            string option = Console.ReadLine();
            return option;
        }

        public static void Show(string type)
        { 
            int count = 0;
            
            Console.WriteLine("\tExpense\t\tAmount");
            foreach (Bills i in BillsCRUD.billsList)
            {
                if (i.GetBillType() == type)
                {
                    count++;
                    Console.WriteLine("\t" + count + "." + i.GetBillName() + "\t\t" + i.GetAmount());
                }
            }
            
        }
        public static string ReportMenu()
        {
            Console.WriteLine("\t 1.View financial report");
            Console.WriteLine("\t 2.View graphical analysis");
            Console.WriteLine("\t 3.Exit");

            Console.Write("\t Enter option: ");

            string option = Console.ReadLine();
            return option;

        }

        public static void ShowFinancialReport()
        {
            Console.WriteLine("Expenses: ");
            Show("Expense");
            ShowCalculated("Expense");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Revenue: ");
            Show("Revenue");
            ShowCalculated("Revenue");
        }

        public static void ShowCalculated(string type)
        {
            int sum = 0;
            
            foreach (Bills i in BillsCRUD.billsList)
            {
                if (i.GetBillType() == type)
                {
                    sum = i.GetTotalAmount(sum);
                    
                }
            }
            
            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t\tTotal: " + sum);
            
            
        }

        public static int Digits(string type)
        {
            int sum = 0;
            int count = 0;
            foreach (Bills i in BillsCRUD.billsList)
            {
                if (i.GetBillType() == type)
                {
                    sum = i.GetTotalAmount(sum);
                    count = i.GetAmountDigits(sum);
                }
            }
            
            
            return count;
        }
        
        public static int TakeInputForNumber()
        {
            Console.Write("\tWhich expense you want to delete , Enter its number: ");
            int i = int.Parse(Console.ReadLine());

            return i;
        }

        public static void ShowGraph()
        {

            char box = '\u2588';
            int expenses = Digits("Expense");
            int revenue = Digits("Revenue");
            
            
            Console.WriteLine("    |                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine("  1M|                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine("100k|                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine(" 10k|                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine("  1k|                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine("    |                         ");
            Console.WriteLine("    |___________________________________");

            for (int i = 0; i < expenses; i++)
            {
                Console.SetCursorPosition(10, 32 - i);
                Console.WriteLine(box);
            }

            for (int i = 0; i < revenue; i++)
            {
                Console.SetCursorPosition(17, 32 - i);
                Console.WriteLine(box);
            }

           

            Console.ReadKey();
        }
    }
}
