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
        protected string roomNumber;
        protected Reviews reviews;
        public Hostelite(string name , string cnic , string city , string rollNumber , string password , string role , string roomNumber) : base(name , password , role)
        {
            this.username = name;
            this.cnic = cnic;
            this.city = city;
            this.rollNumber = rollNumber;
            this.password = password;
            this.roomNumber = roomNumber;
            role = "hostelite";
            reviews = new Reviews(name , "0" , "null");
        }

       

        public void AddReview(Reviews r)
        {
            this.reviews = r;
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

        public void SetRoomNumber(string roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public string GetRoomNumber()
        {
            return roomNumber;
        }

        
        
        
    }
}
