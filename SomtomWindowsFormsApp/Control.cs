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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your Username and Password!", "ERROR");
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "123456")
                {
                    MessageBox.Show("Welcome!", "SUCCESS");
                    Login controll = new Login();
                    controll.Show();
                    this.Hide();
                }
                else
                {
                    SQLiteConnection DBlog = new SQLiteConnection("Data Source= C:/Users/Frongz/source/repos/pro/SomtomWindowsFormsApp/order/Loginz.db;");
                    string query = "SELECT * FROM Loginzz WHERE Username = @user AND Password = @pass";
                    DBlog.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, DBlog);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                    SQLiteDataAdapter loglist = new SQLiteDataAdapter(cmd);
                    //DBlog.Close();
                    DataTable loginnn = new DataTable();

                    loglist.Fill(loginnn);
                    if(loginnn.Rows.Count > 0)
                    {
                        Login controlll = new Login();
                        this.Hide();
                        controlll.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed Username and Password!", "ERROR");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
