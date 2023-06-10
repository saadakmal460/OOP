using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Admin
    {
        private Notices notices;
        public Admin(Notices n)
        {
            notices = new Notices(n.GetTitle(), n.GetNotice());
        }
    }
}
