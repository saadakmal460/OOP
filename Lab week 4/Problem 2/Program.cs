using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class Program
    {
        class Book
        {
            public void SetBookPrice(int newPrice)
            {
                price = newPrice;
            }
            public int GetPrice()
            {
                return price;
            }
            public void SetBookMark(int number)
            {
                bookMarks = number;
            }
            public int GetBookMark()
            {
                return bookMarks;
            }
            public string getChapter(int n)
            {
                n = n - 1;
                string chapter = "";
                for (int i = 0; i < Chapters.Count; i++)
                {
                    if (i == n)
                    {
                        chapter = Chapters[i];
                        break;
                    }
                }
                return chapter;
            }
            public Book(string a, int p, List<string> c, int b, int pr)
            {
                author = a;
                pages = p;
                Chapters = c;
                bookMarks = b;
                price = pr;
            }
            public string author;
            public int pages;
            public List<string> Chapters;
            public int bookMarks;
            public int price;
        }
        static void Main(string[] args)
        {
            List<string> chapters = new List<string>();
            chapters.Add("Physics");
            chapters.Add("Song of ice and fire");
            Book b = new Book("Saad", 450, chapters, 243, 1000);
            string c = b.getChapter(1);
            Console.WriteLine("Chapter is: " + c);

            int bm = b.GetBookMark();
            Console.WriteLine("Book Marks is at: " + bm);

            b.SetBookMark(300);
            Console.WriteLine("New bookMark set = 300");

            int p = b.GetPrice();
            Console.WriteLine("Price of book is: " + p);

            b.SetBookPrice(1500);
            Console.WriteLine("New book price seted = 1500");

            Console.ReadKey();
        }
    }
}
