using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        class Customer
        {
            public string customerName;
            public string customerAddress;
            public string customerContact;
            public List<Product> products = new List<Product>();

            public Customer(string name , string address , string contact)
            {
                customerName = name;
                customerAddress = address;
                customerContact = contact;
            }
            public List<Product> getAllProducts()
            {
                return products;
            }
            public void addProduct(Product p)
            {
                products.Add(p);
            }
        }
        class Product
        {
            public string name;
            public string catogery;
            public int price;

            public Product(string n , string c , int p)
            {
                name = n;
                catogery = c;
                price = p;
            }
            public float CalculateTax()
            {
                float tax = price * 0.17F;
                return tax;
            }
        }
        static void Main(string[] args)
        {
            Product p = new Product("Oreo", "Grocery", 100);
            Customer c = new Customer("Saad", "lahore", "1001");
           
            //Calculating tax

            float tax = p.CalculateTax();
            Console.WriteLine("Tax is : " +  tax);


            Console.ReadKey();

        }
    }
}
