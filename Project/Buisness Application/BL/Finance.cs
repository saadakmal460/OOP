using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Finance : User
    {
        private string employeeNumber;


        public Finance(string username, string password , string role , string employeeNumber) : base(username, password, role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.employeeNumber = employeeNumber;
        }
        public void SetEmployeeNumber(string en)
        {
            employeeNumber = en;
        }

        public string GetEmployeeNumber()
        {
            return employeeNumber;
        }
       
    }
}
