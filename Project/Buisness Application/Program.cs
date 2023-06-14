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

            //Loading data
            HosteliteCRUD.LoadHostelitesFromFile(ExtraBL.getpath());
            NoticesCRUD.LoadNoticesFromFile(ExtraBL.GetNoticesPath());
            MessCRUD.LoadMessMenuFromFile(ExtraBL.GetMessPath());
            ComplaintsCRUD.LoadComplaintsFromFile(ExtraBL.GetComplaintsPath());
            ReviewsCRUD.LoadReviewsFromFile(ExtraBL.GetReviewsPath());
            ChallanCRUD.LoadChallansFromFile(ExtraBL.GetChallanPath());
            ExpenseCRUD.LoadExpensesFromFile(ExtraBL.GetExpensePath());
            RevenueCRUD.LoadRevenueFromFile(ExtraBL.GetRevenuePath());
            AdminCRUD.LoadAdminFromFile(ExtraBL.GetAdminPath());

           
            //main while loop
            while (ExtraBL.GetOption() !=2)
            {
                //clearing and printing header
                Console.Clear();
                GeneralUI.Header();
                GeneralUI.Path();

                //Login screen
                ExtraBL.setOption(GeneralUI.LoginScreen());
                if(ExtraBL.GetOption() == 1)
                {
                    Console.Clear();
                    GeneralUI.Header();
                    GeneralUI.Path();

                    //Taking username and password
                    ExtraBL.SetUser(UserUI.TakeInputForLogin());
                    ExtraBL.SetRole(ExtraBL.GetUser());
                    ExtraBL.SetHosteliteName(ExtraBL.GetUser());
                    

                    //starting admin menu
                    if(ExtraBL.GetRole() == "admin")
                    {
                        Console.Clear();
                        GeneralUI.Header();
                        GeneralUI.Path();

                        //Admin menu
                        //string optionAdmin = "0";
                        

                        //stating admin menu loop
                        while(ExtraBL.GetAdminOption() != "13")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();
                            //options for admin screen
                            ExtraBL.SetAdminOption(AdminUI.PrintMenuForAdmin());
                            //option 1 start
                            if (ExtraBL.GetAdminOption() == "1")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //adding hostelite
                                ExtraBL.SetHostelite(HosteliteUI.TakeInputForHostelite());
                                HosteliteCRUD.AddHosteliteInList(ExtraBL.GetHosteliteObj());
                                UserCRUD.AdddInList(ExtraBL.GetHosteliteObj());
                                HosteliteCRUD.StoreInFile(ExtraBL.getpath());
                            }

                            //option 2 start
                            else if (ExtraBL.GetAdminOption() == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //removing hostelite by taking name
                                ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                ExtraBL.SetFlag(HosteliteCRUD.RemoveFromHosteliteList(ExtraBL.GetName()));
                                HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                HosteliteCRUD.DeleteHosteliteFromFile(ExtraBL.getpath());

                            }
                            //option 3 start
                            else if (ExtraBL.GetAdminOption()== "3")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //Updating records
                                ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                ExtraBL.SetFlag(HosteliteUI.UpdateRecord(ExtraBL.GetName()));
                                HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                HosteliteCRUD.StoreInFile(ExtraBL.getpath());
                            }
                            //option 4 start
                            else if (ExtraBL.GetAdminOption()== "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing hostelites
                                HosteliteCRUD.sortList();
                                HosteliteUI.ViewHostelites();
                            }

                            //option 5 start
                            else if (ExtraBL.GetAdminOption()== "5")
                            {
                                //starting of notices functions
                               

                                //starting while loop
                                while (ExtraBL.GetOptionForNotice() != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //notice board operations
                                    ExtraBL.SetOptionForNotice(AdminUI.NoticeMenu());

                                    //option 1 of notices
                                    if (ExtraBL.GetOptionForNotice() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //adding notice
                                        ExtraBL.SetNoticeObj(NoticesUI.TakeInputForNotices());
                                        NoticesCRUD.AddNoticesInList(ExtraBL.GetNoticeObj());
                                        NoticesCRUD.StoreNoticesInFile(ExtraBL.GetNoticesPath());

                                    }
                                    //option 2 of notices
                                    else if (ExtraBL.GetOptionForNotice() == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //deleting notices
                                        NoticesUI.ViewNotices();
                                        int i = NoticesUI.TakeInputToDeleteNotice();
                                        NoticesCRUD.RemoveANotice(i);
                                        NoticesCRUD.StoreNoticesInFile(ExtraBL.GetNoticesPath());
                                    }
                                    //option 3 of notices
                                    else if (ExtraBL.GetOptionForNotice() == "3")
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

                            else if (ExtraBL.GetAdminOption()== "6")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                ComplaintsUI.ViewComplaints();
                            }
                            //option 7 start
                            else if (ExtraBL.GetAdminOption()== "7")
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
                                        MessCRUD.StoreMessMenuInFile(ExtraBL.GetMessPath());
                                        HosteliteUI.ShowMessage(flag);
                                    }

                                }
                            }

                            else if (ExtraBL.GetAdminOption()== "8")
                            {
                                string opt = "0";
                                while (opt != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    opt = FinancialRecordUI.ShowMenu();

                                    if (opt == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        FinancialRecordUI.ShowFinancialReprt();
                                        Console.ReadKey();
                                    }
                                    else if (opt == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        FinancialRecordUI.ShowGraph();

                                    }
                                }
                            }
                            //option 9 start
                            else if (ExtraBL.GetAdminOption()== "9")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing alloted rooms
                                HosteliteUI.ViewHostelitesRooms();
                            }

                            //option 10 start
                            else if (ExtraBL.GetAdminOption()== "10")
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
                            else if (ExtraBL.GetAdminOption()== "11")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //View reviews and ratings
                                ReviewsUI.ViewAllReviews();

                            }

                            else if(ExtraBL.GetAdminOption()== "12")
                            {
                                
                                string opt = "0";
                                while(opt != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    opt = AdminUI.OfficalMenu();
                                    if (opt == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        Admin a = AdminUI.TakeInputForAdmin();
                                        AdminCRUD.AddInList(a);
                                        UserCRUD.AdddInList(a);
                                        AdminCRUD.StoreAdminInFile(ExtraBL.GetAdminPath());
                                    }
                                    else if(opt == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                    }
                                }
                            }
                        }
                    }

                    else if(ExtraBL.GetRole() == "hostelite")
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

                                HosteliteUI.SearchByName(ExtraBL.GetHosteliteName());
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

                                Complaints complaint = ComplaintsUI.TakeComplaints(ExtraBL.GetHosteliteName());
                                ComplaintsCRUD.AddComplaitsInList(complaint);
                                ComplaintsCRUD.StoreComplaintsInFile(ExtraBL.GetComplaintsPath());

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
                                 ChallanCRUD.StoreChallansInFile(ExtraBL.GetChallanPath());

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
                                    HosteliteCRUD.DeleteHosteliteFromFile(ExtraBL.getpath());
                                    break;
                                        
                                }
                            }

                            else if(hOption == "8")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //adding reviews
                                Reviews review = ReviewsUI.TakeReviews(ExtraBL.GetReviewsPath());
                                ReviewsCRUD.AddInList(review);
                                ReviewsCRUD.StoreReviewsInFile(ExtraBL.GetReviewsPath());
                                
                            }
                        }
                        
                    }

                    else if(ExtraBL.GetRole() == "Finance")
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
                                string eOption = "0";
                                while (eOption != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    eOption = FinancialRecordUI.FinancialRecordMenu("Expense");
                                    if (eOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        Expense e = ExpenseUI.TakeInputForExpense();
                                        ExpenseCRUD.AddInList(e);
                                        FinancialRecordCRUD.AddInList(e);
                                        ExpenseCRUD.StoreExpensesInFile(ExtraBL.GetExpensePath());
                                    }

                                    else if (eOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        ExpenseUI.ShowExpense();
                                        Console.ReadKey();
                                    }

                                    else if (eOption == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        ExpenseUI.ShowExpense();
                                        int num = FinancialRecordUI.TakeInputForNumber();
                                        ExpenseCRUD.RemoveFromList(num);
                                        ExpenseCRUD.StoreExpensesInFile(ExtraBL.GetExpensePath());

                                    }
                                }
                            }
                            else if (FinanceOption == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                ExpenseUI.ShowExpense();
                                FinancialRecordUI.ShowCalculatedAmount("Expense");

                            }

                            else if (FinanceOption == "3")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                string rOption = "0";
                                while (rOption != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();
                                    rOption = FinancialRecordUI.FinancialRecordMenu("Revenue");
                                    if (rOption == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        Revenue r = RevenueUI.TakeInputForRevenue();
                                        RevenueCRUD.AddInList(r);
                                        FinancialRecordCRUD.AddInList(r);
                                        RevenueCRUD.StoreRevenueInFile(ExtraBL.GetRevenuePath());
                                    }

                                    else if (rOption == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        RevenueUI.ShowRevenue();
                                        Console.ReadKey();
                                    }

                                    else if (rOption == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        RevenueUI.ShowRevenue();
                                        int num = FinancialRecordUI.TakeInputForNumber();
                                        RevenueCRUD.RemoveFromList(num);
                                        FinancialRecordCRUD.RemoveFromList(num);
                                        RevenueCRUD.StoreRevenueInFile(ExtraBL.GetRevenuePath());

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
                                ChallanCRUD.StoreChallansInFile(ExtraBL.GetChallanPath());

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
                                    opt = FinancialRecordUI.ShowMenu();

                                    if (opt == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        FinancialRecordUI.ShowFinancialReprt();
                                        Console.ReadKey();
                                    }
                                    else if (opt == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        FinancialRecordUI.ShowGraph();

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
