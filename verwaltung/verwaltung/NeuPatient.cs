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
    public partial class NeuPatient : Form
    {
        public NeuPatient()
        {
            InitializeComponent();
        }

        private void btnPZurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPSpeichern_Click(object sender, EventArgs e)
        {
            var vName = tboxVorname.Text;
            var nName = tboxNachname.Text;
            var neuPatient = new Patient(vName, nName);
        }
    }
}
