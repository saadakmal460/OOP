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
                    ExtraBL.SetHosteliteName(ExtraBL.GetUser());

                    //starting admin menu
                    if(ExtraBL.GetRole() == "admin")
                    {
                        Console.Clear();
                        GeneralUI.Header();
                        GeneralUI.Path();

                        //Admin menu
                        ExtraBL.SetAdminOption("0");
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

                                ExtraBL.SetOptionForNotice("0");
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
                                        Admin.AddNotices((ExtraBL.GetNoticeObj()));
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
                                        ExtraBL.SetIndex(NoticesUI.TakeInputToDeleteNotice());
                                        NoticesCRUD.RemoveANotice(Admin.GetNoticesList() ,ExtraBL.GetIndex());
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

                            //option 6 start
                            else if (ExtraBL.GetAdminOption()== "6")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing complaints
                                ComplaintsUI.ViewComplaints();
                            }

                            //option 7 start
                            else if (ExtraBL.GetAdminOption()== "7")
                            {
                                ExtraBL.SetMessOption("0");
                                
                                while (ExtraBL.GetMessOption() != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //taking mess option
                                    ExtraBL.SetMessOption(MessUI.MessMenu());
                                    

                                    //mess option 1
                                    if (ExtraBL.GetMessOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //viewing mess
                                        MessUI.ViewMess();

                                    }

                                    //mess option 2
                                    else if (ExtraBL.GetMessOption()  == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //taking day as input and uodatin the mess
                                        ExtraBL.SetDay(MessUI.TakeDayAsInput());
                                        ExtraBL.SetFlag(MessUI.UpdateMenu(ExtraBL.GetDay()));
                                        MessCRUD.StoreMessMenuInFile(ExtraBL.GetMessPath());
                                        HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                    }

                                }
                            }


                            //option 8 start
                            else if (ExtraBL.GetAdminOption()== "8")
                            {
                                ExtraBL.SetReportOption("0");
                                while (ExtraBL.GetReportOption() != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //financial report menu
                                    ExtraBL.SetReportOption(FinancialRecordUI.ShowMenu());

                                    if (ExtraBL.GetReportOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //viewing financial report
                                        FinancialRecordUI.ShowFinancialReprt();
                                        Console.ReadKey();
                                    }
                                    else if (ExtraBL.GetReportOption() == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();


                                        //viewing graph
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
                                ExtraBL.SetSearchOption("0");
                                while (ExtraBL.GetSearchOption() != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    ExtraBL.SetSearchOption(HosteliteUI.SearchHosteliteOption());
                                    if (ExtraBL.GetSearchOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //searching by name
                                        ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                        ExtraBL.SetFlag(HosteliteUI.SearchByName(ExtraBL.GetName()));
                                        HosteliteUI.ShowMessage(ExtraBL.GetFlag());

                                    }

                                    else if (ExtraBL.GetSearchOption() == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //searching by roll number
                                        ExtraBL.SetRollNumber(HosteliteUI.TakeRollNumberAsInput());
                                        ExtraBL.SetFlag(HosteliteUI.SearchByRollNumber(ExtraBL.GetRollNumber()));
                                        HosteliteUI.ShowMessage(ExtraBL.GetFlag());
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


                            //option 12 start
                            else if(ExtraBL.GetAdminOption()== "12")
                            {
                                ExtraBL.SetOfficialOption("0");
                                while(ExtraBL.GetOfficialOption() != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //taking option as input
                                    ExtraBL.SetOfficialOption(AdminUI.OfficalMenu());
                                    if (ExtraBL.GetOfficialOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //taking input and adding admin in list 
                                        ExtraBL.SetAdmin(AdminUI.TakeInputForAdmin());
                                        AdminCRUD.AddInList(ExtraBL.GetAdmin());
                                        UserCRUD.AdddInList(ExtraBL.GetAdmin());
                                        AdminCRUD.StoreAdminInFile(ExtraBL.GetAdminPath());
                                    }
                                    else if(ExtraBL.GetOfficialOption()  == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //taking input and adding finance officer in list 

                                    }
                                }
                            }
                        }
                    }


                    //start of hostelite menu
                    else if(ExtraBL.GetRole() == "hostelite")
                    {

                        ExtraBL.SethosteliteOption("0");
                        //starting while loop
                        while(ExtraBL.GethosteliteOption()!= "9")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();

                            //taking option from hostelite menu
                            ExtraBL.SethosteliteOption(HosteliteUI.HosteliteMenu());

                            //hostelite option 1 start
                            if(ExtraBL.GethosteliteOption() == "1")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //Showing hostelite info
                                HosteliteUI.SearchByName(ExtraBL.GetHosteliteName());
                                Console.ReadKey();
                            }

                            //hostelite option 2 start
                            else if (ExtraBL.GethosteliteOption() == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //showing mess
                                MessUI.ViewMess();
                            }

                            //hostelite option 3 start
                            else if (ExtraBL.GethosteliteOption() == "3")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();


                                //adding complaints and storing in list
                                ExtraBL.SetComplaints(ComplaintsUI.TakeComplaints(ExtraBL.GetHosteliteName()));
                                ComplaintsCRUD.AddComplaitsInList(ExtraBL.GetComplaints());
                                ComplaintsCRUD.StoreComplaintsInFile(ExtraBL.GetComplaintsPath());

                            }

                            //hostelite option 4 start
                            else if (ExtraBL.GethosteliteOption() == "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //viewing notice
                                NoticesUI.ViewNotices();
                                Console.ReadKey();
                            }

                            //hostelite option 5 start
                            else if (ExtraBL.GethosteliteOption() == "5")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //paying fee
                                 PayFeeUI.TakeInputForPayFee();
                                 ChallanCRUD.StoreChallansInFile(ExtraBL.GetChallanPath());

                            }

                            //hostelite option 7 start
                            else if (ExtraBL.GethosteliteOption() == "7")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //showing warning
                                ExtraBL.SetHostelitedecision(HosteliteUI.ShowWarning());
                                if (ExtraBL.GetHostelitedecision() == "Yes")
                                {
                                    //taking name and then removing
                                    ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                    ExtraBL.SetFlag(HosteliteCRUD.RemoveFromHosteliteList(ExtraBL.GetName()));
                                    HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                    HosteliteCRUD.DeleteHosteliteFromFile(ExtraBL.getpath());
                                    break;
                                        
                                }
                            }

                            //hostelite option 8 start
                            else if (ExtraBL.GethosteliteOption() == "8")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //adding reviews
                                ExtraBL.SetReviews(ReviewsUI.TakeReviews(ExtraBL.GetReviewsPath()));
                                ReviewsCRUD.AddInList(ExtraBL.GetReviews());
                                ReviewsCRUD.StoreReviewsInFile(ExtraBL.GetReviewsPath());
                                
                            }
                        }
                        
                    }

                    //start of finance menu
                    else if(ExtraBL.GetRole() == "Finance")
                    {
                        ExtraBL.SetFinanaceOption("0");
                        //starting of finanace menu loop
                        while(ExtraBL.GetFinanceOption() != "10")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();

                            //taking option input from finance menu
                            ExtraBL.SetFinanaceOption(FinanceUI.FinanceMenu());

                            //finance option 1
                            if (ExtraBL.GetFinanceOption() == "1")
                            {
                                //starting of expense loop
                                ExtraBL.SetExpenseOption("0");
                                while (ExtraBL.GetExpenseOption()!= "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //taking option from expense menu
                                    ExtraBL.SetExpenseOption(FinancialRecordUI.FinancialRecordMenu("Expense"));

                                    //expense option 1
                                    if (ExtraBL.GetExpenseOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //taking expenses as input and adding in list
                                        ExtraBL.SetExpense(ExpenseUI.TakeInputForExpense());
                                        ExpenseCRUD.AddInList(ExtraBL.GetExpense());
                                        FinancialRecordCRUD.AddInList(ExtraBL.GetExpense());
                                        ExpenseCRUD.StoreExpensesInFile(ExtraBL.GetExpensePath());
                                    }

                                    //expense option 2
                                    else if (ExtraBL.GetExpenseOption() == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //showing expenses
                                        ExpenseUI.ShowExpense();
                                        Console.ReadKey();
                                    }

                                    //expense option 3
                                    else if (ExtraBL.GetExpenseOption() == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //removing the expense by taking its number
                                        ExpenseUI.ShowExpense();
                                        ExtraBL.SetIndex(FinancialRecordUI.TakeInputForNumber());
                                        ExpenseCRUD.RemoveFromList(ExtraBL.GetIndex());
                                        ExpenseCRUD.StoreExpensesInFile(ExtraBL.GetExpensePath());

                                    }
                                }
                            }

                            //finance option 2
                            else if (ExtraBL.GetFinanceOption() == "2")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //showing calulated expense
                                ExpenseUI.ShowExpense();
                                FinancialRecordUI.ShowCalculatedAmount("Expense");

                            }


                            //finance option 3
                            else if (ExtraBL.GetFinanceOption() == "3")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //starting revenue loop
                                ExtraBL.SetRevenueOption("0");
                                while (ExtraBL.GetRevenueOption() != "4")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //taking input from revenue menu
                                    ExtraBL.SetRevenueOption(FinancialRecordUI.FinancialRecordMenu("Revenue"));


                                    //revenue option 1
                                    if (ExtraBL.GetRevenueOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //taking revenue as input and adding in list
                                        ExtraBL.SetRevenue(RevenueUI.TakeInputForRevenue());
                                        RevenueCRUD.AddInList(ExtraBL.GetRevenue());
                                        FinancialRecordCRUD.AddInList(ExtraBL.GetRevenue());
                                        RevenueCRUD.StoreRevenueInFile(ExtraBL.GetRevenuePath());
                                    }

                                    //revenue option 2
                                    else if (ExtraBL.GetRevenueOption()  == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //showing revenue
                                        RevenueUI.ShowRevenue();
                                        Console.ReadKey();
                                    }

                                    //revenue option 3
                                    else if (ExtraBL.GetRevenueOption()  == "3")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //removing revenue
                                        RevenueUI.ShowRevenue();
                                        ExtraBL.SetIndex(FinancialRecordUI.TakeInputForNumber());
                                        RevenueCRUD.RemoveFromList(ExtraBL.GetIndex());
                                        FinancialRecordCRUD.RemoveFromList(ExtraBL.GetIndex());
                                        RevenueCRUD.StoreRevenueInFile(ExtraBL.GetRevenuePath());

                                    }

                                }
                            }

                            //finance option 4
                            else if (ExtraBL.GetFinanceOption() == "4")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //generating challan and overwriting by checking
                                ExtraBL.SetRollNumber(HosteliteUI.TakeRollNumberAsInput());
                                ExtraBL.SetFlag(ChallanUI.CheckInChallanList(ExtraBL.GetRollNumber()));
                                ExtraBL.SetChallan(ChallanUI.TakeChallanInput(ExtraBL.GetRollNumber()));
                                ChallanCRUD.StoreChallansInFile(ExtraBL.GetChallanPath());

                                if (ExtraBL.GetFlag())
                                {
                                    ChallanCRUD.AddChallanInList(ExtraBL.GetChallan());
                                }


                            }

                            //finance option 5
                            else if (ExtraBL.GetFinanceOption() == "5")
                            {
                                Console.Clear();
                                GeneralUI.Header();
                                GeneralUI.Path();

                                //showing student fee status
                                ChallanUI.ShowFee();
                            }

                            //finance option 6
                            else if (ExtraBL.GetFinanceOption() == "6")
                            {
                                ExtraBL.SetReportOption("0");
                                while (ExtraBL.GetReportOption() != "3")
                                {
                                    Console.Clear();
                                    GeneralUI.Header();
                                    GeneralUI.Path();

                                    //financial report menu
                                    ExtraBL.SetReportOption(FinancialRecordUI.ShowMenu());

                                    if (ExtraBL.GetReportOption() == "1")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();

                                        //viewing financial report
                                        FinancialRecordUI.ShowFinancialReprt();
                                        Console.ReadKey();
                                    }
                                    else if (ExtraBL.GetReportOption() == "2")
                                    {
                                        Console.Clear();
                                        GeneralUI.Header();
                                        GeneralUI.Path();


                                        //viewing graph
                                        FinancialRecordUI.ShowGraph();

                                    }
                                }
                            }
                            

                            else if (ExtraBL.GetFinanceOption() == "8")
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
