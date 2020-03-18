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
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        public void passCurrentUserData(string[] userData)
        {
            // 1. fName, 2. lName, 3. cardNumber 4. pinHash 5. balance
            currectUser = new User(userData[1], userData[2], userData[3], userData[4], float.Parse(userData[5]));

            updateCurrentUserBalance();
        }

        public void updateCurrentUserBalance()
        {
            balanceTextBox.Text = currectUser.getBalance().ToString();
        }
    }
}
