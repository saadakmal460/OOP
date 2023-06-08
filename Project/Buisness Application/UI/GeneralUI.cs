using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class GeneralUI
    {
        public static void Header()
        {
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

        }

        public static void Path()
        {
            Console.WriteLine(" ");
            Console.WriteLine("\tLogin > ");
        }

        public static int LoginScreen()
        {
            int option;
            Console.WriteLine(" ");
            Console.WriteLine("\t1.LogIN");
            Console.WriteLine("\t2.Exit");
            Console.Write("\tEnter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
