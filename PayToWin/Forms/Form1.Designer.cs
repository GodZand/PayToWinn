namespace PayToWin
{
    partial class Form1
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
            this.Prices = new System.Windows.Forms.ListBox();
            this.order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accCurrency = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.useracc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prices
            // 
            this.Prices.FormattingEnabled = true;
            this.Prices.Location = new System.Drawing.Point(184, 58);
            this.Prices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prices.Name = "Prices";
            this.Prices.Size = new System.Drawing.Size(180, 121);
            this.Prices.TabIndex = 0;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(237, 183);
            this.order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(127, 54);
            this.order.TabIndex = 1;
            this.order.Text = "Buy selected";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.Order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buy WinPoints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your current WinPoints:";
            // 
            // accCurrency
            // 
            this.accCurrency.AutoSize = true;
            this.accCurrency.Location = new System.Drawing.Point(18, 153);
            this.accCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accCurrency.Name = "accCurrency";
            this.accCurrency.Size = new System.Drawing.Size(10, 13);
            this.accCurrency.TabIndex = 4;
            this.accCurrency.Text = " \r\n";
            this.accCurrency.Click += new System.EventHandler(this.AccCurrency_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Embassy BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "PayToWin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Log off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // useracc
            // 
            this.useracc.AutoSize = true;
            this.useracc.Location = new System.Drawing.Point(13, 58);
            this.useracc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.useracc.Name = "useracc";
            this.useracc.Size = new System.Drawing.Size(33, 13);
            this.useracc.TabIndex = 10;
            this.useracc.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 255);
            this.Controls.Add(this.useracc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.Prices);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Hello there";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Prices;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accCurrency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label useracc;
    }
}

