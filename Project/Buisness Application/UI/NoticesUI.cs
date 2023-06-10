using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class NoticesUI
    {
        public static void ViewNotices()
        {
            int count = 0;
            Console.WriteLine("");
            Console.WriteLine("Notices: ");
            foreach (Notices i in NoticesCRUD.notices)
            {
                count++;
                Console.WriteLine("");
                Console.WriteLine("\t" + count + "."+ i.GetTitle() + ": " + i.GetNotice());
            }

        }
        public static Notices TakeInputForNotices()
        {
            string notice = "";

            Console.Write("\t\t Enter title of notice: ");
            string tilte = Console.ReadLine();
            Console.Write("\t\tEnter your notice: ");
            notice = Console.ReadLine();

            Notices n = new Notices(tilte, notice);
            return n;
        }

        public static int TakeInputToDeleteNotice()
        {

            Console.Write("\t\tWhich notice you want to delete: ");
            int i = int.Parse(Console.ReadLine());
            return i;
        }
    }
}
