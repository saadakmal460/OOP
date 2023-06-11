using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Mess
    {
        private string dish;
        private string day;

        public Mess(string day , string dish)
        {
            this.dish = dish;
            this.day = day;
        }

       
        public void SetDish(string dish)
        {
            this.dish = dish;
        }

        public string GetDish()
        {
            return dish;
        }

        public void SetDay(string day)
        {
            this.day = day;
        }

        public string GetDay()
        {
            return day;
        }
    }
}
