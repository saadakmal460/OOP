using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class HosteliteUI
    {
        public static Hostelite TakeInputForHostelite()
        {
            Console.Write("\tEnter name: ");
            string name = Console.ReadLine();

            Console.Write("\tEnter roll number: ");
            string rollNumber = Console.ReadLine();

            Console.Write("\tEnter CNIC: ");
            string cnic = Console.ReadLine();

            Console.Write("\tEnter city: ");
            string city = Console.ReadLine();

            Console.Write("\tEnter password: ");
            string password = Console.ReadLine();

            Hostelite h = new Hostelite(name, cnic, city, rollNumber, password , "hostelite");
            return h;

        }

        public static bool UpdateRecord(string name)
        {
            bool flag = true;
            foreach(Hostelite i in HosteliteCRUD.hostelitesList)
            {
                if(i.GetUsername() == name)
                {
                    Console.Write("\tEnter roll number: ");
                    string rollNumber = Console.ReadLine();

                    Console.Write("\tEnter CNIC: ");
                    string cnic = Console.ReadLine();

                    Console.Write("\tEnter city: ");
                    string city = Console.ReadLine();

                    Console.Write("\tEnter password: ");
                    string password = Console.ReadLine();

                    i.SetRollNumber(rollNumber);
                    i.SetCnic(cnic);
                    i.SetCity(city);
                    i.SetPassword(password);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public static void ViewHostelites()
        {
            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Name\t\tRoll Number\t\tCNIC\t\t\tCity");
            foreach(Hostelite i in HosteliteCRUD.sortedList)
            {
                Console.WriteLine(i.GetUsername() + "\t\t" + i.GetRollNumber() + "\t\t\t" + i.GetCnic() + "\t\t" + i.GetCity());

            }
            Console.ReadKey();
        }

        public static string TakeNameAsInput()
        {
            Console.WriteLine("");
            Console.WriteLine("\t Enter name of hostelite: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void ShowMessage(bool flag)
        {
            Console.WriteLine("");
            if(flag)
            {
                Console.WriteLine("Operation sucessfull");
            }
            else
            {
               Console.WriteLine("No record found");
            }
            Console.ReadKey();
        }
    }
}
