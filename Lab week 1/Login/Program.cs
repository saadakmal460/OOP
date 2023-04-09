using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string name , password;
            string[] userName = new string[10];
            string[] pass = new string[10];
            int count = 0;
            string path = "D:\\2nd Semester\\OOP\\Lab week 1\\Login\\User.txt";
            Load(userName, pass, path);
            int option = 0;
           
            while (option != 3)
            {
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    SignIN(userName , pass);
                }

                if (option == 2)
                {
                    Console.Clear();
                    Console.Write("Enter username: ");
                    name = Console.ReadLine();

                    Console.Write("Enter username: ");
                    password = Console.ReadLine();
                    SignUp(path, name, password);
                    Data(name, password, userName, pass, count);
              
                }
            } 
            
            Console.ReadKey();

        }

        static int Menu()
        {
            int option = 0;
            Console.WriteLine("\t1.SignIn");
            Console.WriteLine("\t2.SignUp");
            Console.WriteLine("\t3.Exit");
            Console.WriteLine("\tEnter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void Data(string name, string password , string[] username , string[] pass , int count)
        {
            name = username[count];
            password = pass[count];
            count++;
        }

        static void SignUp(string path , string name , string password)
        {
            
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();

        }


        static string Parsing(string record , int field)
        {
            int count = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    count++;
                }
                else if(count == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        static void Load(string[] name , string[] pass , string path)
        {
            int i = 0;
            
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    name[i] = Parsing(record, 1);
                    pass[i] = Parsing(record, 2);
                    i++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        static void SignIN(string[] user , string[] pass
            )
        {
            string name, password;
            bool flag = false;
            Console.Write("Enter username: ");
            name = Console.ReadLine();

            Console.Write("Enter username: ");
            password = Console.ReadLine();

            for(int i=0 ; i<10 ; i++)
            {
                if(name == user[i] && password== pass[i])
                {
                    Console.WriteLine("Login sucessful");
                    flag = true;
                    break;
                }
                
            }
            if(flag == false)
            {
                Console.WriteLine("No user was found");
            }

        }

        
    }
}
