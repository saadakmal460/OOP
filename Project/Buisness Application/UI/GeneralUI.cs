using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class GeneralUI
    {

        public static void GeneralFunctions(string path)
        {
            Console.Clear();
            Header();
            Path(path);
        }
        public static void Header()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\t \t \t ##     ##  ####     ####    ######       ");
            Console.WriteLine("\t \t \t ##     ##  ##  ## ##  ##  ##             ");
            Console.WriteLine("\t \t \t #########  ##    #    ##    ##           ");
            Console.WriteLine("\t \t \t ##     ##  ##         ##      ##         ");
            Console.WriteLine("\t \t \t ##     ##  ##         ##  ######         ");

            Console.WriteLine("\t \t. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
            Console.WriteLine("\t \t. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
            Console.WriteLine("\t \t. .                                                         . .");
            Console.WriteLine("\t \t. .                                                         . .");
            Console.WriteLine("\t \t. .                                                         . .");
            Console.WriteLine("\t \t. .           WELCOME TO HOSTEL MANAGEMENT SYSTEM           . .");
            Console.WriteLine("\t \t. .                                                         . .");
            Console.WriteLine("\t \t. .                                                         . .");
            Console.WriteLine("\t \t. .                                                         . .");
            Console.WriteLine("\t \t. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
            Console.WriteLine("\t \t. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
            Console.WriteLine("");

            Console.ResetColor();
        }


        public static void Path(string path)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.WriteLine("\tLogin > " + path);
            Console.WriteLine("");
            Console.ResetColor();
        }

        public static string LoginScreen()
        {
            
            string option;
            Console.WriteLine(" ");
            Console.WriteLine("\t1.LogIN");
            Console.WriteLine("\t2.Exit");
            Console.Write("\tEnter option: ");
            option = Console.ReadLine();
            return option;
            

        }
    }
}
