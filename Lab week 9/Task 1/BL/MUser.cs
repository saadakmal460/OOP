using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.BL
{
    class MUser
    {
        private string name;
        private string password;
        private string role;

        public MUser(string name, string password , string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public MUser(string name, string password)
        {
            this.name = name;
            this.password = password;
            role = "NA";
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }


        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetRole(string role)
        {
            this.role = role;
        }

        public string GetRole()
        {
            return role;
        }

        public bool IsAdmin()
        {
            bool flag;
            if(role == "Admin")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }
    }
}
