using Buisness_Application.BL;
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
            

            foreach (Hostelite i in UserDL.GetUserList())
            {
                if (rollNumber == i.GetRollNumber())
                {
                    flag = true;
                    break;
                }
            }

            flag2 = ChallanDL.CheckInChallanList(rollNumber);

            if (flag && !flag2)
            {
                Console.Write("\t Enter challan number: ");
                challan = Console.ReadLine();
                challan = Validations.ValidateChallan(challan);

                Console.Write("\t Enter amount: ");
                amount = Console.ReadLine();
                amount = Validations.ValidateNumber(amount);
            }
            else if (flag && flag2)
            {
                Console.Write("\t Enter challan number: ");
                challan = Console.ReadLine();
                challan = Validations.ValidateChallan(challan);


                Console.Write("\t Enter  amount: ");
                amount = Console.ReadLine();
                amount = Validations.ValidateNumber(amount);

                // Update existing challan
                foreach (Challan i in ChallanDL.challanList)
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

            Challan c = new Challan(rollNumber, challan, amount , "Pending");
            return c;
        }

        

        public static void ShowFee()
        {
            Console.WriteLine("Roll Number\t\tStatus");
            foreach(Challan i in ChallanDL.challanList)
            {
                Console.WriteLine(i.GetRollNumber() + "\t\t\t" + i.GetStatus());
            }
            Console.ReadKey();
        }

        
    }
}
