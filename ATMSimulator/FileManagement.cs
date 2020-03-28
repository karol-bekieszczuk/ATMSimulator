using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public static class FileManagement
    {
        public static User GetUser(string path, string inputCardNumber, string inputPinHash)
        {
            try
            {
                foreach (string usr in File.ReadAllLines(path, Encoding.UTF8))
                {
                    // 1. fName, 2. lName, 3. cardNumber 4. pinHash 5. balance
                    string[] usrDataArr = usr.Split(':');

                    if (usrDataArr[3] == inputCardNumber && usrDataArr[4] == inputPinHash)
                    {
                        return new User(usrDataArr[1], usrDataArr[2], usrDataArr[3], usrDataArr[4], float.Parse(usrDataArr[5]));
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        //TODO
        private static string[] GetUsersArrWithUpdatedCurrentUserBalance(string path, User currentUser, float amount)
        {
            try
            {
                string[] currentUsrData = File.ReadAllLines(path, Encoding.UTF8);
                List<string> updatedUsrDataList = new List<string>();

                foreach (string usr in currentUsrData)
                {
                    // 1. fName, 2. lName, 3. cardNumber 4. pinHash 5. balance
                    string[] usrDataArr = usr.Split(':');

                    if (usrDataArr[3] == currentUser.GetCardNumber() && usrDataArr[4] == currentUser.GetPinHash())
                    {
                        usrDataArr[5] = currentUser.getBalance().ToString();
                    }
                    updatedUsrDataList.Add(string.Join(":", usrDataArr));
                }

                return updatedUsrDataList.ToArray();
            }
            catch
            {
                return null;
            }
        }

        public static bool UpdateUsersDataFile(string path, User currentUser, float amount)
        {
            string[] updatedUsersDataFile = GetUsersArrWithUpdatedCurrentUserBalance(path, currentUser, amount);
            if (!(updatedUsersDataFile is null))
            {
                File.WriteAllText(path, string.Empty);
            }
            else
            {
                return false;
            }

            try
            {
                using (StreamWriter writter = new StreamWriter(path))
                {
                    if (!(updatedUsersDataFile is null))
                    {

                        foreach (string usr in updatedUsersDataFile)
                        {
                            writter.WriteLine(usr);
                        }
                    }
                }
            }
            catch (IOException err)
            {
                return false;
            }
            return true;
        }
    }
}
