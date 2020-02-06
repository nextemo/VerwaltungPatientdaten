using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verwaltung
{
    public partial class Login : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source = C:/sqlite/Patient.db; Version = 3;");
        public Login()
        {
            InitializeComponent();
            tboxPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        void login() {
            string password = "test"; //check password
            if (tboxPassword.Text != password)
            {
                MessageBox.Show("Password ist ungültig", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TabForm testForm = new TabForm();
                testForm.Show();
                this.Hide();
            }
        }

        private void tboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                login();      
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
