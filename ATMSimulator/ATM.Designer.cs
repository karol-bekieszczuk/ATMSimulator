namespace ATMSimulator
{
    partial class ATM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.depositButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.notifyLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(311, 89);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 0;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(205, 51);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 2;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(311, 118);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(205, 89);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 20);
            this.depositTextBox.TabIndex = 4;
            this.depositTextBox.Text = "0";
            this.depositTextBox.TextChanged += new System.EventHandler(this.depositTextBox_TextChanged);
            this.depositTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBoxText_KeyPress);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(205, 116);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(100, 20);
            this.withdrawTextBox.TabIndex = 5;
            this.withdrawTextBox.Text = "0";
            this.withdrawTextBox.TextChanged += new System.EventHandler(this.withdrawTextBox_TextChanged);
            this.withdrawTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBoxText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deposit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Withdraw";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(88, 13);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(63, 13);
            this.welcomeLbl.TabIndex = 8;
            this.welcomeLbl.Text = "welcomeLbl";
            // 
            // notifyLbl
            // 
            this.notifyLbl.AutoSize = true;
            this.notifyLbl.Location = new System.Drawing.Point(88, 164);
            this.notifyLbl.Name = "notifyLbl";
            this.notifyLbl.Size = new System.Drawing.Size(46, 13);
            this.notifyLbl.TabIndex = 9;
            this.notifyLbl.Text = "notifyLbl";
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notifyLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.withdrawTextBox);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositButton);
            this.Name = "ATM";
            this.Text = "ATM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ATM_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label notifyLbl;
    }
}