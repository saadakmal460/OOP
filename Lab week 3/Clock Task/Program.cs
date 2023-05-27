using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Task
{
    class Program
    {
        
        class ClockType
        {

            public int timeDifference(ClockType temp)
            {
                int time1 = elapsedTime();
                int time2 = temp.elapsedTime();
                int diff = time1 - time2;
                

                return diff;
            }
            public int remainingTime()
            {
                int total;
                total = hour * 3600 + min * 60 + sec;
                total = 86400 - total;
                return total;
            }
            public int elapsedTime()
            {
                int total;
                total = hour * 3600 + min * 60 + sec;
                return total;
            }
            public void printTime()
            {
                Console.WriteLine(hour + " " + min + " " + sec);
            }
            public bool Check(ClockType temp)
            {
                bool flag;
                if(temp.hour == hour && temp.min == min && temp.sec == sec)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                return flag;
            }
            public bool isEqual(int h , int m , int s)
            {
                bool flag;
                if(h == hour  && m == min && s == sec)
                {
                    flag =  true;
                }
                else
                {
                    flag = false;
                }

                return flag;
            }
            public void incrementSecond()
            {
                sec++;
            }
            public void incrementMin()
            {
                min++;
            }
            public void incrementHour()
            {
                hour++;
            }
            public ClockType(int h, int m , int s)
            {
                hour = h;
                min = m;
                sec = s;
            }
            public ClockType(int h , int m)
            {
                hour = h;
                min = m;
            }
            public ClockType(int h)
            {
                hour = h;
            }
            public ClockType()
            {
                hour = 0;
                min = 0;
                sec = 0;
            }
            public int hour;
            public int min;
            public int sec;

        }
        static void Main(string[] args)
        {
            bool flag1;
            bool flag2;
            int result = 0;
            int remainingTime = 0;

            ClockType c = new ClockType();
            Console.Write("Default time : ");
            c.printTime();

            ClockType c2 = new ClockType(5);
            Console.Write("Hour time : ");
            c2.printTime();

            ClockType c3 = new ClockType(5 , 10);
            Console.Write("Minute time : ");
            c3.printTime();

            ClockType c4 = new ClockType(5, 10 ,13);

            Console.Write("Full time: ");
            c4.printTime();

            c4.incrementHour();
            Console.Write("Increment Hour: ");
            c4.printTime();

            c4.incrementMin();
            Console.Write("Increment Minutes: ");
            c4.printTime();

            c4.incrementSecond();
            Console.Write("Increment seconds: ");
            c4.printTime();

            flag1 = c4.isEqual(12, 11, 1);
            Console.WriteLine("Flag: " + flag1);

            ClockType c5 = new ClockType(4, 2, 7);
            flag2 = c5.Check(c5);
            Console.WriteLine("Object Flag: " + flag2);

            ClockType c6 = new ClockType(12, 12, 12);
            result = c6.elapsedTime();
            remainingTime = c6.remainingTime();

            Console.WriteLine("Elapsed Time: " + result + " seconds");
            Console.WriteLine("Remaining Time: " + remainingTime + " seconds");

            int diff = c6.timeDifference(c5);
            Console.WriteLine("Time difference: " + diff + "seconds");

            Console.ReadKey();
        }
    }
}
