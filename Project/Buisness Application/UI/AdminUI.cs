using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class AdminUI
    {
        public static Admin TakeInputForAdmin()
        {
            Console.Write("\tEnter name: ");
            string name = Console.ReadLine();

            Console.Write("\tEnter password: ");
            string password = Console.ReadLine();

            Console.Write("\tEnter contact number: ");
            string conatct = Console.ReadLine();

            Admin a = new Admin(name, password, conatct, "admin");
            return a;
        }
        public static string PrintMenuForAdmin()
        {
            Console.WriteLine("\t 1.Add a hostelite");
            Console.WriteLine("\t 2.Remove hostelite");
            Console.WriteLine("\t 3.Update record");
            Console.WriteLine("\t 4.View hostelite");
            Console.WriteLine("\t 5.Notice board");
            Console.WriteLine("\t 6.View Complaints");
            Console.WriteLine("\t 7.Mess Information");
            Console.WriteLine("\t 8.Payment records");
            Console.WriteLine("\t 9.View alloted rooms");
            Console.WriteLine("\t 10.Search hostelite");
            Console.WriteLine("\t 11.View reviews and ratings");
            Console.WriteLine("\t 12.Add an offical");
            Console.WriteLine("\t 13.Exit");
            Console.Write(" \tEnter option: ");
            string option = Console.ReadLine();
            return option;

        }
        public static string OfficalMenu()
        {
            Console.WriteLine("\t 1.Add an Admin");
            Console.WriteLine("\t 2.Add a finance officer");
            Console.WriteLine("\t 3.Exit");
            Console.Write("\t Enter option: ");
            string option = Console.ReadLine();
            return option;
        }
        public static string NoticeMenu()
        {
            Console.WriteLine("\t 1.Add a notice");
            Console.WriteLine("\t 2.Remove notice");
            Console.WriteLine("\t 3.View notice");
            Console.WriteLine("\t 4.Exit");
            Console.Write(" \tEnter option: ");
            string option = Console.ReadLine();
            return option;
        }

        
    }
}
