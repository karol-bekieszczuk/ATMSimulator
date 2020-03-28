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
        public static User DoesUserExist(string path, string inputCardNumber, string inputPinHash)
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
        //public static bool UpdateUserBalanceInFile()
        //{

        //}
    }
}
