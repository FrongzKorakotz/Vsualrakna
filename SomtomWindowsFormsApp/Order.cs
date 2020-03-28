using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SomtomWindowsFormsApp
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection DBorder = new SQLiteConnection("Data Source= C:/Users/Frongz/source/repos/pro/SomtomWindowsFormsApp/order/order.db;");
            string query = "SELECT * FROM orderr";
            SQLiteCommand cmd = new SQLiteCommand(query, DBorder);

            DBorder.Open();
            DataTable oorder = new DataTable();
            SQLiteDataAdapter orderlist = new SQLiteDataAdapter(cmd);
            orderlist.Fill(oorder);
            dataGridView1.DataSource = oorder;
            DBorder.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login menuu = new Login();
            menuu.Show();
            this.Hide();
        }
    }
}
