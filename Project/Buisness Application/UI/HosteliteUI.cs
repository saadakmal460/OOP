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
            name = Validations.ValidateName(name);

            Console.Write("\tEnter roll number: ");
            string rollNumber = Console.ReadLine();
            rollNumber = Validations.ValidateRollNumber(rollNumber);

            Console.Write("\tEnter CNIC: ");
            string cnic = Console.ReadLine();
            cnic = Validations.ValidateCNIC(cnic);


            Console.Write("\tEnter city: ");
            string city = Console.ReadLine();
            city = Validations.ValidateCity(city);


            Console.Write("\tAllot room number: ");
            string roomNumber = Console.ReadLine();
            roomNumber = Validations.ValidateRoomNumber(roomNumber);


            Console.Write("\tEnter password: ");
            string password = Console.ReadLine();
            password = Validations.ValidatePassword(password);


            Hostelite h = new Hostelite(name, cnic, city, rollNumber, password , "hostelite", roomNumber);
            return h;

        }

        public static bool UpdateRecord(string name)
        {
            bool flag = true;
            foreach(User i in UserDL.GetUserList())
            {
                
                
                    if (i is Hostelite)
                    {
                    if (i.GetUsername() == name)
                    {
                        Hostelite h = (Hostelite)i;
                        Console.Write("\tEnter roll number: ");
                        string rollNumber = Console.ReadLine();
                        rollNumber = Validations.ValidateRollNumber(rollNumber);

                        Console.Write("\tEnter CNIC: ");
                        string cnic = Console.ReadLine();
                        cnic = Validations.ValidateCNIC(cnic);

                        Console.Write("\tEnter city: ");
                        string city = Console.ReadLine();
                        city = Validations.ValidateCity(city);

                        Console.Write("\tEnter password: ");
                        string password = Console.ReadLine();
                        password = Validations.ValidatePassword(password);


                        h.SetRollNumber(rollNumber);
                        h.SetCnic(cnic);
                        h.SetCity(city);
                        h.SetPassword(password);
                        flag = true;
                    }
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
            foreach(User i in UserDL.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    
                    Console.WriteLine(i.GetUsername() + "\t\t" + h.GetRollNumber() + "\t\t\t" + h.GetCnic() + "\t\t" + h.GetCity());
                }
            }
            Console.ReadKey();
        }

        public static void ViewHostelitesRooms()
        {

            Console.WriteLine("Name\t\tRoom NUmber");
            foreach (User i in UserDL.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    Console.WriteLine(i.GetUsername() + "\t\t" + h.GetRoomNumber());
                }
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
            foreach (User i in UserDL.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    
                    if (rollNumber == h.GetRollNumber())
                    {
                        Console.WriteLine(i.GetUsername() + "\t\t" + h.GetRollNumber() + "\t\t\t" + h.GetCnic() + "\t\t" + h.GetCity());
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
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
            bool flag = false;

            Console.WriteLine("Name\t\tRoll Number\t\tCNIC\t\t\tCity");
            foreach (User i in UserDL.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    if (name == i.GetUsername())
                    {
                        Console.WriteLine(i.GetUsername() + "\t\t" + h.GetRollNumber() + "\t\t\t" + h.GetCnic() + "\t\t" + h.GetCity());
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
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

        public static string ShowWarning()
        {
            Console.WriteLine("Once you removed your registration you will not be able to LogIn again!! Do you ant to continue Yes or No");
            string option = Console.ReadLine();
            return option;
        }

        public static string HosteliteMenu()
        {
            string option;
            Console.WriteLine("\t 1.View your information");
            Console.WriteLine("\t 2.View mess menu");
            Console.WriteLine("\t 3.Add a complaint");
            Console.WriteLine("\t 4.See notices");
            Console.WriteLine("\t 5.Pay fees");
            Console.WriteLine("\t 6.Check bills");
            Console.WriteLine("\t 7.Remove registration");
            Console.WriteLine("\t 8.Review");
            Console.WriteLine("\t 9.EXIT");

            Console.WriteLine();
            Console.Write("\tEnter your option: ");
            option = Console.ReadLine();
            return option;
        }
    }
}
