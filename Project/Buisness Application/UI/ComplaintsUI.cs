using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class ComplaintsUI
    {
        public static Complaints TakeComplaints(string name)
        {
            Console.Write("\t Enter your complaint: ");
            
            string complaint = Console.ReadLine();
            

            Complaints c = new Complaints(name, complaint);
            return c;
        }

        public static void ViewComplaints()
        {
            Console.WriteLine("\t Complaints: ");
            foreach(Complaints i in Hostelite.GetComplaintsList())
            {
                Console.WriteLine("\t" + i.GetName() + ": " + i.GetComplaint());
            }
            Console.ReadKey();
        }
    }
}
