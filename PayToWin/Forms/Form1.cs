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
    public partial class Form1 : Form
    {
        public static List<Userinos> usee = new List<Userinos>();
        public static Purchase pur = new Purchase();
        public int idd;
        List<BuyOption> pric = new List<BuyOption>();
        public Form1(Userinos user)
        {
            InitializeComponent();
            Loadp();
            Load();
            useracc.Text = user.Username;
            accCurrency.Text = user.Points + " ";
            idd = user.ID;
        }
        private void WireUpFoodList()
        {
            Prices.DataSource = null;
            Prices.DataSource = pric;
            Prices.DisplayMember = "Infopric";
        }
        public void Loadp()
        {
            pric = SqliteAcc.LoadPrice();

            WireUpFoodList();
        }
        public void Load()
        {
            usee = SqliteAcc.LoadUsers();

            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            int id = idd ;
            Userinos user = pur.AccPurchase(id);
            BuyOption selected = (BuyOption)Prices.SelectedItem;
            pric.Add(selected);
            user.Points = user.Points + selected.Amount;
            accCurrency.Text = user.Points +"";

            SqliteAcc.Update(user);

            MessageBox.Show("Purchase Successful.");
        }

        private void AccCurrency_Click(object sender, EventArgs e)
        {

        }
    }
}
