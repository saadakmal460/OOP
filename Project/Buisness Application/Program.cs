using Buisness_Application.BL;
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
            while(option!=2)
            {
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
                        int optionAdmin = 0;
                        while(optionAdmin !=14)
                        {
                            Console.WriteLine("Hello admin");
                            option = int.Parse(Console.ReadLine());
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
