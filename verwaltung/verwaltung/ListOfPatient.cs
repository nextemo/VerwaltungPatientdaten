using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace verwaltung
{
    public partial class ListOfPatient : UserControl
    {
        SQLiteConnection con = new SQLiteConnection("Data Source = C:/sqlite/Patient.db; Version = 3;");
        int id = 0;
        int vorname = 1;
        int name = 2;
        int geburtsdatum = 3;
        int geschlecht = 4;
        int alter = 5;
        int ankunft = 6;
        int auskunft = 7;
        int position;
        public ListOfPatient()
        {
            InitializeComponent();
            con.Open();
            position = 1;
        }

        private void ListOfPatient_Load(object sender, EventArgs e)
        {
            loadPatient();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            position++;
            loadPatient();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            position--;
            loadPatient(); 
        }

        void loadPatient() {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB WHERE ID = {position}";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lbVorname.Text = reader.GetString(vorname);
                lbGeburtsdatum.Text = reader.GetString(geburtsdatum);
            }
        }
    }
}
