using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class UserUI
    {
        public static User TakeInputForLogin()
        {
            Console.WriteLine(" ");
            Console.Write("\tEnter username: ");
            string name = Console.ReadLine();
            Console.Write("\tEnter password: ");
            string password = Console.ReadLine();

            User u = new User(name, password);
            return u;

        }
    }
}
