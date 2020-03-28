using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class ATM : Form
    {
        User currentUser;

        public ATM(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            UpdateCurrentUserBalance();
            FillWelcomeLbl();
            SetNotifyLabel(string.Empty, Color.Black);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (Security.CheckTextboxOnlyNumbers(depositTextBox))
            {
                currentUser.BalanceDeposit(float.Parse(depositTextBox.Text));
                if (FileManagement.UpdateUsersDataFile(@"C:\test\users.csv", currentUser, float.Parse(depositTextBox.Text)))
                {
                    SetEditableTextBoxesToZero();
                    SetNotifyLabel("Money deposited", Color.Green);
                    UpdateCurrentUserBalance();
                }
                else
                    SetNotifyLabel("File error, contact your administrator", Color.Red);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (Security.CheckTextboxOnlyNumbers(withdrawTextBox))
            {
                if (currentUser.BalanceWithdraw(float.Parse(withdrawTextBox.Text)))
                {
                    if (FileManagement.UpdateUsersDataFile(@"C:\test\users.csv", currentUser, 
                        currentUser.getBalance() - float.Parse(withdrawTextBox.Text))){
                        SetNotifyLabel("Money withdrawed", Color.Green);
                        UpdateCurrentUserBalance();
                    }
                    else
                        SetNotifyLabel("File error, contact your administrator", Color.Red);
                }
                else
                    SetNotifyLabel("Cant withdraw, not enough funds", Color.Red);
            }
            SetEditableTextBoxesToZero();
        }

        public void UpdateCurrentUserBalance()
        {
            balanceTextBox.Text = currentUser.getBalance().ToString();
        }

        private void FillWelcomeLbl()
        {
            welcomeLbl.Text = $"Welcome {currentUser.fName} {currentUser.lName}";
        }

        private void depositTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void SetEditableTextBoxesToZero()
        {
            depositTextBox.Text = "0";
            withdrawTextBox.Text = "0";
        }

        private void ATM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var login = new LogIn();
            login.Show();
            this.Dispose(false);
        }
    }
}
