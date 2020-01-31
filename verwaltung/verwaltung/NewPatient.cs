using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace verwaltung
{
    public partial class NewPatient : UserControl
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void btnPZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.tboxPVorname.Clear();
            this.tboxPNachname.Clear();
        }
    }
}
