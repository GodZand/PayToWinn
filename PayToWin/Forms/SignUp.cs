using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayToWin
{
    public partial class SignUp : Form
    {
        public object SqliteDataAccess { get; private set; }

        public SignUp()
        {
            InitializeComponent();
        }
        

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void REmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void RCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Userinos u = new Userinos();

            if (string.IsNullOrWhiteSpace(rUsername.Text) || string.IsNullOrWhiteSpace(rPassword.Text) || string.IsNullOrWhiteSpace(rEmail.Text) || string.IsNullOrWhiteSpace(rCard.Text) || string.IsNullOrWhiteSpace(rDate.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Fill in the gaps.");
            }
            else
            {
                if (!checkBox1.Checked)
                {
                    MessageBox.Show("You need to check the checkbox to finish.");
                }
                else
                {
                    u.Username = rUsername.Text;
                    u.Password = rPassword.Text;
                    u.Email = rEmail.Text;
                    u.Numbers = rCard.Text;
                    u.Date = rDate.Text;
                    u.Other = textBox1.Text;
                    u.Points = 0;

                    SqliteAcc.SaveUser(u);

                    MessageBox.Show("Registration successful.");

                    Login log = new Login(); 
                    this.Hide();
                    log.ShowDialog(); 
                    this.Close(); 

                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
