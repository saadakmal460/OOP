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
            int price, orders;
            string path = "D:\\2nd Semester\\OOP\\Lab week 1\\Pizza Points\\customers.txt";
            Console.WriteLine("Enter number of orders: ");
            orders = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter minimum price: ");
            price = int.Parse(Console.ReadLine());

            string result = Parsing(path, orders, price);
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != ',')
                {
                    Console.Write(result[i]);
                    
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
            Console.ReadKey();
        }


        static string Parsing(string path , int orders , int price)
        {
            string item = "";
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string name = "";
                for (int i = 0; record[i] != ' '; i++)
                {
                    name = name + record[i];
                }
                if (LargestNumber(record, orders, price))
                {
                    item = item + name + ",";
                }
            }

            file.Close();
            return item;
        }

        static bool LargestNumber(string record, int orders, int price)
        {
            bool flag = false;
            int count = 0;
            int idx = -1;
            string number = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == '[')
                {
                    idx = i + 1;
                    break;
                }
            }
            for (int i = idx; i < record.Length - 1; i++)
            {
                if (record[i] != ',')
                {
                    number = number + record[i];
                }
                else
                {
                    if (int.Parse(number) >= price)
                    {
                        count++;
                        number = "";
                    }
                    
                }
            }
            if (count >= orders)
            {
                flag = true;
            }
            return flag;

        }
    }
}
