using Challange_2.BL;
using Challange_2.DL;
using Challange_2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int option2 = 0;
            int option3 = 0;

            MUsersUI m = new MUsersUI();
            ProductsUI p = new ProductsUI();
            CustomersUI c = new CustomersUI();
            do
            {
                MUsersCRUD.LoadUsers();
                Console.Clear();
                option = m.Menu();
                if(option == 1)
                {
                    Console.Clear();
                    MUsers users = m.SignUp();
                    MUsersCRUD.AddUsersInList(users);
                    MUsersCRUD.AddUsersInFile(users);
                }
                else if(option == 2)
                {
                    Console.Clear();
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter password: ");
                    string pass = Console.ReadLine();

                    MUsers users = MUsersUI.SignIN(name , pass);
                    if (users == null)
                    {
                        Console.Write("Invaild user");
                        Console.ReadKey();
                    }
                    else if (users.IsAdmin())
                    {
                        do
                        {
                            Console.Clear();
                            option2 = p.ProductsMenu();
                            if (option2 == 1)
                            {
                                Console.Clear();
                                Products prod = p.AddProducts();
                                ProductsCRUD.AddProductsInList(prod);
                                ProductsCRUD.SalesTax();
                            }
                            else if(option2 == 2)
                            {
                                Console.Clear();
                                ProductsUI.ViewProducts();
                            }
                            else if(option2 == 3)
                            {
                                Console.Clear();
                                ProductsUI.HighestUnitPrice();
                            }
                            else if(option2 == 4)
                            {
                                Console.Clear();
                                
                                ProductsUI.ViewSalesTax();
                            }
                            else if(option2 == 5)
                            {
                                Console.Clear();
                                ProductsUI.ProductsToBeOrdered();
                            }
                        }
                        while (option2 != 6);
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            option3 = c.Menu();
                            if(option3 == 1)
                            {
                                Console.Clear();
                                ProductsUI.ViewProductsForCustomers();
                            }
                            else if(option3 == 2)
                            {
                                Console.Clear();
                                c.BuyProducts();
                            }

                            else if(option3 == 3)
                            {
                                Console.Clear();
                                CustomersCRUD.Calculate();
                                c.GenerateInvoice();

                            }
                        } while (option3 != 4);
                    }

                }

            } while (option != 3);
        }
    }
}
