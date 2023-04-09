using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\2nd Semester\\OOP\\Lab week 1\\Pizza Points\\customers.txt";
            string[] names = new string[100];
            int[] orders = new int[100];
            int[][] price = new int[100][];
            int count = Load(path, names, orders, price);

            for (int i = 0; i < count; i++)
            {
                Console.Write(names[i]);
                Console.Write(orders[i]);
                Console.Write(price[i]);
            }
            while (true)
            {
                int option = 0;
                option = Menu();
                while (option != 3)
                {
                    if (option == 1)
                    {
                        Console.Clear();
                        AddUser();
                        break;
                    }


                }
            }
            Console.ReadKey();
        }








        static string Parsing(string record, int field)
        {
            int count = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ' ' || record[i] == '[')
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

        static int Load(string path, string[] names, int[] orders, int[][] price)
        {
            int count = 0;
            string[] values = new string[100];
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    names[count] = Parsing(record, 1);
                    orders[count] = int.Parse(Parsing(record, 2));
                    values[count] = Parsing(record, 3);
                    for (int i = 0; i < values.Length; i++)
                    {
                        price[count][i] = int.Parse(values[i]);
                    }
                    count++;
                }
                file.Close();
            }
            return count;
        }


        static int Menu()
        {
            int option;
            Console.WriteLine("\t1.Enter a new user");
            Console.WriteLine("\t2.Customers eligible for awards");
            Console.WriteLine("\t3.Exit");
            Console.WriteLine("Ent option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void AddUser()
        {
            string path = "D:\\2nd Semester\\OOP\\Lab week 1\\Pizza Points\\customers.txt";
            string name;
            int orders;
            int[] prices = new int[100];

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter number of orders: ");
            orders = int.Parse(Console.ReadLine());

            Console.Write("Enter prices: ");
            for (int i = 0; i < orders; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }

            Store(name , orders, prices, path);
            Console.Clear();

        }
        static void Store(string name ,int orders , int[] prices , string path)
        {
            string o;
       
            string[] p = new string[100];
            o = orders.ToString();
            for (int i = 0; i < orders; i++)
            {
                p[i] = prices[i].ToString();
            }
            
            StreamWriter file = new StreamWriter(path, true);

            file.Write(name + " " + o + " " + "[");
            for (int i = 0; i < orders; i++)
            {
                
                if (i == orders - 1)
                {
                    file.Write(p[i]);
                }
                else
                {
                    file.Write(p[i]);
                    file.Write(",");
                }
            }
            file.WriteLine("]");
            file.Flush();
            file.Close();

        }
    }
}
