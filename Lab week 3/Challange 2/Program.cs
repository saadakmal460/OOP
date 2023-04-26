using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
    class Store
    {
        public bool Order(int msq)
        {
            bool flag=false;
            if(msq<10)
            {
                flag = true;
            }
            return flag;
        }
        public int SalesTax(int price , int stock)
        {
            int total = price * stock;
            return total;
        }

        public Store(int msq)
        {
            
            minStockQuantity = msq;
        }
        public Store(int p , int sq)
        {
            price = p;
            stockQuantity = sq;
        }
        
        public Store(string n, string c , int p , int sq , int msq)
        {
            name = n;
            catogory = c;
            price = p;
            stockQuantity = sq;
            minStockQuantity = msq;
        
        }
        public string name;
        public string catogory;
        public int price;
        public int stockQuantity;
        public int minStockQuantity;
        public double tax;
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            List <Store> s = new List<Store>();
            int option = 0;
            string name="", catogory="";
            int price=0, sq=0, msq=0;

            
            do
            {
                option = Menu();
                if(option == 1)
                {
                    Console.Clear();
                    AddProduct(name, catogory, price, sq, msq , s);  
                }
                else if(option ==2)
                {
                    Console.Clear();
                    View(s);
                }
                else if(option==3)
                {
                    Console.Clear();
                    HigestPrice(s);
                }
                else if(option==4)
                {
                    Console.Clear();
                    SaleTax(s);
                    ViewSalesTax(s);
                }
                else if(option==5)
                {
                    Console.Clear();
                    OrderProducts(s);
                }
                Console.Clear();
            } while (option != 6);

        }


        static void OrderProducts(List<Store> p)
        {
            bool flag;
            Console.WriteLine("Order these!!");
            for(int i =0;i<p.Count;i++)
            {
                Store s = new Store(p[i].minStockQuantity);
                flag = s.Order(p[i].minStockQuantity);
                if (flag == true)
                {
                    Console.WriteLine(p[i].name + "\t\t" + p[i].price);
                }
            }
            Console.ReadKey();
        }
        static void ViewSalesTax(List<Store> p)
        {
            Console.WriteLine("Name\t\tCatogory\t\tPrice\t\tStock\t\tMin Stock\t\tSales Tax");
            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine(p[i].name + "\t\t" + p[i].catogory + "\t\t\t" + p[i].price + "\t\t" + p[i].stockQuantity + "\t\t" + p[i].minStockQuantity + "\t\t\t" + p[i].tax);
            }
            Console.ReadKey();
        }
        static void SaleTax(List<Store> p)
        {
            int price;
            for (int i=0;i<p.Count;i++)
            {
                Store s = new Store(p[i].price, p[i].stockQuantity);
                if (p[i].catogory == "grocery")
                {
                    price = s.SalesTax(p[i].price, p[i].stockQuantity);
                    p[i].tax = price * 0.1;
                    
                    
                }
                else if(p[i].catogory == "fruit")
                {
                    price = s.SalesTax(p[i].price, p[i].stockQuantity);
                    p[i].tax = price  * 0.05;
                    
                }
                else if (p[i].catogory == "other")
                {
                    price = s.SalesTax(p[i].price, p[i].stockQuantity);
                    p[i].tax = price * 0.15;
                   
                }
            }
        }

        static void HigestPrice(List<Store> p)
        {
            int index=0;
            for(int i=0;i<p.Count;i++)
            {
                if(p[i].price > p[index].price)
                {
                    index = i;
                }
            }
            Console.WriteLine("Highest unit price product: ");
            Console.WriteLine(p[index].name + "\t\t" + p[index].catogory + "\t\t\t" + p[index].price + "\t\t" + p[index].stockQuantity + "\t\t" + p[index].minStockQuantity);
            Console.ReadKey();
        }
        static void View(List<Store> p)
        {
            Console.WriteLine("Name\t\tCatogory\t\tPrice\t\tStock\t\tMin Stock");
            for(int i=0;i<p.Count;i++)
            {
                Console.WriteLine(p[i].name + "\t\t" + p[i].catogory + "\t\t\t" + p[i].price + "\t\t" + p[i].stockQuantity + "\t\t" + p[i].minStockQuantity);
            }
            Console.ReadKey();
        }
        static void AddProduct(string name, string catogory, int price, int stockQuantity, int minStockQuantity ,List<Store> p)
        {
            
            Console.WriteLine("Enter name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter catogory of product (Grocery or fruits): ");
            catogory = Console.ReadLine();

            Console.WriteLine("Enter price of product: ");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter stock quantity of product: ");
            stockQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter minimum stock quantity of product: ");
            minStockQuantity = int.Parse(Console.ReadLine());
            Store s = new Store(name, catogory,  price, stockQuantity, minStockQuantity);
            p.Add(s);
            

        }
        static int Menu()
        {
            int option;

            Console.WriteLine("1.Add product");
            Console.WriteLine("2.View product");
            Console.WriteLine("3.Highest Unit price");
            Console.WriteLine("4.View sales tax");
            Console.WriteLine("5.Products to be orderes");
            Console.WriteLine("Enter option: ");
            option = int.Parse(Console.ReadLine());

            return option;

        }
    }
}
