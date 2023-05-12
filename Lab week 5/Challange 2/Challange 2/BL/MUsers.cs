using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.BL
{
    class MUsers
    {
        
        public bool IsAdmin()
        {
            if(role.ToLower() == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public MUsers(string name, string password , string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public MUsers(string name , string password)
        {
            this.name = name;
            this.password = password;
        }
        public string name;
        public string password;
        public string role;
    }
}
