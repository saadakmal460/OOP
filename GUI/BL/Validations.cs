using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Validations
    {

        public static void ValidateLogin(User u)
        {
            bool flag = true;
            foreach (User i in Admin.GetUserList())
            {
                if (u.GetUsername() == i.GetUsername() && u.GetPassword() == i.GetPassword())
                {
                    flag = true;

                }

                else
                {
                    flag = false;
                }

            }

            if (!flag)
            {

                Console.ReadKey();
            }
        }
        public static bool ValidateEmployeeNumber(string number)
        {
            bool flag = true;

            foreach (User i in Admin.GetUserList())
            {
                if (i is Finance)
                {
                    Finance f = (Finance)i;
                    if (number == f.GetEmployeeNumber())
                    {
                        flag = false;
                        break;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 48 || number[i] > 57)
                {
                    flag = false;
                    break;
                }
            }
            if (number.Length != 3)
            {

                flag = false;
            }

            return flag;


        }

        public static bool ValidateNotice(string notice)
        {
            if (notice == null)
            {
                return false;
            }
            if (notice.Length < 3)
            {
                return false;
            }
            return true;
        }
        public static string ValidateRating(string rating)
        {
            while (true)
            {
                if (int.Parse(rating) < 1 || int.Parse(rating) > 6)
                {

                    rating = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return rating;
        }
        public static string ValidateChoice(string choice)
        {
            while (choice != "Yes" && choice != "No")
            {

                choice = Console.ReadLine();

            }
            return choice;
        }
        public static bool ValidateAccountNumber(string number)
        {
            bool flag = true;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 48 || number[i] > 57)
                {
                    flag = false;
                    break;
                }
            }
            if (number.Length != 16)
            {

                flag = false;
            }
            return flag;


        }
        public static bool ValidateContactNumber(string number)
        {
            bool flag = true;
            foreach (User i in Admin.GetUserList())
            {
                if (i is Admin)
                {
                    Admin a = (Admin)i;
                    if (number == a.GetContact())
                    {
                        flag = false;
                        break;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 48 || number[i] > 57)
                {
                    flag = false;
                    break;
                }
            }
            if (number.Length != 11)
            {

                flag = false;
            }

            return flag;
        }

        public static bool ValidateName(string name)
        {
            int check = name.Length;


            bool isValid = true;
            foreach (User i in Admin.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    if (name == h.GetUsername())
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < check; i++)
            {
                if (name[i] < 65 || (name[i] > 90 && name[i] < 97) || name[i] > 122)
                {
                    isValid = false;
                    break;
                }
            }

            if (check <= 2 || check > 10)
            {
                isValid = false;

            }

            return isValid;



        }

        public static bool ValidateRollNumber(string rollNumber)
        {


            bool flag = true;

            foreach (User i in Admin.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    if (rollNumber == h.GetRollNumber())
                    {
                        flag = false;
                        break;
                    }
                }
            }
            for (int i = 0; i < rollNumber.Length; i++)
            {
                if (rollNumber[i] < 48 || rollNumber[i] > 57)
                {
                    flag = false;
                    break;
                }
            }
            if (rollNumber.Length != 3)
            {
                flag = false;

            }

            return flag;

        }

        public static bool ValidateCNIC(string checkCnic)
        {
            int check = checkCnic.Length;

            bool flag = true;
            foreach (User i in Admin.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    if (checkCnic == h.GetCnic())
                    {
                        flag = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < checkCnic.Length; i++)
            {
                if (checkCnic[i] < 48 || checkCnic[i] > 57)
                {
                    flag = false;
                    break;
                }
            }

            if (checkCnic.Length != 13)
            {


                flag = false;
            }

            return flag;


        }

        public static bool ValidateCity(string cityCheck)
        {
            int check2 = cityCheck.Length;

            bool flag = true;

            for (int i = 0; i < check2; i++)
            {
                if (cityCheck[i] < 65 || cityCheck[i] > 122)
                {
                    flag = false;
                    break;
                }
            }

            if (check2 <= 2 || check2 > 10 || cityCheck == null)
            {
                flag = false;

            }

            return flag;

        }

        public static bool ValidateRoomNumber(string roomNumber)
        {
            bool flag = true;
            int count = 0;
            foreach (User i in Admin.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    if (roomNumber == h.GetRoomNumber())
                    {
                        count++;

                    }
                }
            }
            for (int i = 0; i < roomNumber.Length; i++)
            {
                if (roomNumber[i] < 48 || roomNumber[i] > 57)
                {
                    flag = false;
                    break;
                }
            }

            if (count >= 3 || roomNumber == "")
            {

                flag = false;
            }

            return flag;
        }

        public static bool ValidatePassword(string checkPass)
        {
            int check3 = checkPass.Length;
            bool flag = true;
            if (check3 <= 2)
            {
                flag = false;
            }

            return flag;

        }


        public static bool ValidateNumber(string number)
        {
            bool flag = true;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 48 || number[i] > 57)
                {
                    flag = false;
                    break;
                }
            }
            if (number.Length < 1)
            {

                flag = false;
            }
            return flag;

        }
        public static bool ValidateChallan(string challan)
        {
            bool flag = true;


            for (int i = 0; i < challan.Length; i++)
            {
                if (challan[i] < 48 || challan[i] > 57)
                {
                    flag = false;
                    break;
                }
            }
            if (challan.Length != 10)
            {
                flag = false;
            }

            return flag;




        }
    }
}
