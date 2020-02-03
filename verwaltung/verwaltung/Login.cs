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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = "test"; //check password
            if (tboxPassword.Text != password)
            {
                MessageBox.Show("Password ist ungültig");
            } else if (string.IsNullOrWhiteSpace(tboxUsername.Text)){
                MessageBox.Show("Den Feld darf nicht leer sein.");
                tboxUsername.BackColor = Color.Red;
            }
            else {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
                //TestForm testForm = new TestForm();
                //testForm.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tboxPassword.PasswordChar = '*';
        }
    }
}
