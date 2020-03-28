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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection DBemp = new SQLiteConnection("Data Source= C:/Users/Frongz/source/repos/pro/SomtomWindowsFormsApp/order/employeelist.db;");
            string query = "SELECT * FROM employeelist";
            SQLiteCommand cmd = new SQLiteCommand(query, DBemp);

            DBemp.Open();
            DataTable empp = new DataTable();
            SQLiteDataAdapter emplist = new SQLiteDataAdapter(cmd);
            emplist.Fill(empp);
            dataGridView1.DataSource = empp;
            DBemp.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login menuu = new Login();
            menuu.Show();
            this.Hide();
        }
    }
}
