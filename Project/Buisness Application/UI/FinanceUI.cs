using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class FinanceUI
    {
        public static string FinanceMenu()
        {
            string option;

            Console.WriteLine("\t 1.Expenses");
            Console.WriteLine("\t 2.Calculate expenses");
            Console.WriteLine("\t 3.Revenue");
            Console.WriteLine("\t 4.Generate challans");
            Console.WriteLine("\t 5.Check student fees");
            Console.WriteLine("\t 6.View financial report");
            Console.WriteLine("\t 7.Transfer salaries");
            Console.WriteLine("\t 8.See notices");
            Console.WriteLine("\t 9.EXIT");

            Console.WriteLine();
            Console.Write("\tEnter your option: ");
            option = Console.ReadLine();
            return option;
        }
    }
}
