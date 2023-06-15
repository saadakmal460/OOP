using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class User
    {
        protected string username;
        protected string password;
        protected string role;
        public User(string username, string password , string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            
        }
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetUsername()
        {
            return username;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetPassword()
        {
            return password;
        }


        public string returnRole()
        {

                foreach (User i in UserCRUD.u)
                {
                    if (username == i.GetUsername() && password == i.GetPassword())
                    {
                        role = i.role;

                    }
                }
            

            return role;
        }

        public void SetRole(string role)
        {
            this.role = role;
        }
    }
}
