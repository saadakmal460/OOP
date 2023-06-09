﻿using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class PayFeeUI
    {
        public static bool TakeInputForPayFee()
        {
            bool flag = true;
            bool flag2 = false;
            
            
            Console.Write("\t Enter bank name: ");
            string bank = Console.ReadLine();
            bank = Validations.ValidateName(bank);

            Console.Write("\t Enter account number: ");
            string acc = Console.ReadLine();
            acc = Validations.ValidateAccountNumber(acc);

            Console.Write("\t Enter challan Number: ");
            string challan = Console.ReadLine();

            Console.Write("Enter amount: ");
            string amount = Console.ReadLine();
            while (true)
            {
                foreach (Challan i in Finance.GetChallanList())
                {
                    if(i.GetChallanNumber() == challan && i.GetAmount() == amount)
                    {
                        flag = true;
                        i.SetStatus("Paid");
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                if(!flag)
                {
                    Console.Write("Error enter again Challan Number");
                    challan = Console.ReadLine();

                    Console.Write("Enter amount: ");
                    amount = Console.ReadLine();
                }
                else
                {
                    
                    break;
                }
            }
            PayFee f = new PayFee(bank, acc, challan, amount);
            return flag;
            
            

        }
    }
}
