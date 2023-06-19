using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Data
    {
        private static List<string> dataList = new List<string>();

        public static List<string> DataList { get => dataList; set => dataList = value; }

        public static void AddInList()
        {
            DataList.Add("saad");
        }

        public static List<string> GetList()
        {
            return DataList;
        }
    }
}
