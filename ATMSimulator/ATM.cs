using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class ATM : Form
    {
        User currentUser;

        public ATM(string[] userData)
        {
            InitializeComponent();
            currentUser = new User(userData[1], userData[2], userData[3], userData[4], float.Parse(userData[5]));

            UpdateCurrentUserBalance();
            FillWelcomeLbl();
            SetNotifyLabel(string.Empty, Color.Black);
        }

        // save changed balance in file
        private void depositButton_Click(object sender, EventArgs e)
        {
            if (Security.CheckTextboxOnlyNumbers(depositTextBox))
            {
                currentUser.balanceDeposit(float.Parse(depositTextBox.Text));
                SetEditableTextBoxesToZero();
                SetNotifyLabel("Money deposited", Color.Green);
                UpdateCurrentUserBalance();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (Security.CheckTextboxOnlyNumbers(withdrawTextBox))
            {
                if (currentUser.balanceWithdraw(float.Parse(withdrawTextBox.Text)))
                {
                    SetNotifyLabel("Money withdrawed", Color.Green);
                    UpdateCurrentUserBalance();
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
            var login = new Form1();
            login.Show();
            this.Dispose(false);
        }
    }
}
