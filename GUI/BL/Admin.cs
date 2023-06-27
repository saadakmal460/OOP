using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Admin : User
    {
        private string contact;
        private static List<Notices> notices = new List<Notices>();
        private static List<Mess> menu = new List<Mess>()
        {
            new Mess("Monday", "Biryani"),
            new Mess("Tuesday", "Chicken"),
            new Mess("Wednesday", "Sabzi"),
            new Mess("Thursday", "Daal"),
            new Mess("Friday", "Pulao"),
            new Mess("Saturday", "Sabzi"),
            new Mess("Sunday", "Daal")
        };
        public Admin(string username, string password, string contact, string role) : base(username, password, role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.contact = contact;
        }


        public static void AddNotices(Notices n)
        {
            notices.Add(n);
        }
        public static List<Notices> GetNoticesList()
        {
            return notices;
        }
        public void SetContact(string contact)
        {
            this.contact = contact;
        }

        public string GetContact()
        {
            return contact;
        }

        public static List<Mess> GetMessList()
        {
            return menu;
        }
        public static void AddMenuInList(Mess m)
        {
            menu.Add(m);
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine("Contact = " + contact);
        }
    }
}
