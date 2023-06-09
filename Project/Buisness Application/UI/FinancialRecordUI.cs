﻿using Buisness_Application.BL;
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

        public static string TakeRecordName()
        {
            Console.WriteLine("Enter name of record which you want to delete: ");
            string name = Console.ReadLine();
            return name;
        }
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
            Console.WriteLine("\tTotal= " + FinancialRecordDL.CalculateTotalAmount(type));
            
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
            Console.WriteLine("\t 3.Exit");

            string opt = Console.ReadLine();
            return opt;
        }
        public static void ShowGraph()
        {

            char box = '\u2588';
            int expenses = FinancialRecordDL.CalculateDigits("Expense");
            int revenue = FinancialRecordDL.CalculateDigits("Revenue");


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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(10, 32 - i);
                Console.WriteLine(box);
                Console.ResetColor();
            }
            


            
            for (int i = 0; i < revenue; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(17, 32 - i);
                Console.WriteLine(box);
                Console.ResetColor();
            }

            Console.SetCursorPosition(42 , 28);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(box +" Revenue");
            Console.ResetColor();

            Console.SetCursorPosition(42, 30);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(box + " Expense");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
