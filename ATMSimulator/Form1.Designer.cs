namespace ATMSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.notifyLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "card number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(12, 25);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(146, 20);
            this.cardNumberTextBox.TabIndex = 2;
            this.cardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardNumberTextBox.TextChanged += new System.EventHandler(this.cardNumberTextBox_TextChanged);
            this.cardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBoxText_KeyPress);
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(12, 64);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '*';
            this.pinTextBox.Size = new System.Drawing.Size(146, 20);
            this.pinTextBox.TabIndex = 3;
            this.pinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pinTextBox.UseSystemPasswordChar = true;
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            this.pinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBoxText_KeyPress);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(51, 90);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // notifyLbl
            // 
            this.notifyLbl.AutoSize = true;
            this.notifyLbl.Location = new System.Drawing.Point(12, 129);
            this.notifyLbl.Name = "notifyLbl";
            this.notifyLbl.Size = new System.Drawing.Size(46, 13);
            this.notifyLbl.TabIndex = 5;
            this.notifyLbl.Text = "notifyLbl";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(170, 151);
            this.Controls.Add(this.notifyLbl);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label notifyLbl;
    }
}

