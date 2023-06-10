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

            //Loading data
            HosteliteCRUD.LoadHostelitesFromFile(path);
            NoticesCRUD.LoadNoticesFromFile(pathNotices);
          
            //main while loop
            while(option!=2)
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
                    
                    //starting admin menu
                    if(role == "admin")
                    {
                        Console.Clear();
                        GeneralUI.Header();
                        GeneralUI.Path();

                        //Admin menu
                        string optionAdmin = "0";
                        //stating admin menu loop
                        while(optionAdmin != "10")
                        {
                            Console.Clear();
                            GeneralUI.Header();
                            GeneralUI.Path();
                            //options for admin screen
                            optionAdmin = AdminUI.PrintMenuForAdmin();
                            //option 1 start
                            if(optionAdmin == "1")
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
                                while(noticeOption != "4")
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
                            //option 6 start
                            else if(optionAdmin == "7")
                            {

                            }
                        }
                    }
                    else
                    {
                        GeneralUI.Header();
                        GeneralUI.Path();
                        Console.WriteLine("hello ");
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
