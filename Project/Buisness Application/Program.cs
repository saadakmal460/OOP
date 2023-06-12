using Buisness_Application.BL;
using Buisness_Application.DL;
using Buisness_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing variables
            int option = 0;
            string path = "hostelites.txt";
            string pathNotices = "Notices.txt";
            string messPath = "Mess.txt";
            string complaintPath = "Complaints.txt";
            string ReviewsPath = "Reviews.txt";
            string ChallanPath = "Challans.txt";
            string BillsPath = "Bills.txt";
            
            string HosteliteName = "";
            
            
            //Loading data
            HosteliteCRUD.LoadHostelitesFromFile(path);
            NoticesCRUD.LoadNoticesFromFile(pathNotices);
            MessCRUD.LoadMessMenuFromFile(messPath);
            ComplaintsCRUD.LoadComplaintsFromFile(complaintPath);
            ReviewsCRUD.LoadReviewsFromFile(ReviewsPath);
            ChallanCRUD.LoadChallansFromFile(ChallanPath);
            BillsCRUD.LoadBillsFromFile(BillsPath);

            //main while loop
            while (option!=2)
            {
                //clearing and printing header
                Console.Clear();
                GeneralUI.Header();
                GeneralUI.Path();

                //Login screen
                option = GeneralUI.LoginScreen();
                if(option == 1)
                {
                    Console.Clear();
                    GeneralUI.Header();
                    GeneralUI.Path();

                    //Taking username and password
                    User user = UserUI.TakeInputForLogin();
                    string role = user.returnRole();
                    HosteliteName = user.GetUsername();
                    //starting admin menu
                    if(role == "admin")
                    {
                        Console.Clear();
                        GeneralUI.Header();
                        GeneralUI.Path();

                        //Admin menu
                        string optionAdmin = "0";
                        //stating admin menu loop
                        while(optionAdmin != "12")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();
                            //options for admin screen
                            optionAdmin = AdminUI.PrintMenuForAdmin();
                            //option 1 start
                            if (optionAdmin == "1")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //adding hostelite
                                Hostelite h = HosteliteUI.TakeInputForHostelite();
                                HosteliteCRUD.AddHosteliteInList(h);
                                UserCRUD.AdddInList(h);
                                HosteliteCRUD.StoreInFile(path);
                            }
                            //option 2 start
                            else if (optionAdmin == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //removing hostelite by taking name
                                string name = HosteliteUI.TakeNameAsInput();
                                bool flag = HosteliteCRUD.RemoveFromHosteliteList(name);
                                HosteliteUI.ShowMessage(flag);
                                HosteliteCRUD.DeleteHosteliteFromFile(path);

                            }
                            //option 3 start
                            else if (optionAdmin == "3")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //Updating records
                                string name = HosteliteUI.TakeNameAsInput();
                                bool flag = HosteliteUI.UpdateRecord(name);
                                HosteliteUI.ShowMessage(flag);
                                HosteliteCRUD.StoreInFile(path);
                            }
                            //option 4 start
                            else if (optionAdmin == "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing hostelites
                                HosteliteCRUD.sortList();
                                HosteliteUI.ViewHostelites();
                            }

                            //option 5 start
                            else if (optionAdmin == "5")
                            {
                                //starting of notices functions
                                string noticeOption = "0";

                                //starting while loop
                                while (noticeOption != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //notice board operations
                                    noticeOption = AdminUI.NoticeMenu();
                                    //option 1 of notices
                                    if (noticeOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //adding notice
                                        Notices notice = NoticesUI.TakeInputForNotices();
                                        NoticesCRUD.AddNoticesInList(notice);
                                        NoticesCRUD.StoreNoticesInFile(pathNotices);

                                    }
                                    //option 2 of notices
                                    else if (noticeOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //deleting notices
                                        NoticesUI.ViewNotices();
                                        int i = NoticesUI.TakeInputToDeleteNotice();
                                        NoticesCRUD.RemoveANotice(i);
                                        NoticesCRUD.StoreNoticesInFile(pathNotices);
                                    }
                                    //option 3 of notices
                                    else if (noticeOption == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //viewing notice
                                        NoticesUI.ViewNotices();
                                        Console.ReadKey();
                                    }
                                }
                            }

                            else if (optionAdmin == "6")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                ComplaintsUI.ViewComplaints();
                            }
                            //option 7 start
                            else if (optionAdmin == "7")
                            {
                                Console.Clear();
                                string messOption = "0";
                                while (messOption != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    messOption = MessUI.MessMenu();
                                    if (messOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();
                                        MessUI.ViewMess();

                                    }

                                    else if (messOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        string day = MessUI.TakeDayAsInput();
                                        bool flag = MessUI.UpdateMenu(day);
                                        MessCRUD.StoreMessMenuInFile(messPath);
                                        HosteliteUI.ShowMessage(flag);
                                    }

                                }
                            }

                            else if (optionAdmin == "8")
                            {
                                string opt = "0";
                                while (opt != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    opt = BillsUI.ReportMenu();

                                    if (opt == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.ShowFinancialReport();
                                        Console.ReadKey();
                                    }
                                    else if (opt == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.ShowGraph();

                                    }
                                }
                            }
                            //option 9 start
                            else if (optionAdmin == "9")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing alloted rooms
                                HosteliteUI.ViewHostelitesRooms();
                            }

                            //option 10 start
                            else if (optionAdmin == "10")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //search menu
                                string searchOption = "0";
                                while (searchOption != "3")
                                {
                                    searchOption = HosteliteUI.SearchHosteliteOption();
                                    if (searchOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();
                                        //searching by name
                                        string name = HosteliteUI.TakeNameAsInput();
                                        bool flag = HosteliteUI.SearchByName(name);
                                        HosteliteUI.ShowMessage(flag);

                                    }

                                    else if (searchOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //searching by roll number
                                        string rollNumber = HosteliteUI.TakeRollNumberAsInput();
                                        bool flag = HosteliteUI.SearchByRollNumber(rollNumber);
                                        HosteliteUI.ShowMessage(flag);
                                    }
                                }
                            }

                            //start option 11
                            else if (optionAdmin == "11")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //View reviews and ratings
                                ReviewsUI.ViewAllReviews();

                            }
                        }
                    }

                    else if(role == "hostelite")
                    {
                        Console.Clear();
                        string hOption = "0";
                        while(hOption != "9")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();

                            hOption = HosteliteUI.HosteliteMenu();
                            if(hOption == "1")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                HosteliteUI.SearchByName(HosteliteName);
                                Console.ReadKey();
                            }

                            else if(hOption == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                MessUI.ViewMess();
                            }

                            else if(hOption == "3")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                Complaints complaint = ComplaintsUI.TakeComplaints(HosteliteName);
                                ComplaintsCRUD.AddComplaitsInList(complaint);
                                ComplaintsCRUD.StoreComplaintsInFile(complaintPath);

                            }

                            else if(hOption == "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing notice
                                NoticesUI.ViewNotices();
                                Console.ReadKey();
                            }

                            else if(hOption == "5")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //paying fee
                                 PayFeeUI.TakeInputForPayFee();
                                 ChallanCRUD.StoreChallansInFile(ChallanPath);

                            }

                            else if(hOption == "7")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                string op = HosteliteUI.ShowWarning();
                                if (op == "Yes")
                                {
                                    string name = HosteliteUI.TakeNameAsInput();
                                    bool flag = HosteliteCRUD.RemoveFromHosteliteList(name);
                                    HosteliteUI.ShowMessage(flag);
                                    HosteliteCRUD.DeleteHosteliteFromFile(path);
                                    break;
                                        
                                }
                            }

                            else if(hOption == "8")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //adding reviews
                                Reviews review = ReviewsUI.TakeReviews(HosteliteName);
                                ReviewsCRUD.AddInList(review);
                                ReviewsCRUD.StoreReviewsInFile(ReviewsPath);
                                
                            }
                        }
                        
                    }

                    else if(role == "Finance")
                    {
                        string FinanceOption = "0";
                        while(FinanceOption != "10")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();
                            FinanceOption = FinanceUI.FinanceMenu();


                            if (FinanceOption == "1")
                            {
                                string billsOption = "0";
                                while (billsOption != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    billsOption = BillsUI.BillsMenu();
                                    if (billsOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        Bills bill = BillsUI.TakeInputForExpense();
                                        BillsCRUD.AddInList(bill);
                                        BillsCRUD.StoreBillsInFile(BillsPath);

                                    }

                                    else if (billsOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.Show("Expense");
                                        Console.ReadKey();
                                    }

                                    else if (billsOption == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.Show("Expense");
                                        int i = BillsUI.TakeInputForNumber();
                                        BillsCRUD.RemoveFromList(i);
                                        BillsCRUD.StoreBillsInFile(BillsPath);
                                    }
                                }
                            }

                            else if (FinanceOption == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                BillsUI.Show("Expense");
                                BillsUI.ShowCalculated("Expense");
                                Console.ReadKey();

                            }

                            else if (FinanceOption == "3")
                            {
                                string RevenueOption = "0";
                                while (RevenueOption != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    RevenueOption = BillsUI.RevenueMenu();
                                    if (RevenueOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        Bills bill = BillsUI.TakeInputForRevenue();
                                        BillsCRUD.AddInList(bill);
                                        BillsCRUD.StoreBillsInFile(BillsPath);

                                    }

                                    else if (RevenueOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.Show("Revenue");
                                        Console.ReadKey();
                                    }

                                    else if (RevenueOption == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.Show("Expense");
                                        int i = BillsUI.TakeInputForNumber();
                                        BillsCRUD.RemoveFromList(i);
                                        BillsCRUD.StoreBillsInFile(BillsPath);
                                    }
                                }
                            }

                            else if (FinanceOption == "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                string rollNumber = HosteliteUI.TakeRollNumberAsInput();
                                bool flag = ChallanUI.CheckInChallanList(rollNumber);
                                Challan c = ChallanUI.TakeChallanInput(rollNumber);
                                ChallanCRUD.StoreChallansInFile(ChallanPath);

                                if (!flag)
                                {
                                    ChallanCRUD.AddChallanInList(c);
                                }


                            }

                            else if (FinanceOption == "5")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                ChallanUI.ShowFee();
                            }

                            else if (FinanceOption == "6")
                            {
                                string opt = "0";
                                while (opt != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    opt = BillsUI.ReportMenu();

                                    if(opt == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.ShowFinancialReport();
                                        Console.ReadKey();
                                    }
                                    else if(opt == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        BillsUI.ShowGraph();

                                    }
                                }
                            }

                            else if (FinanceOption == "8")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing notice
                                NoticesUI.ViewNotices();
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
