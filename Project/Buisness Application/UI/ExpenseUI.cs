﻿using Buisness_Application.BL;
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
            foreach (FinancialRecord i in Finance.GetFinancialRecordList())
            {
                if (i is Expense)
                {
                    Expense expenseRecord = (Expense)i;
                    count++;
                    Console.WriteLine("\t" + count + "." + i.GetBillName() + "\t\t" + i.GetAmount() + "\t\t" + expenseRecord.GetTax());
                } 
            }
            
        }
        public static Expense TakeInputForExpense()
        {
            Console.Write("\t Enter expense name: ");
            string name = Console.ReadLine();
            name = Validations.ValidateName(name);

            Console.Write("\t Enter amount: ");
            string amount = Console.ReadLine();
            amount = Validations.ValidateNumber(amount);


            Console.Write("\t Enter tax amount: ");
            string tax = Console.ReadLine();
            tax = Validations.ValidateNumber(tax);

            Expense e = new Expense(name, amount, tax , "Expense");
            return e;
        }
    }
}
