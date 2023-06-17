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
            UserDL.LoadUsersFromFile(ExtraBL.GetUsersPath());
            NoticesDL.LoadNoticesFromFile(ExtraBL.GetNoticesPath());
            MessCRUD.LoadMessMenuFromFile(ExtraBL.GetMessPath());
            ComplaintsDL.LoadComplaintsFromFile(ExtraBL.GetComplaintsPath());
            ReviewsDL.LoadReviewsFromFile(ExtraBL.GetReviewsPath());
            ChallanDL.LoadChallansFromFile(ExtraBL.GetChallanPath());
            FinancialRecordDL.LoadFinancialRecordFromFile(ExtraBL.GetRecordPath());

            

            //main while loop
            while (ExtraBL.GetOption() !=2)
            {
                //clearing and printing header
                GeneralUI.GeneralFunctions();

                //Login screen
                ExtraBL.setOption(GeneralUI.LoginScreen());
                if(ExtraBL.GetOption() == 1)
                {
                    GeneralUI.GeneralFunctions();

                    //Taking username and password
                    ExtraBL.SetUser(UserUI.TakeInputForLogin());
                    ExtraBL.SetHosteliteName(ExtraBL.GetUser());

                    //starting admin menu
                    if(ExtraBL.GetRole() == "admin")
                    {
                        GeneralUI.GeneralFunctions();

                        //Admin menu
                        ExtraBL.SetAdminOption("0");
                        //stating admin menu loop
                        while(ExtraBL.GetAdminOption() != "13")
                        {
                            GeneralUI.GeneralFunctions();
                            
                            
                            //options for admin screen
                            ExtraBL.SetAdminOption(AdminUI.PrintMenuForAdmin());
                            //option 1 start
                            if (ExtraBL.GetAdminOption() == "1")
                            {
                                GeneralUI.GeneralFunctions();
                                
                                

                                //adding hostelite
                                ExtraBL.SetHostelite(HosteliteUI.TakeInputForHostelite());
                                UserDL.AdddInList(ExtraBL.GetHosteliteObj());
                                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());

                            }

                            //option 2 start
                            else if (ExtraBL.GetAdminOption() == "2")
                            {
                                GeneralUI.GeneralFunctions();
                                
                                //removing hostelite by taking name
                                ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                ExtraBL.SetFlag(UserDL.RemoveUserFromList(ExtraBL.GetName()));
                                HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());

                            }
                            //option 3 start
                            else if (ExtraBL.GetAdminOption()== "3")
                            {
                                GeneralUI.GeneralFunctions();
                                
                                

                                //Updating records
                                ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                ExtraBL.SetFlag(HosteliteUI.UpdateRecord(ExtraBL.GetName()));
                                HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
                            }
                            //option 4 start
                            else if (ExtraBL.GetAdminOption()== "4")
                            {
                                GeneralUI.GeneralFunctions();

                                //viewing hostelites
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
                                    GeneralUI.GeneralFunctions();

                                    //notice board operations
                                    ExtraBL.SetOptionForNotice(AdminUI.NoticeMenu());

                                    //option 1 of notices
                                    if (ExtraBL.GetOptionForNotice() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //adding notice
                                        ExtraBL.SetNoticeObj(NoticesUI.TakeInputForNotices());
                                        Admin.AddNotices((ExtraBL.GetNoticeObj()));
                                        NoticesDL.StoreNoticesInFile(ExtraBL.GetNoticesPath());

                                    }
                                    //option 2 of notices
                                    else if (ExtraBL.GetOptionForNotice() == "2")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //deleting notices
                                        NoticesUI.ViewNotices();
                                        ExtraBL.SetIndex(NoticesUI.TakeInputToDeleteNotice());
                                        NoticesDL.RemoveANotice(Admin.GetNoticesList() ,ExtraBL.GetIndex());
                                        NoticesDL.StoreNoticesInFile(ExtraBL.GetNoticesPath());
                                    }
                                    //option 3 of notices
                                    else if (ExtraBL.GetOptionForNotice() == "3")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //viewing notice
                                        NoticesUI.ViewNotices();
                                        Console.ReadKey();
                                    }
                                }
                            }

                            //option 6 start
                            else if (ExtraBL.GetAdminOption()== "6")
                            {
                                GeneralUI.GeneralFunctions();

                                //viewing complaints
                                ComplaintsUI.ViewComplaints();
                            }

                            //option 7 start
                            else if (ExtraBL.GetAdminOption()== "7")
                            {
                                ExtraBL.SetMessOption("0");
                                
                                while (ExtraBL.GetMessOption() != "3")
                                {
                                    GeneralUI.GeneralFunctions();

                                    //taking mess option
                                    ExtraBL.SetMessOption(MessUI.MessMenu());
                                    

                                    //mess option 1
                                    if (ExtraBL.GetMessOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //viewing mess
                                        MessUI.ViewMess();

                                    }

                                    //mess option 2
                                    else if (ExtraBL.GetMessOption()  == "2")
                                    {
                                        GeneralUI.GeneralFunctions();
   
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
                                    GeneralUI.GeneralFunctions();

                                    //financial report menu
                                    ExtraBL.SetReportOption(FinancialRecordUI.ShowMenu());

                                    if (ExtraBL.GetReportOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //viewing financial report
                                        FinancialRecordUI.ShowFinancialReprt();
                                        Console.ReadKey();
                                    }
                                    else if (ExtraBL.GetReportOption() == "2")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //viewing graph
                                        FinancialRecordUI.ShowGraph();

                                    }
                                }
                            }

                            //option 9 start
                            else if (ExtraBL.GetAdminOption()== "9")
                            {
                                GeneralUI.GeneralFunctions();

                                //viewing alloted rooms
                                HosteliteUI.ViewHostelitesRooms();
                            }

                            //option 10 start
                            else if (ExtraBL.GetAdminOption()== "10")
                            {
                                GeneralUI.GeneralFunctions();

                                //search menu
                                ExtraBL.SetSearchOption("0");
                                while (ExtraBL.GetSearchOption() != "3")
                                {
                                    GeneralUI.GeneralFunctions();

                                    ExtraBL.SetSearchOption(HosteliteUI.SearchHosteliteOption());
                                    if (ExtraBL.GetSearchOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //searching by name
                                        ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                        ExtraBL.SetFlag(HosteliteUI.SearchByName(ExtraBL.GetName()));
                                        HosteliteUI.ShowMessage(ExtraBL.GetFlag());

                                    }

                                    else if (ExtraBL.GetSearchOption() == "2")
                                    {
                                        GeneralUI.GeneralFunctions();
 
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
                                GeneralUI.GeneralFunctions();

                                //View reviews and ratings
                                ReviewsUI.ViewAllReviews();

                            }


                            //option 12 start
                            else if(ExtraBL.GetAdminOption()== "12")
                            {
                                ExtraBL.SetOfficialOption("0");
                                while(ExtraBL.GetOfficialOption() != "3")
                                {
                                    GeneralUI.GeneralFunctions();

                                    //taking option as input
                                    ExtraBL.SetOfficialOption(AdminUI.OfficalMenu());
                                    if (ExtraBL.GetOfficialOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();
                                        

                                        //taking input and adding admin in list 
                                        ExtraBL.SetAdmin(AdminUI.TakeInputForAdmin());
                                        UserDL.AdddInList(ExtraBL.GetAdmin());
                                        UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
                                    }
                                    else if(ExtraBL.GetOfficialOption()  == "2")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //taking input and adding finance officer in list 
                                        ExtraBL.SetFinance(FinanceUI.TakeInputForFinanceEmployeee());
                                        UserDL.AdddInList(ExtraBL.GetFinance());
                                        UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
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
                            GeneralUI.GeneralFunctions();

                            //taking option from hostelite menu
                            ExtraBL.SethosteliteOption(HosteliteUI.HosteliteMenu());

                            //hostelite option 1 start
                            if(ExtraBL.GethosteliteOption() == "1")
                            {
                                GeneralUI.GeneralFunctions();

                                //Showing hostelite info
                                HosteliteUI.SearchByName(ExtraBL.GetHosteliteName());
                                Console.ReadKey();
                            }

                            //hostelite option 2 start
                            else if (ExtraBL.GethosteliteOption() == "2")
                            {
                                GeneralUI.GeneralFunctions();

                                //showing mess
                                MessUI.ViewMess();
                            }

                            //hostelite option 3 start
                            else if (ExtraBL.GethosteliteOption() == "3")
                            {
                                GeneralUI.GeneralFunctions();

                                //adding complaints and storing in list
                                ExtraBL.SetComplaints(ComplaintsUI.TakeComplaints(ExtraBL.GetHosteliteName()));
                                Hostelite.AddComplaintsInList(ExtraBL.GetComplaints());
                                ComplaintsDL.StoreComplaintsInFile(ExtraBL.GetComplaintsPath());

                            }

                            //hostelite option 4 start
                            else if (ExtraBL.GethosteliteOption() == "4")
                            {
                                GeneralUI.GeneralFunctions();

                                //viewing notice
                                NoticesUI.ViewNotices();
                                Console.ReadKey();
                            }

                            //hostelite option 5 start
                            else if (ExtraBL.GethosteliteOption() == "5")
                            {
                                GeneralUI.GeneralFunctions();

                                //paying fee
                                 PayFeeUI.TakeInputForPayFee();
                                 ChallanDL.StoreChallansInFile(ExtraBL.GetChallanPath());

                            }

                            //hostelite option 7 start
                            else if (ExtraBL.GethosteliteOption() == "7")
                            {
                                GeneralUI.GeneralFunctions();

                                //showing warning
                                ExtraBL.SetHostelitedecision(HosteliteUI.ShowWarning());
                                if (ExtraBL.GetHostelitedecision() == "Yes")
                                {
                                    //taking name and then removing
                                    ExtraBL.SetName(HosteliteUI.TakeNameAsInput());
                                    ExtraBL.SetFlag(UserDL.RemoveUserFromList(ExtraBL.GetName()));
                                    HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                    UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
                                    break;
                                        
                                }
                            }

                            //hostelite option 8 start
                            else if (ExtraBL.GethosteliteOption() == "8")
                            {
                                GeneralUI.GeneralFunctions();

                                //adding reviews
                                ExtraBL.SetReviews(ReviewsUI.TakeReviews(ExtraBL.GetReviewsPath()));
                                Hostelite.AddInList((ExtraBL.GetReviews()));
                                ReviewsDL.StoreReviewsInFile(ExtraBL.GetReviewsPath());
                                
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
                            GeneralUI.GeneralFunctions();
 
                            //taking option input from finance menu
                            ExtraBL.SetFinanaceOption(FinanceUI.FinanceMenu());

                            //finance option 1
                            if (ExtraBL.GetFinanceOption() == "1")
                            {
                                //starting of expense loop
                                ExtraBL.SetExpenseOption("0");
                                while (ExtraBL.GetExpenseOption()!= "4")
                                {
                                    GeneralUI.GeneralFunctions();
                                    
                                    //taking option from expense menu
                                    ExtraBL.SetExpenseOption(FinancialRecordUI.FinancialRecordMenu("Expense"));

                                    //expense option 1
                                    if (ExtraBL.GetExpenseOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //taking expenses as input and adding in list
                                        ExtraBL.SetExpense(ExpenseUI.TakeInputForExpense());
                                        FinancialRecordDL.AddInList(ExtraBL.GetExpense());
                                        FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());
                                    }

                                    //expense option 2
                                    else if (ExtraBL.GetExpenseOption() == "2")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //showing expenses
                                        ExpenseUI.ShowExpense();
                                        Console.ReadKey();
                                    }

                                    //expense option 3
                                    else if (ExtraBL.GetExpenseOption() == "3")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //removing the expense by taking its number
                                        ExpenseUI.ShowExpense();
                                        ExtraBL.SetFrName(FinancialRecordUI.TakeRecordName());
                                        ExtraBL.SetFlag(FinancialRecordDL.RemoveFromList(ExtraBL.GetFrName()));
                                        HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                        FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());

                                    }
                                }
                            }

                            //finance option 2
                            else if (ExtraBL.GetFinanceOption() == "2")
                            {
                                GeneralUI.GeneralFunctions();

                                //showing calulated expense
                                ExpenseUI.ShowExpense();
                                FinancialRecordUI.ShowCalculatedAmount("Expense");
                                Console.ReadKey();
                            }


                            //finance option 3
                            else if (ExtraBL.GetFinanceOption() == "3")
                            {
                                GeneralUI.GeneralFunctions();
                                

                                //starting revenue loop
                                ExtraBL.SetRevenueOption("0");
                                while (ExtraBL.GetRevenueOption() != "4")
                                {
                                    GeneralUI.GeneralFunctions();
                                    
                                    //taking input from revenue menu
                                    ExtraBL.SetRevenueOption(FinancialRecordUI.FinancialRecordMenu("Revenue"));

                                    //revenue option 1
                                    if (ExtraBL.GetRevenueOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //taking revenue as input and adding in list
                                        ExtraBL.SetRevenue(RevenueUI.TakeInputForRevenue());
                                        FinancialRecordDL.AddInList(ExtraBL.GetRevenue());
                                        FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());
                                    }

                                    //revenue option 2
                                    else if (ExtraBL.GetRevenueOption()  == "2")
                                    {
                                        GeneralUI.GeneralFunctions();
                                        
                                        //showing revenue
                                        RevenueUI.ShowRevenue();
                                        Console.ReadKey();
                                    }

                                    //revenue option 3
                                    else if (ExtraBL.GetRevenueOption()  == "3")
                                    {
                                        GeneralUI.GeneralFunctions();

                                        //removing revenue
                                        RevenueUI.ShowRevenue();
                                        ExtraBL.SetFrName(FinancialRecordUI.TakeRecordName());
                                        ExtraBL.SetFlag(FinancialRecordDL.RemoveFromList(ExtraBL.GetFrName()));
                                        HosteliteUI.ShowMessage(ExtraBL.GetFlag());
                                        FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());

                                    }

                                }
                            }

                            //finance option 4
                            else if (ExtraBL.GetFinanceOption() == "4")
                            {
                                GeneralUI.GeneralFunctions();

                                //generating challan and overwriting by checking
                                ExtraBL.SetRollNumber(HosteliteUI.TakeRollNumberAsInput());
                                ExtraBL.SetFlag(ChallanDL.CheckInChallanList(ExtraBL.GetRollNumber()));
                                ExtraBL.SetChallan(ChallanUI.TakeChallanInput(ExtraBL.GetRollNumber()));
                                ChallanDL.StoreChallansInFile(ExtraBL.GetChallanPath());

                                if (ExtraBL.GetFlag())
                                {
                                    ChallanDL.AddChallanInList(ExtraBL.GetChallan());
                                }


                            }

                            //finance option 5
                            else if (ExtraBL.GetFinanceOption() == "5")
                            {
                                GeneralUI.GeneralFunctions();
 
                                //showing student fee status
                                ChallanUI.ShowFee();
                            }

                            //finance option 6
                            else if (ExtraBL.GetFinanceOption() == "6")
                            {
                                ExtraBL.SetReportOption("0");
                                while (ExtraBL.GetReportOption() != "3")
                                {
                                    GeneralUI.GeneralFunctions();

                                    //financial report menu
                                    ExtraBL.SetReportOption(FinancialRecordUI.ShowMenu());

                                    if (ExtraBL.GetReportOption() == "1")
                                    {
                                        GeneralUI.GeneralFunctions();
                                        
                                        //viewing financial report
                                        FinancialRecordUI.ShowFinancialReprt();
                                        Console.ReadKey();
                                    }
                                    else if (ExtraBL.GetReportOption() == "2")
                                    {
                                        GeneralUI.GeneralFunctions();
      
                                        //viewing graph
                                        FinancialRecordUI.ShowGraph();

                                    }
                                }
                            }
                            

                            else if (ExtraBL.GetFinanceOption() == "8")
                            {
                                GeneralUI.GeneralFunctions();
  
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
