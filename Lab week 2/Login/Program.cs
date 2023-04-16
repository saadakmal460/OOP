using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Credentials
    {
        public string name;
        public string password;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Credentials[] c = new Credentials[10];
  
            int option = 0;
            int count = 0;

            string name, password;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    c[count] =SignUp();
                    count++;
                }
                else if (option == 2)
                {
                    Console.Write("Enter username: ");
                    name = Console.ReadLine();

                    Console.Write("Enter password: ");
                    password = Console.ReadLine();

                    LogIn(name, password);

                }

            } while (option != 3);


        }


        
        static string Parsing(string record, int field)
        {
            int count = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    count++;
                }
                else if (count == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        static void LogIn(string userName , string pass)
        {
            int i = 0;
            bool flag = false;
            string path = "D:\\2nd Semester\\OOP\\Lab week 2\\Login\\user.txt";
            Credentials c2 = new Credentials();

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string password = Parsing(record, 2);

                    
                    c2.name = name;
                    c2.password = password;

                    if(c2.name == userName && c2.password == pass)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }

            if(flag == true)
            {
                Console.Write("Log in sucessful");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Log in failed");
                Console.ReadKey();
            }

           
        }







        static Credentials SignUp()
        {
            Credentials c = new Credentials();

            Console.Write("Enter username: ");
            c.name = Console.ReadLine();

            Console.Write("Enter password: ");
            c.password = Console.ReadLine();
            StoreData(c.name, c.password);
            return c;

        }


        static void StoreData(string name , string password)
        {
            string path = "D:\\2nd Semester\\OOP\\Lab week 2\\Login\\user.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
        }


        static int Menu()
        {
            int option;
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Sign In");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
