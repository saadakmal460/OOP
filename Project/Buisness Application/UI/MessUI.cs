using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class MessUI
    {

      
        public static void ViewMess()
        {
            Console.WriteLine("\t\tDay\t\t\tDish");
            foreach(Mess i in MessCRUD.menu)
            {
                Console.WriteLine("\t\t" + i.GetDay() + "\t\t\t" + i.GetDish());
            }
            Console.ReadKey();

        }

        public static bool UpdateMenu(string day)
        {
            bool flag = true;
            foreach (Mess i in MessCRUD.menu)
            {
                if(day == i.GetDay())
                {
                    Console.Write("\tEnter dish name: ");
                    string dish = Console.ReadLine();
                    dish = Validations.ValidateName(dish);
                    i.SetDish(dish);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static string TakeDayAsInput()
        {
            Console.Write("\tEnter day: ");
            string day = Console.ReadLine();
            return day;
        }
        public static string MessMenu()
        {
            Console.WriteLine("1.View Mess");
            Console.WriteLine("2.Update mess");
            string option = Console.ReadLine();
            return option;
        }
    }
}
