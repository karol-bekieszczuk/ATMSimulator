using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public static class Security
    {
        public static string HashString(string str)
        {
            // TODO
            return "TODO";
        }

        public static bool CheckTextboxOnlyNumbers(TextBox tb)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "^[0-9]") && !string.IsNullOrWhiteSpace(tb.Text))
                return true;
            return false;
        }

        public static bool CheckTextBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ',')
                return true;
            return false;
        }
    }
}
