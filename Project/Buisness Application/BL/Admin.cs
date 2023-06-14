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
        private Notices n;
        public Admin(string username, string password, string contact, string role) : base(username, password, role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.contact = contact;
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
