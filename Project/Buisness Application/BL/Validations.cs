using Buisness_Application.DL;
using Buisness_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Validations
    {

        public static string ValidateEmployeeNumber(string number)
        {
            while (true)
            {
                bool flag = true;

                foreach (User i in UserDL.GetUserList())
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
                if (number.Length != 3 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    number = Console.ReadLine();
                }
                else
                {
                    return number;
                }
            }
        }
        public static string ValidateRating(string rating)
        {
            while(true)
            {
                if(int.Parse(rating) < 1 || int.Parse(rating)> 6)
                {
                    ValidationsUI.InvalidMessage();
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
            while (choice != "Yes" || choice!= "No")
            {
                ValidationsUI.InvalidMessage();
                choice = Console.ReadLine();
 
            }
            return choice;
        }
        public static string ValidateAccountNumber(string number)
        {
            while (true)
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
                if (number.Length != 16 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    number = Console.ReadLine();
                }
                else
                {
                    return number;
                }
            }
        }
        public static string ValidateContactNumber(string number)
        {
            while (true)
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
                if (number.Length != 11 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    number = Console.ReadLine();
                }
                else
                {
                    return number;
                }
            }
        }
        public static string ValidateName(string name)
        {
             int check = name.Length;

                while (true)
                {
                    bool isValid = true;
                    for (int i = 0; i < check; i++)
                    {
                        if (name[i] < 65 || (name[i] > 90 && name[i] < 97) || name[i] > 122)
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (check <= 2 || check > 10 || !isValid)
                    {
                        ValidationsUI.InvalidMessage();
                        name = Console.ReadLine();
                        check = name.Length;
                    }
                    else
                    {
                        return name;
                    }
                }
        
        }

        public static string ValidateRollNumber(string rollNumber)
        {

            while (true)
            {
                bool flag = true;

                foreach (User i in UserDL.GetUserList())
                {
                    if (i is Hostelite)
                    {
                        Hostelite h = (Hostelite)i;
                        if(rollNumber == h.GetRollNumber())
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
                if (rollNumber.Length != 3 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    rollNumber = Console.ReadLine();
                }
                else
                {
                    return rollNumber;
                }
            }
        }

        public static string ValidateCNIC(string checkCnic)
        {
            int check = checkCnic.Length;
            while (true)
            {
                bool flag = true;
                foreach (User i in UserDL.GetUserList())
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

                if (checkCnic.Length != 13 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    checkCnic = Console.ReadLine();
                    check = checkCnic.Length;
                }

                else
                {
                    return checkCnic;
                }
            }
        }

        public static string ValidateCity(string cityCheck)
        {
            int check2 = cityCheck.Length;

            while (true)
            {
                bool flag = true;

                for (int i = 0; i < check2; i++)
                {
                    if (cityCheck[i] < 65 || cityCheck[i] > 122)
                    {
                        flag = false;
                        break;
                    }
                }

                if (check2 <= 2 || check2 > 10 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    cityCheck = Console.ReadLine();
                    check2 = cityCheck.Length;
                }
                else
                {
                    return cityCheck;
                }
            }
        }

        public static string ValidateRoomNumber(string roomNumber)
        {
            while (true)
            {
                bool flag = true;
                int count = 0;
                foreach (User i in UserDL.GetUserList())
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
                if (int.Parse(roomNumber)> 20 || !flag || count >=3)
                {
                    ValidationsUI.InvalidMessage();
                    roomNumber = Console.ReadLine();
                }
                else
                {
                    return roomNumber;
                }
            }
        }

        public static string ValidatePassword(string checkPass)
        {
            int check3 = checkPass.Length;
            while (true)
            {
               
                if (check3 <= 2)
                {
                    ValidationsUI.InvalidMessage();
                    checkPass = Console.ReadLine();
                    check3 = checkPass.Length;
                }
                else
                {
                    return checkPass;
                }
            }
        }


        public static string ValidateNumber(string number)
        {
            while (true)
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
                if (number.Length < 1 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    number = Console.ReadLine();
                }
                else
                {
                    return number;
                }
            }
        }
        public static string ValidateChallan(string challan)
        {
            while (true)
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
                if (challan.Length != 10 || !flag)
                {
                    ValidationsUI.InvalidMessage();
                    challan = Console.ReadLine();
                }
                else
                {
                    return challan;
                }
            }
        }
    }
}
