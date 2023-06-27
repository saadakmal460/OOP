using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Reviews
    {
        private string name;
        private string rating;
        private string reviews;

        public Reviews(string name , string rating , string reviews)
        {
            this.name = name;
            this.rating = rating;
            this.reviews = reviews;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }


        public void SetRating(string rating)
        {
            this.rating = rating;
        }
        public string GetRating()
        {
            return rating;
        }

        public void SetReview(string reviews)
        {
            this.reviews = reviews;
        }
        public string GetReviews()
        {
            return reviews;
        }
    }
}
