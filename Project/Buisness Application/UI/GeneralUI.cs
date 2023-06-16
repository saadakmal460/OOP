using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class GeneralUI
    {

        public static void GeneralFunctions()
        {
            Console.Clear();
            Header();
            Path();
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


        public static void Path()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.WriteLine("\tLogin > ");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public static int LoginScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int option;
            Console.WriteLine(" ");
            Console.WriteLine("\t1.LogIN");
            Console.WriteLine("\t2.Exit");
            Console.Write("\tEnter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
            Console.ResetColor();

        }
    }
}
