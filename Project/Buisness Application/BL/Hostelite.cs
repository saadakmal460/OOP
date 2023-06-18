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
        private string city;
        private string cnic;
        private string rollNumber;
        private string roomNumber;
        private static List<Reviews> reviews = new List<Reviews>();
        private static List<Complaints> complaints = new List<Complaints>();
        private static PayFee payFee;
        public Hostelite(string name , string cnic , string city , string rollNumber , string password , string role , string roomNumber) : base(name , password , role)
        {
            this.username = name;
            this.cnic = cnic;
            this.city = city;
            this.rollNumber = rollNumber;
            this.password = password;
            this.roomNumber = roomNumber;
            role = "hostelite";
            
        }

        public static PayFee GetPayFee()
        {
            return payFee;
        }
        public static void SetPayFee(PayFee Fee)
        {
            payFee = Fee;
        }
        public static void AddComplaintsInList(Complaints c)
        {
            complaints.Add(c);
        }

        public static List<Complaints> GetComplaintsList()
        {
            return complaints;
        }
        public static void AddInList(Reviews r)
        {
            reviews.Add(r);
        }
       
        public static List<Reviews> GetReviewList()
        {
            return reviews;
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
