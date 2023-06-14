using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.BL;
namespace Buisness_Application.BL
{
    class ExtraBL
    {
        private static int option = 0;
        private static string path = "hostelites.txt";
        private static string pathNotices = "Notices.txt";
        private static string messPath = "Mess.txt";
        private static string complaintPath = "Complaints.txt";
        private static string ReviewsPath = "Reviews.txt";
        private static string ChallanPath = "Challans.txt";
        private static string ExpensePath = "Expense.txt";
        private static string RevenuePath = "Revenue.txt";
        private static string AdminPath = "Admin.txt";
        private static string HosteliteName;
        private static User user ;
        private static string role;
        private static string AdminOption;
        private static Hostelite hostelite;
        private static string name;
        private static bool flag;
        private static string NoticeOption = "0";
        private static Notices notice;

        public static Notices GetNoticeObj()
        {
            return notice;
        }
        public static void SetNoticeObj(Notices n)
        {
            notice = n;
        }
        public static string GetOptionForNotice()
        {
            return NoticeOption;
        }
        public static void SetOptionForNotice(string opt)
        {
            NoticeOption = opt;
        }

        public static bool GetFlag()
        {
            return flag;
        }
        public static void SetFlag(bool f)
        {
            flag = f;
        }
        public static Hostelite GetHosteliteObj()
        {
            return hostelite;
        }
        public static void SetHostelite(Hostelite h)
        {
            hostelite = h;
        }

        public static string GetAdminOption()
        {
            return AdminOption;
        }
        public static void SetAdminOption(string option)
        {
            AdminOption = option;
        }


        public static void SetRole(User user)
        {
            role = user.returnRole();
        }
        public static string GetRole()
        {
            return role;
        }
        

        public static User GetUser()
        {
            return user;
        }
        public static void SetUser(User u)
        {
            user = u;
        }
        
        public static string GetAdminPath()
        {
            return AdminPath;
        }
        public static string GetRevenuePath()
        {
            return RevenuePath;
        }
        public static string GetExpensePath()
        {
            return ExpensePath;
        }
        public static string GetChallanPath()
        {
            return ChallanPath;
        }
        public static string GetReviewsPath()
        {
            return ReviewsPath;
        }
        public static string GetComplaintsPath()
        {
            return complaintPath;
        }
        public static string getpath()
        {
            return path;
        }

        public static string GetNoticesPath()
        {
            return pathNotices;
        }

        public static string GetMessPath()
        {
            return messPath;
        }

        public static int GetOption()
        {
            return option;
        }
        public static void setOption(int x)
        {
            option = x;
        }

        public static string GetHosteliteName()
        {
            return HosteliteName;
        }

        public static void SetHosteliteName(User u)
        {
            HosteliteName = u.GetUsername();
        }

        public static void SetName(string n)
        {
            name = n;
        }

        public static string GetName()
        {
            return name;
        }
    }
}
