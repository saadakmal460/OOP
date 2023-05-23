using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_week_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();

            //int num1, num2 , result = 0;
            //Console.WriteLine("Enter first number: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //num2 = int.Parse(Console.ReadLine());

            //result = Task10(num1, num2);
            //Console.WriteLine("Sum is:{0}" , result);

            Task12();
            Task11();
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.Write("Hello World!!");
            Console.Write("Hello World!!");
            
        }

        static void Task2()
        {
            Console.WriteLine("Hello World!!");
            Console.Write("Hello World!!");
        }

        static void Task3()
        {
            float area , length;
            Console.Write("Enter length of square: ");
            length = float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area is : {0}", area);
        }

        static void Task4()
        {
            float marks;
            Console.Write("Enter marks: ");
            marks = float.Parse(Console.ReadLine());
            if(marks > 50)
            {
                Console.Write("You are passed");
            }
            else
            {
                Console.Write("You are faild");
            }
        }


        static void Task5()
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Hello Jack");
            }
        }


        static void Task6()
        {
            int num , sum = 0;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            while(num != -1)
            {
                sum = sum + num;
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Write("Sum is {0}" , sum);

        }


        static void Task7()
        {
            int num, sum = 0;
            do
            {
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            } while (num != -1);

            sum = sum + 1;
            Console.Write("Sum is {0}", sum);

        }

        static void Task8()
        {
            int[] num = new int[3];
            for(int i =0; i<3; i++)
            {
                Console.WriteLine("Enter number: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if(num[i] > largest)
                {
                    largest = num[i];
                }
            }
            Console.WriteLine("Largest number is: {0}", largest);
        }

        static void Task9()
        {
            float price;
            int age , amount = 0 , toy;
            Console.WriteLine("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of machine: ");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter unit price of toy: ");
            toy = int.Parse(Console.ReadLine());

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    amount = amount + 10 * (i / 2);
                    amount = amount - 1;
                }
                else
                {
                    amount = amount + toy;
                }
            }
            if(price > amount)
            {
                Console.Write("Not enough money");
            }
            else
            {
                Console.Write("Yes! You can buy");
            }

        }


        static int Task10(int num1 , int num2)
        {
            int add = num1 + num2;
            return add;
        }


        static void Task11()
        {
            string path = "D:\\2nd Semester\\OOP\\Lab week 1\\textFile.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        static void Task12()
        {
            string path = "D:\\2nd Semester\\OOP\\Lab week 1\\textFile.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.Write("Hello");
            file.Flush();
            file.Close();
        }
    }
}
