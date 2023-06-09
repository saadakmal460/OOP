using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class HosteliteCRUD
    {
        public static List<Hostelite> hostelitesList = new List<Hostelite>();
        
        public static void AddHosteliteInList(Hostelite h)
        {
            hostelitesList.Add(h);
        }

        public static bool RemoveFromHosteliteList(string name)
        {
           bool flag = false;
           for(int i = 0; i<hostelitesList.Count; i++)
           {
                if(name == hostelitesList[i].GetUsername())
                {
                    hostelitesList.RemoveAt(i);
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
           }
            return flag;
        }
    }
}
