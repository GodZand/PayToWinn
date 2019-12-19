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
    public partial class Login : Form
    {
        public static Autentic repository = new Autentic();
        public static List<Userinos> useriai = new List<Userinos>();
        
        
        public Login()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            useriai = SqliteAcc.LoadUsers();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            this.Hide();
            sign.ShowDialog();
            this.Close();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = namelogin.Text;
            string password = passwordlogin.Text;
            Userinos user = repository.GetAuthenticatedUser(username, password);
            
            if (user == null)
            {
                MessageBox.Show("Wrong details");
            }
            else
            {
                Form1 mw = new Form1(user);
                this.Hide();
                mw.ShowDialog();
                this.Close();
            }
        }
    }
}
