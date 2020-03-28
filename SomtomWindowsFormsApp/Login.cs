using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomtomWindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control loginn = new Control();
            loginn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menuu = new Form1();
            menuu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order orderr = new Order();
            orderr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee empp = new Employee();
            empp.Show();
            this.Hide();
        }
    }
}
