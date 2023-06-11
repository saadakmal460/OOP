﻿using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class MessCRUD
    {
        public static List<Mess> menu = new List<Mess>()
        {
            new Mess("Monday", "Biryani"),
            new Mess("Tuesday", "Chicken"),
            new Mess("Wednesday", "Sabzi"),
            new Mess("Thursday", "Daal"),
            new Mess("Friday", "Pulao"),
            new Mess("Saturday", "Sabzi"),
            new Mess("Sunday", "Daal")
        };

        public static void AddMenuInList(Mess m)
        {
            menu.Add(m);
        }

        public static void RemoveAllItems()
        {
            menu.Clear();
        }
        public static void StoreMessMenuInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Mess i in menu)
            {
                file.WriteLine(i.GetDay() + "," + i.GetDish());
            }
            file.Flush();
            file.Close();
        }

        public static void LoadMessMenuFromFile(string path)
        {
            if (File.Exists(path))
            {
                RemoveAllItems();
                StreamReader file = new StreamReader(path);
                string record;
                
                while ((record = file.ReadLine()) != null)
                {
                    string day = Parsing(record, 1);
                    string dish = Parsing(record, 2);
                    Mess m = new Mess(day, dish);
                    AddMenuInList(m);

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
