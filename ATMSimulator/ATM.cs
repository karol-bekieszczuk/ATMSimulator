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
        User currentUser = null;

        public ATM()
        {
            InitializeComponent();
            alarmLabel.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            currentUser.balanceDeposit(float.Parse(depositTextBox.Text));

            updateCurrentUserBalance();
        }
        
        public void passCurrentUserData(string[] userData)
        {
            // 1. fName, 2. lName, 3. cardNumber 4. pinHash 5. balance
            currentUser = new User(userData[1], userData[2], userData[3], userData[4], float.Parse(userData[5]));

            setUpHelloLabel();
            updateCurrentUserBalance();
        }

        public void updateCurrentUserBalance()
        {
            balanceTextBox.Text = currentUser.getBalance().ToString();
        }

        private void ATM_Load(object sender, EventArgs e)
        {

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (currentUser.balanceWithdraw(float.Parse(withdrawTextBox.Text))) 
            {
                setUpAlarmLabel("Money withdrawed");
                updateCurrentUserBalance();
            }
            else
            {
                setUpAlarmLabel("Not enough funds");
            }
        }

        private void setUpHelloLabel()
        {
            helloLabel.Text =$"Hello {currentUser.fName} {currentUser.lName}";
        }

        private void setUpAlarmLabel(string msg)
        {
            alarmLabel.Text = msg;
        }
    }
}
