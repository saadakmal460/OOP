using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Complaints
    {
        private string complaint;
        private string name;

        public Complaints(string name , string complaint)
        {
            this.name = name;
            this.complaint = complaint;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetComplaint(string complaint)
        {
            this.complaint = complaint;
        }

        public string GetComplaint()
        {
            return complaint;
        }
    }
}
