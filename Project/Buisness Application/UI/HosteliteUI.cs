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

            Console.Write("\tAllot room number: ");
            string roomNumber = Console.ReadLine();

            Console.Write("\tEnter password: ");
            string password = Console.ReadLine();

            Hostelite h = new Hostelite(name, cnic, city, rollNumber, password , "hostelite",roomNumber);
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

            Console.WriteLine("Name\t\tRoll Number\t\tCNIC\t\t\tCity");
            foreach(Hostelite i in HosteliteCRUD.sortedList)
            {
                Console.WriteLine(i.GetUsername() + "\t\t" + i.GetRollNumber() + "\t\t\t" + i.GetCnic() + "\t\t" + i.GetCity());

            }
            Console.ReadKey();
        }

        public static void ViewHostelitesRooms()
        {

            Console.WriteLine("Name\t\tRoom NUmber");
            foreach (Hostelite i in HosteliteCRUD.sortedList)
            {
                Console.WriteLine(i.GetUsername() + "\t\t" + i.GetRoomNumber());

            }
            Console.ReadKey();
        }

        public static string TakeNameAsInput()
        {
            
            Console.Write("\t Enter name of hostelite: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string TakeRollNumberAsInput()
        {
            Console.WriteLine("");
            Console.Write("\t Enter roll number of hostelite: ");
            string rollNumber = Console.ReadLine();
            return rollNumber;
        }
        public static void ShowMessage(bool flag)
        {
            
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

        public static bool SearchByRollNumber(string rollNumber)
        {
            bool flag = true;
 
            Console.WriteLine("Name\t\tRoll Number\t\tCNIC\t\t\tCity");
            foreach (Hostelite i in HosteliteCRUD.hostelitesList)
            {
                if (rollNumber == i.GetRollNumber())
                {
                    Console.WriteLine(i.GetUsername() + "\t\t" + i.GetRollNumber() + "\t\t\t" + i.GetCnic() + "\t\t" + i.GetCity());
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }
        public static bool SearchByName(string name)
        {
            bool flag = true;

            Console.WriteLine("Name\t\tRoll Number\t\tCNIC\t\t\tCity");
            foreach (Hostelite i in HosteliteCRUD.hostelitesList)
            {
                if (name == i.GetUsername())
                {
                    Console.WriteLine(i.GetUsername() + "\t\t" + i.GetRollNumber() + "\t\t\t" + i.GetCnic() + "\t\t" + i.GetCity());
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            
            return flag;
           
        }
        public static string SearchHosteliteOption()
        {
            Console.WriteLine("\t 1.Search by name");
            Console.WriteLine("\t 2.Search by Roll Number");
            Console.WriteLine("\t 3.Exit");
            Console.Write("\t Enter ypur option: ");
            string option = Console.ReadLine();
            return option;
        }

        //public string HosteliteMenu()
        //{

        //}
    }
}
