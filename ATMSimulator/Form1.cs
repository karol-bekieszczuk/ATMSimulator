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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetNotifyLabel("Hello, please log in", Color.Black);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                //string old_dir = $"{Directory.GetCurrentDirectory()}/dummy_data/users.csv";
                foreach (string usr in File.ReadAllLines(@"C:\test\users.csv", Encoding.UTF8))
                {
                    // 1. fName, 2. lName, 3. cardNumber 4. pinHash 5. balance
                    string[] usrDataArr = usr.Split(':');

                    if (usrDataArr[3] == cardNumberTextBox.Text && usrDataArr[4] == pinTextBox.Text)
                    {
                        var atmForm = new ATM(usrDataArr);
                        atmForm.Show();
                        this.Dispose(false);
                    }
                }
                SetNotifyLabel("Wrong password or User", Color.Red);
            }
            catch (Exception err)
            {
                //TODO
                //Change errors to custom exception handlers
                MessageBox.Show(err.ToString());
            }
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
            // TODO change error messages to custom exceptions
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
