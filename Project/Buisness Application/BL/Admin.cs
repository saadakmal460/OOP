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


    }
}
