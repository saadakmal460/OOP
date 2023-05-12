using Challange_2.BL;
using Challange_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.UI
{
    class MUsersUI
    {
        public MUsers SignUp()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            MUsers m = new MUsers(name, pass, role);
            return m;

        }

        public static MUsers SignIN(string name , string password)
        {
            foreach(MUsers i in MUsersCRUD.users)
            {
                if(name == i.name && password == i.password)
                {
                    return i;
                }
                
                   
                
            }
            return null;
        }
        public int Menu()
        {
            Console.WriteLine("1.SignUP");
            Console.WriteLine("2.SignIN");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
}
