from Muser import Muser
import os.path

class MuserDL:

    userList = []

    @staticmethod
    def addUserInList(user):
        MuserDL.userList.append(user)

    @staticmethod
    def ShowList():
        for user in MuserDL.userList:
            print(user.username,user.password, user.role)
        
    
    @staticmethod
    def SignIn(user):

        for i in MuserDL.userList:
            if(i.username == user.username and i.password == user.password):
                return i
            
        
        return None
    
    @staticmethod
    def ParseData(line):
        line = line.split(",")
        return line;
    

    @staticmethod
    def ReadData(path):
        if(os.path.exists(path)):
            file = open(path  , 'r')
            record = file.read().split("\n")
            file.close()

            for line in record:
                data = MuserDL.ParseData(line)
                username = data[0]
                password = data[1]
                role = data[2]
                user = Muser(username , password , role)
                MuserDL.addUserInList(user)
            return True
            
        else:
            return False


    @staticmethod
    def StoreData(user , path):
        file = open(path , 'a')
        file.write("\n" + user.username + "," + user.password + "," + user.role)
        file.close()




