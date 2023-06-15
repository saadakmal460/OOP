using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_Application.BL;
using Buisness_Application.DL;

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
        private static User user;
        //private static string role;
        private static string AdminOption;
        private static Hostelite hostelite;
        private static string name;
        private static bool flag;
        private static string NoticeOption = "0";
        private static Notices notice;
        private static int index;
        private static string messOption = "0";
        private static string reportOption = "0";
        private static string day;
        private static string searchOption = "0";
        private static string rollNumber = "0";
        private static Admin admin;
        private static string officalOption = "0";
        private static string hostelOption = "0";
        private static Complaints complaints;
        private static string Hostelitedecision;
        private static Reviews reviews;
        private static string finanaceOption = "0";
        private static string expenseOption = "0";
        private static Expense expenses;
        private static string revenueOption = "0";
        private static Revenue revenue;
        private static Challan challan;


        public static Challan GetChallan()
        {
            return challan;
        }
        public static void SetChallan(Challan c)
        {
            challan = c;
        }

        public static void SetRevenue(Revenue r)
        {
            revenue = r;
        }

        public static Revenue GetRevenue()
        {
            return revenue;
        }
        public static void SetRevenueOption(string opt)
        {
            revenueOption = opt;
        }

        public static string GetRevenueOption()
        {
            return revenueOption;
        }
        public static void SetExpense(Expense e)
        {
            expenses = e;
        }

        public static Expense GetExpense()
        {
            return expenses;
        }
        public static void SetExpenseOption(string opt)
        {
            expenseOption = opt;
        }

        public static string GetExpenseOption()
        {
            return expenseOption;
        }
        public static void SetFinanaceOption(string opt)
        {
            finanaceOption = opt;
        }

        public static string GetFinanceOption()
        {
            return finanaceOption;
        }
        public static void SetReviews(Reviews r)
        {
            reviews = r;
        }

        public static Reviews GetReviews()
        {
            return reviews;
        }
        public static string GetHostelitedecision()
        {
            return Hostelitedecision;
        }

        public static void SetHostelitedecision(string hd)
        {
            Hostelitedecision = hd;
        }

        public static Complaints GetComplaints()
        {
            return complaints;
        }
        public static void SetComplaints(Complaints c)
        {
            complaints = c;
        }
        public static void SethosteliteOption(string opt)
        {
            hostelOption = opt;
        }

        public static string GethosteliteOption()
        {
            return hostelOption;
        }
        public static void SetOfficialOption(string opt)
        {
            officalOption = opt;
        }

        public static string GetOfficialOption()
        {
            return officalOption;
        }
        public static Admin GetAdmin()
        {
            return admin;
        }
        public static void SetAdmin(Admin a)
        {
            admin = a;
        }
        public static string GetRollNumber()
        {
            return rollNumber;
        }
        public static void SetRollNumber(string rn)
        {
            rollNumber = rn;
        }
        
        public static void SetSearchOption(string opt)
        {
            searchOption = opt;
        }

        public static string GetSearchOption()
        {
            return searchOption;
        }
        public static string GetDay()
        {
            return day;
        }

        public static void SetDay(string d)
        {
            day = d;
        }
        public static string GetReportOption()
        {
            return reportOption;
        }
        public static void SetReportOption(string opt)
        {
            reportOption = opt;
        }
        public static string GetMessOption()
        {
            return messOption;
        }
        public static void SetMessOption(string opt)
        {
            messOption = opt;
        }
        public static int GetIndex()
        {
            return index;
        }
        public static void SetIndex(int i)
        {
            index = i;
        }
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


        //public static void SetRole(User user)
        //{

        //    user.role = user.returnRole();
            
        //}

        

        public static string GetRole()
        {
            
            return user.returnRole();

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
