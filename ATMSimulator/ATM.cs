using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class ATM : Form
    {
        User currectUser;

        public ATM()
        {
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (Security.CheckTextboxOnlyNumbers(depositTextBox)) {
                currectUser.balanceDeposit(float.Parse(depositTextBox.Text));
                SetNotifyLabel("Money deposited", Color.Green);
                UpdateCurrentUserBalance();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (Security.CheckTextboxOnlyNumbers(withdrawTextBox))
            {
                if(currectUser.balanceWithdraw(float.Parse(withdrawTextBox.Text)))
                {
                    SetNotifyLabel("Money withdrawed", Color.Green);
                    UpdateCurrentUserBalance();
                }
                else
                    SetNotifyLabel("Cant withdraw, not enough funs", Color.Red);
            }
        }

        public void passCurrentUserData(string[] userData)
        {
            // 1. fName, 2. lName, 3. cardNumber 4. pinHash 5. balance
            currectUser = new User(userData[1], userData[2], userData[3], userData[4], float.Parse(userData[5]));

            UpdateCurrentUserBalance();
            FillWelcomeLbl();
        }

        public void UpdateCurrentUserBalance()
        {
            balanceTextBox.Text = currectUser.getBalance().ToString();
        }

        private void FillWelcomeLbl()
        {
            welcomeLbl.Text = $"Welcome {currectUser.fName} {currectUser.lName}";
        }

        private void depositTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO change error messages to custom exceptions
            if (!Security.CheckTextboxOnlyNumbers(depositTextBox))
                SetNotifyLabel("Must be number, and cant be blank", Color.Red);
        }

        private void withdrawTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Security.CheckTextboxOnlyNumbers(withdrawTextBox))
                SetNotifyLabel("Must be number, and cant be blank", Color.Red);
        }

        private void CheckTextBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Security.CheckTextBoxText_KeyPress(sender, e))
            {
                e.Handled = true;
                SetNotifyLabel("Must be number, and cant be blank", Color.Red);
            }
        }

        private void SetNotifyLabel(string message, Color color)
        {
            notifyLbl.Text = message;
            notifyLbl.ForeColor = color;
        }
    }
}
