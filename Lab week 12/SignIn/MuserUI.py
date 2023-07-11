from Muser import Muser


class MuserUI:
    @staticmethod
    def Menu():
        print("1.Sign In")
        print("2.Sign Up")
        print("3.Exit")
        print("Enter option: ")
        option = int(input())
        return option



    @staticmethod
    def TakeInputForLogin():
        print("Enter name: ")
        name = input()
        print("Enter password: ")
        password = input()
        
        user = Muser(name , password , None)
        return user


    @staticmethod
    def TakeInputForSignUp():
        print("Enter name: ")
        name = input()
        print("Enter password: ")
        password = input()

        print("Enter role: ")
        role = input()
        
        user = Muser(name , password , role)
        return user
