﻿using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class ChallanUI
    {
        public static Challan TakeChallanInput(string rollNumber)
        {
            bool flag = false;
            bool flag2 = false;
            string challan = "", amount = "";
            

            foreach (Hostelite i in HosteliteCRUD.hostelitesList)
            {
                if (rollNumber == i.GetRollNumber())
                {
                    flag = true;
                    break;
                }
            }

            flag2 = CheckInChallanList(rollNumber);

            if (flag && !flag2)
            {
                Console.Write("\t Enter challan number: ");
                challan = Console.ReadLine();

                Console.Write("\t Enter amount: ");
                amount = Console.ReadLine();
            }
            else if (flag && flag2)
            {
                Console.Write("\t Enter challan number: ");
                challan = Console.ReadLine();

                Console.Write("\t Enter  amount: ");
                amount = Console.ReadLine();

                // Update existing challan
                foreach (Challan i in ChallanCRUD.challanList)
                {
                    if (rollNumber == i.GetRollNumber())
                    {
                        i.SetChallanNumber(challan);
                        i.SetAmount(amount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No record found");
            }

            Challan c = new Challan(rollNumber, challan, amount);
            return c;
        }

        public static bool CheckInChallanList(string rollNumber)
        {
            bool flag2 = false;
            foreach (Challan i in ChallanCRUD.challanList)
            {
                if (rollNumber == i.GetRollNumber())
                {
                    flag2 = true;
                    break;
                }
            }
            return flag2;
        }

    }
}
