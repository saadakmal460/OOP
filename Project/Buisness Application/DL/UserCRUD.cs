using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class UserCRUD
    {
        public static List<User> u = new List<User>();

        public static void AdddInList(User user)
        {
            u.Add(user);
        }

        public static void show()
        {
            foreach(User i in u)
            {
                Console.WriteLine(i.GetUsername() + "\t" + i.GetPassword() + "\t" + i.returnRole());
            }
            Console.ReadKey();
        }


       
    }
}
