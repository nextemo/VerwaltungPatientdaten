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
    public partial class newPatient : Form
    {
        public newPatient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vName = tboxVorname.Text;
            var nName = tboxNachname.Text;
            var neuPatient = new Patient(vName, nName);
        }
    }
}
