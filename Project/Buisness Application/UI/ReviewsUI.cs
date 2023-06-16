using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class ReviewsUI
    {
        public static Reviews TakeReviews(string name)
        {
            Console.Write("\t Enter rating (1-5 Stars): ");
            string rating = Console.ReadLine();

            Console.Write("Enter Reviews: ");
            string review = Console.ReadLine();

            Reviews r = new Reviews(name, rating, review);
            return r;
        }

        public static void ViewAllReviews()
        {
            Console.WriteLine("Reviews: ");

            Console.WriteLine("");
            Console.WriteLine("Name\t\tRatings\t\tReviews");
            foreach(Reviews i in Hostelite.GetReviewList())
            {
                Console.WriteLine(i.GetName() + "\t\t" + i.GetRating() + "\t\t" + i.GetReviews());
            }
            Console.ReadKey();
        }
    }
}
