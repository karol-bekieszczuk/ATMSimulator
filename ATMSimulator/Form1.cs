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
            try
            {
                foreach(string usr in File.ReadAllLines($"{Directory.GetCurrentDirectory()}/dummy_data/users.csv", Encoding.UTF8))
                {
                    string[] usrDataArr = usr.Split(':');

                    string usrCardNr = usrDataArr[3];
                    string usrCardPin = usrDataArr[4];

                    if (usrCardNr == cardNumberTextBox.Text && usrCardPin == pinTextBox.Text)
                    {
                        var atmForm = new ATM();
                        atmForm.passCurrentUserData(usrDataArr);
                        this.Hide();
                        atmForm.Show();
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
