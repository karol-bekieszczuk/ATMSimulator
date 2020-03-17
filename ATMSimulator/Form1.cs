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
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Security.HashString(pinTextBox.Text);
            try
            {
                foreach(string usr in File.ReadAllLines($"{Directory.GetCurrentDirectory()}/dummy_data/users.csv", Encoding.UTF8))
                {
                    string usrCardNr = usr.Split(':')[3];
                    string usrCardPin = usr.Split(':')[4];

                    if (usrCardNr == cardNumberTextBox.Text && usrCardPin == Security.HashString(pinTextBox.Text))
                    {
                        MessageBox.Show("user found");
                        User logged_user = new User(usr.Split(':')[1], usr.Split(':')[2], usrCardNr, usrCardPin);
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
