using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tboxUsername.Text == "AMD")
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = "test"; //check password
            if (tboxPassword.Text != password)
            {
                MessageBox.Show("Password ist ungültig");
            }
            else {
                MessageBox.Show("Welcome!");
            }
        }
    }
}
