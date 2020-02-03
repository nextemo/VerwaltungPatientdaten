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
    public partial class Patientliste : Form
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
        int count;
        public Patientliste()
        {
            InitializeComponent();
            con.Open();
            position = 1;

            getTotalRows();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position >= count) return;
            else {
                position++;
                loadPatient();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (position == 1)
            {
                return;
            }
            else {
                position--;
                loadPatient();
            }
            
        }

        void loadPatient()
        {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB WHERE ID = {position}";
            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                readOnlyTboxes();
                tboxVorname.Text = reader.GetString(vorname);
                tboxName.Text = reader.GetString(name);
                tboxGDatum.Text = reader.GetString(geburtsdatum);
                tboxGeschlecht.Text = reader.GetString(geschlecht);
                tboxAnkunft.Text = reader.GetString(ankunft);
            }
        }
        void readOnlyTboxes()
        {
            tboxAnkunft.ReadOnly = true;
            tboxGDatum.ReadOnly = true;
            tboxGeschlecht.ReadOnly = true;
            tboxName.ReadOnly = true;
            tboxVorname.ReadOnly = true;
        }

        void getTotalRows() {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT COUNT(*) FROM PatientDB";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
        }

        private void Patientliste_Load(object sender, EventArgs e)
        {
            loadPatient();
        }
    }
}
