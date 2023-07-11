from MuserDL import MuserDL
from MuserUI import MuserUI
import os.path
from time import sleep


def main():
    path = "data.txt"
    MuserDL.ReadData(path)
    option = 0

    MuserDL.ShowList()
    sleep(10)
    
    while(option != 3):
        os.system("cls")
        option = MuserUI.Menu()

        if(option == 1):
            user = MuserUI.TakeInputForLogin()
            user = MuserDL.SignIn(user)
            if(user != None):
                
                if(user.isAdmin()):
                    print("user is admin")
            
                else:
                    print("this is user")
            sleep(1)

            

        elif(option == 2):
            user = MuserUI.TakeInputForSignUp()
            MuserDL.addUserInList(user)
            MuserDL.StoreData(user , path)


if __name__ == "__main__":
    main()