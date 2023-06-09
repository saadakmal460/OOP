using Buisness_Application.BL;
using Buisness_Application.DL;
using Buisness_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            string path = "hostelites.txt";
            Hostelite.LoadHostelitesFromFile(path);

          
            while(option!=2)
            {
                Console.Clear();
                GeneralUI.Header();
                GeneralUI.Path();
                option = GeneralUI.LoginScreen();
                if(option == 1)
                {
                    Console.Clear();
                    GeneralUI.Header();
                    GeneralUI.Path();
                    User user = UserUI.TakeInputForLogin();
                    string role = user.returnRole();
                    
                    if(role == "admin")
                    {
                        Console.Clear();
                        GeneralUI.Header();
                        GeneralUI.Path();
                        string optionAdmin = "0";
                        while(optionAdmin != "10")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();
                            optionAdmin = AdminUI.PrintMenuForAdmin();
                            if(optionAdmin == "1")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();
                                Hostelite h = HosteliteUI.TakeInputForHostelite();
                                HosteliteCRUD.AddHosteliteInList(h);
                                UserCRUD.AdddInList(h);
                                h.StoreInFile(path);   
                            }
                            else if(optionAdmin == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();
                                string name = HosteliteUI.RemoveHostelite();

                            }
                            else if(optionAdmin == "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();
                                HosteliteUI.ViewHostelites();


                            }
                        }
                    }
                    else
                    {
                        GeneralUI.Header();
                        GeneralUI.Path();
                        Console.WriteLine("hello ");

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
