using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class FinancialRecordUI
    {
        public static void ShowFinancialReprt()
        {
            ExpenseUI.ShowExpense();
            ShowCalculatedAmount("Expense");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("");
            RevenueUI.ShowRevenue();
            ShowCalculatedAmount("Revenue");
            Console.ReadKey();
        }
        public static void ShowCalculatedAmount(string type)
        {
            Console.WriteLine("\t__________________________________");
            Console.WriteLine("\tTotal= " + FinancialRecordCRUD.CalculateTotalAmount(type));
            
        }
        public static int TakeInputForNumber()
        {
            Console.Write("\tWhich expense you want to delete , Enter its number: ");
            int i = int.Parse(Console.ReadLine());

            return i;
        }
        public static string FinancialRecordMenu(string type)
        {
            Console.WriteLine("\t 1.Add an " + type);
            Console.WriteLine("\t 2.View " + type);
            Console.WriteLine("\t 3.Remove an " + type);
            Console.WriteLine("\t 4.Exit");
            Console.Write("\t Enter option: ");
            string option = Console.ReadLine();
            return option;
        }

        public static string ShowMenu()
        {
            Console.WriteLine("\t 1.Show Financial report");
            Console.WriteLine("\t 2.Show Graphical analysis");
            string opt = Console.ReadLine();
            return opt;
        }
        public static void ShowGraph()
        {

            char box = '\u2588';
            int expenses = FinancialRecordCRUD.CalculateDigits("Expense");
            int revenue = FinancialRecordCRUD.CalculateDigits("Revenue");


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
