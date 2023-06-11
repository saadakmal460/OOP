using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Notices
    {
        private string title;
        private string notice;

        public Notices(string title , string notice)
        {
            this.title = title;
            this.notice = notice;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return title;
        }

        public void SetNotice(string notice)
        {
            this.notice = notice;
        }
        public string GetNotice()
        {
            return notice;
        }
    }
}
