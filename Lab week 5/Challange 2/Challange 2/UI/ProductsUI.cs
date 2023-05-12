using Challange_2.BL;
using Challange_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.UI
{
    class ProductsUI
    {

        public static void ViewSalesTax()
        {
            Console.WriteLine("Name\t\tPrice\t\tType\t\tStock Quantity\t\tSales Tax");
            foreach (Products i in ProductsCRUD.pro)
            {
                if (i.thresholdQuantity < 10)
                {
                    Console.WriteLine(i.productName + "\t\t" + i.ProductPrice + "\t\t" + i.productType + "\t\t" + i.stockQuantity + "\t\t\t" + i.SalesTax);
                }
            }
            Console.ReadKey();
        }
        public static void ProductsToBeOrdered()
        {
            Console.WriteLine("Name\t\tPrice\t\tType\t\tStock Quantity\t\tThreshold Quantity");
            foreach (Products i in ProductsCRUD.pro)
            {
                if(i.thresholdQuantity < 10)
                {
                    Console.WriteLine(i.productName + "\t\t" + i.ProductPrice + "\t\t" + i.productType + "\t\t" + i.stockQuantity + "\t\t\t" + i.thresholdQuantity);
                }
            }
            Console.ReadKey();
        }
        public static void HighestUnitPrice()
        {
            int idx = -1;
            int greatest = 0;
            for(int i=0; i<ProductsCRUD.pro.Count; i++)
            {
                if(ProductsCRUD.pro[i].ProductPrice > greatest)
                {
                    greatest = ProductsCRUD.pro[i].ProductPrice;
                    idx = i;
                }
            }
            Console.WriteLine("Name\t\tPrice\t\tType\t\tStock Quantity\t\tThreshold Quantity");
            Console.WriteLine(ProductsCRUD.pro[idx].productName + "\t\t" + ProductsCRUD.pro[idx].ProductPrice + "\t\t" + ProductsCRUD.pro[idx].productType + "\t\t" + ProductsCRUD.pro[idx].stockQuantity + "\t\t\t" + ProductsCRUD.pro[idx].thresholdQuantity);
            Console.ReadKey();
        }
        public static void ViewProducts()
        {
            Console.WriteLine("Name\t\tPrice\t\tType\t\tStock Quantity\t\tThreshold Quantity");
            foreach(Products i in ProductsCRUD.pro)
            {
                Console.WriteLine(i.productName + "\t\t" + i.ProductPrice + "\t\t" + i.productType + "\t\t" + i.stockQuantity + "\t\t\t" + i.thresholdQuantity);
            }
            Console.ReadKey();
        }

        public static void ViewProductsForCustomers()
        {
            Console.WriteLine("Name\t\tPrice\t\tType");
            foreach (Products i in ProductsCRUD.pro)
            {
                Console.WriteLine(i.productName + "\t\t" + i.ProductPrice + "\t\t" + i.productType);
            }
            Console.ReadKey();
        }
        public Products AddProducts()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product type: ");
            string type = Console.ReadLine();

            Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());

            Console.Write("Enter avaliable stock quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter minimum stock quantity: ");
            int mQuantity = int.Parse(Console.ReadLine());

            Products p = new Products(name, type, price, quantity, mQuantity);
            return p;

        }

        public int ProductsMenu()
        {
            Console.WriteLine("1.Add products");
            Console.WriteLine("2.View products");
            Console.WriteLine("3.Find products with highest unit price");
            Console.WriteLine("4.View sales tax of products");
            Console.WriteLine("5.Products to be ordered");
            Console.WriteLine("6.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
