using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        class Store
        {
            public int id;
            public string name;
            public int price;
            public string category;
            public string brand;
            public string country;
        }

        static void Main(string[] args)
        {
            Store[] s = new Store[20];
            int count = 0;
            int option = 0;
            int total = 0;

            do
            {
                option = Menu();
                if (option == 1)
                {
                    s[count] = AddProducts();
                    count++;
                }
                else if (option == 2)
                {
                    ShowProducts(s,count);
                    Console.ReadKey();
                }

                else if (option == 3)
                {
                    Console.Clear();
                    total = Worth(s, count);
                    Console.WriteLine("Toal store worth is {0}  PKR" , total);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            } while (option != 4);
        }





        static int Worth(Store[] s, int count)
        {
            int sum = 0;
            for(int i=0; i<count; i++)
            {
                sum = sum + s[i].price;
            }

            return sum;
        }

        static void ShowProducts(Store[] s , int count)
        {
            Console.Clear();
            for(int i =0; i<count; i++)
            {
                Console.WriteLine("Id:{0}  Name:{1}  Price:{2}  Brand:{3}  Category:{4}  Country:{5} ", s[i].id, s[i].name, s[i].price, s[i].brand, s[i].category, s[i].country);
            }
        }

        static Store AddProducts()
        {
            Console.Clear();
            Store s = new Store();
            Console.WriteLine("Enter product id: ");
            s.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name: ");
            s.name = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            s.price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category: ");
            s.category = Console.ReadLine();

            Console.WriteLine("Enter product brand: ");
            s.brand = Console.ReadLine();

            Console.WriteLine("Enter product country: ");
            s.country = Console.ReadLine();



            return s;
        }
        static int Menu()
        {
            int option;
            Console.Clear();
            Console.WriteLine("1.Add Products");
            Console.WriteLine("2.Show Products");
            Console.WriteLine("3.Total store worth");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }



}
