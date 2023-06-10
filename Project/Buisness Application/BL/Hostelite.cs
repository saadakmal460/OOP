using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Hostelite : User
    {
        protected string city;
        protected string cnic;
        protected string rollNumber;
        
        public Hostelite(string name , string cnic , string city , string rollNumber , string password , string role) : base(name , password , role)
        {
            this.username = name;
            this.cnic = cnic;
            this.city = city;
            this.rollNumber = rollNumber;
            this.password = password;
            role = "hostelite";
        }

        public void SetCity(string city)
        {
            this.city = city;
        }
        public string GetCity()
        {
            return city;
        }

        public void SetCnic(string cnic)
        {
            this.cnic = cnic;
        }
        public string GetCnic()
        {
            return cnic;
        }

        public void SetRollNumber(string rollNumber)
        {
            this.rollNumber = rollNumber;
        }
        public string GetRollNumber()
        {
            return rollNumber;
        }

        

        
        
        
    }
}
