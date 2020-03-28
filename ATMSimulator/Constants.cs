using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public static class Constants
    {
        public static class Links
        {
            public static readonly string UsersFilePath = @"C:\test\users.csv";
        }

        public static class Errors
        {
            public static readonly string FileError = "File error, contact your administrator";
            public static readonly string InputNotNumber = "Must be number, and cant be blank";
        }
    }
}
