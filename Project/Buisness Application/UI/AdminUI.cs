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
            Console.WriteLine("\t 9.Allot rooms");
            Console.WriteLine("\t 10.Exit");
            Console.Write(" \tEnter option: ");
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
