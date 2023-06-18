using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class FinanceUI
    {

        public static Finance TakeInputForFinanceEmployeee()
        {
            Console.Write("\tEnter name: ");
            string name = Console.ReadLine();
            name = Validations.ValidateName(name);

            Console.Write("\tEnter employee number: ");
            string EmployeeNumber = Console.ReadLine();
            EmployeeNumber = Validations.ValidateEmployeeNumber(EmployeeNumber);

            Console.Write("\tEnter password: ");
            string password = Console.ReadLine();
            password = Validations.ValidatePassword(password);

            Finance f = new Finance(name, password, "Finance", EmployeeNumber);
            return f;
        }
        public static string FinanceMenu()
        {
            string option;

            Console.WriteLine("\t 1.Expenses");
            Console.WriteLine("\t 2.Calculate expenses");
            Console.WriteLine("\t 3.Revenue");
            Console.WriteLine("\t 4.Generate challans");
            Console.WriteLine("\t 5.Check student fees");
            Console.WriteLine("\t 6.View financial report");
            Console.WriteLine("\t 7.See notices");
            Console.WriteLine("\t 8.EXIT");

            Console.WriteLine();
            Console.Write("\tEnter your option: ");
            option = Console.ReadLine();
            return option;
        }

        public static void ShowBills()
        {
            Console.WriteLine("\tMess\t\tLaundaray\t\tSecurity fees\t\tOthers");
            Console.WriteLine("\t10000\t\t3000\t\t\t2500\t\t\t10000");
            Console.ReadKey();
        }
    }
}
