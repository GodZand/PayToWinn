namespace PayToWin
{
    partial class Login
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
            this.namelogin = new System.Windows.Forms.TextBox();
            this.passwordlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelogin
            // 
            this.namelogin.Location = new System.Drawing.Point(114, 97);
            this.namelogin.Name = "namelogin";
            this.namelogin.Size = new System.Drawing.Size(156, 22);
            this.namelogin.TabIndex = 0;
            // 
            // passwordlogin
            // 
            this.passwordlogin.Location = new System.Drawing.Point(114, 126);
            this.passwordlogin.Name = "passwordlogin";
            this.passwordlogin.Size = new System.Drawing.Size(156, 22);
            this.passwordlogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(195, 154);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 29);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(308, 243);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(90, 28);
            this.signUp.TabIndex = 5;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t have an account yet?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Embassy BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "PayToWin";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordlogin);
            this.Controls.Add(this.namelogin);
            this.Name = "Login";
            this.Text = "Sign up or sign in to play PayToWin!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namelogin;
        private System.Windows.Forms.TextBox passwordlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}