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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnNeuPatient_Click(object sender, EventArgs e)
        {
            //NeuPatient neuPatient = new NeuPatient();
            //neuPatient.Show();
            newPatient1.Show();
        }

        private void btnPatientBearb_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            newPatient1.Hide();
        }
    }
}
