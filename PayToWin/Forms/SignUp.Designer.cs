namespace PayToWin
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rUsername = new System.Windows.Forms.TextBox();
            this.rPassword = new System.Windows.Forms.TextBox();
            this.rEmail = new System.Windows.Forms.TextBox();
            this.rCard = new System.Windows.Forms.TextBox();
            this.rDate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit card numbers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date and back numbers:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // rUsername
            // 
            this.rUsername.Location = new System.Drawing.Point(211, 64);
            this.rUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rUsername.Name = "rUsername";
            this.rUsername.Size = new System.Drawing.Size(153, 22);
            this.rUsername.TabIndex = 5;
            this.rUsername.TextChanged += new System.EventHandler(this.RUsername_TextChanged);
            // 
            // rPassword
            // 
            this.rPassword.Location = new System.Drawing.Point(211, 98);
            this.rPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rPassword.Name = "rPassword";
            this.rPassword.Size = new System.Drawing.Size(153, 22);
            this.rPassword.TabIndex = 6;
            this.rPassword.TextChanged += new System.EventHandler(this.RPassword_TextChanged);
            // 
            // rEmail
            // 
            this.rEmail.Location = new System.Drawing.Point(211, 132);
            this.rEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rEmail.Name = "rEmail";
            this.rEmail.Size = new System.Drawing.Size(153, 22);
            this.rEmail.TabIndex = 7;
            this.rEmail.TextChanged += new System.EventHandler(this.REmail_TextChanged);
            // 
            // rCard
            // 
            this.rCard.Location = new System.Drawing.Point(211, 167);
            this.rCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rCard.Name = "rCard";
            this.rCard.Size = new System.Drawing.Size(153, 22);
            this.rCard.TabIndex = 8;
            this.rCard.TextChanged += new System.EventHandler(this.RCard_TextChanged);
            // 
            // rDate
            // 
            this.rDate.Location = new System.Drawing.Point(211, 199);
            this.rDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rDate.Name = "rDate";
            this.rDate.Size = new System.Drawing.Size(73, 22);
            this.rDate.TabIndex = 9;
            this.rDate.TextChanged += new System.EventHandler(this.RDate_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 199);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(305, 270);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 33);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(171, 270);
            this.register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(100, 33);
            this.register.TabIndex = 12;
            this.register.Text = "Create";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Embassy BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "PayToWin";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(45, 233);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(321, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Accept the fact you giving your card details     ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 314);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rDate);
            this.Controls.Add(this.rCard);
            this.Controls.Add(this.rEmail);
            this.Controls.Add(this.rPassword);
            this.Controls.Add(this.rUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.Text = "PayToWin registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rUsername;
        private System.Windows.Forms.TextBox rPassword;
        private System.Windows.Forms.TextBox rEmail;
        private System.Windows.Forms.TextBox rCard;
        private System.Windows.Forms.TextBox rDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}