using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class ReviewsDL
    {
        

        public static void StoreReviewsInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Reviews i in Hostelite.GetReviewList())
            {
                file.WriteLine(i.GetName() + "," + i.GetRating() + "," + i.GetReviews());
            }
            file.Flush();
            file.Close();
        }
        public static void LoadReviewsFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string rating= Parsing(record, 2);
                    string reviews = Parsing(record, 3);

                    Reviews r = new Reviews(name, rating, reviews);
                    Hostelite.AddInList(r);
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static string Parsing(string record, int field)
        {
            int count = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    count++;
                }
                else if (count == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }
}
