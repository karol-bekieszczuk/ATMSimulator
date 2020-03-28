using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATMSimulator
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            SetNotifyLabel("Hello, please log in", Color.Black);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            User currentUser = FileManagement.DoesUserExist(@"C:\test\users.csv", cardNumberTextBox.Text, pinTextBox.Text);
            if (!currentUser.Equals(null))
            {
                var atmForm = new ATM(currentUser);
                atmForm.Show();
                this.Dispose(false);
            }
            else
                notifyLbl.Text = "File error, contact your administrator";

            SetNotifyLabel("Wrong password or User", Color.Red);
        }

        private void CheckTextBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Security.CheckTextBoxText_KeyPress(sender, e))
            {
                e.Handled = true;
                SetNotifyLabel("Must be number, and cant be blank", Color.Red);
            }
        }

        private void cardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Security.CheckTextboxOnlyNumbers(cardNumberTextBox))
                SetNotifyLabel("Must be number, and cant be blank", Color.Red);
        }

        private void pinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Security.CheckTextboxOnlyNumbers(pinTextBox))
                SetNotifyLabel("Must be number, and cant be blank", Color.Red);
        }

        private void SetNotifyLabel(string message, Color color)
        {
            notifyLbl.Text = message;
            notifyLbl.ForeColor = color;
        }
    }
}
