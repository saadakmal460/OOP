using Challange_2.BL;
using Challange_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.UI
{
    class CustomersUI
    {

        public void GenerateInvoice()
        {
            double total = 0;
            Console.WriteLine("Product Name\t\tQuantity\t\tPrice\t\tSales Tax");
            foreach(Customers i in CustomersCRUD.c)
            {
                Console.WriteLine(i.name + "\t\t\t" + i.quantity + "\t\t\t" + i.totalPrice + "\t\t" + i.tax);
                total = total + i.finalPrice;
            }
            Console.WriteLine("Total = " + total);
            Console.ReadKey();
        }
        public void BuyProducts()
        {
            
            char option = 'y';
            while (option == 'y')
            {
                Console.Clear();
                string type = "";
                int price = 0;
                Console.Write("Enter name of product: ");
                string name = Console.ReadLine();

                

                Console.Write("How many do you want to buy: ");
                int amount = int.Parse(Console.ReadLine());

                bool flag = false;
                foreach(Products i in ProductsCRUD.pro)
                {
                    if(name == i.productName && amount <= i.stockQuantity)
                    {
                        flag = true;
                        i.stockQuantity = i.stockQuantity - amount;
                        type = i.productType;
                        price = i.ProductPrice*amount;
                    }

                }
                if(!flag)
                {
                    Console.WriteLine("No product exist");
                }
                Customers c = new Customers(name, amount , type , price);
                CustomersCRUD.AddInList(c);
                Console.WriteLine("Enter 'y' to buy more");
                Console.WriteLine("Enter 'n' to exit");
                option = char.Parse(Console.ReadLine());
            }

        }
        public int Menu()
        {
            Console.WriteLine("1.View products");
            Console.WriteLine("2.Buy products");
            Console.WriteLine("3.Generate Invoice");
            Console.WriteLine("4.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
}
