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
    public partial class MainForm : Form
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
        int nummer = 8;
        int email = 9;
        int position;
        int count;
        public MainForm()
        {
            InitializeComponent();
            con.Open();
            getFirstID();
            getTotalRows();
        }

        private void btnNeuPatient_Click(object sender, EventArgs e)
        {
            newPatient1.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            newPatient1.Hide();
            loadPatient();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Speichern")
            {
                readOnlyTboxes();
                btnUpdate.Text = "Update";
            }
            else if (btnPrevious.BackColor == Color.Red && btnPrevious.ForeColor == Color.White) 
            { 
                btnPrevious.BackColor = Color.Transparent; 
                btnPrevious.ForeColor = Color.Black; 
            }
            else if (position >= count) { btnNext.BackColor = Color.Red; btnNext.ForeColor = Color.White; } 
            else
            {
                position++;
                loadPatient();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Speichern")
            {
                readOnlyTboxes();
                btnUpdate.Text = "Update";
            }
            else if (btnNext.BackColor == Color.Red && btnNext.ForeColor == Color.White)
            {
                btnNext.BackColor = Color.Transparent;
                btnNext.ForeColor = Color.Black;
            }
            else if (position == 1) { btnPrevious.BackColor = Color.Red; btnPrevious.ForeColor = Color.White; }
            else
            {
                position--;
                loadPatient();
            }
        }

        public void getFirstID() {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB ";
            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                position = reader.GetInt32(0);
            }
        }

        public void loadPatient()
        {
            readOnlyTboxes();
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB WHERE ID = {position}";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tboxVorname.Text = reader.GetString(vorname);
                tboxName.Text = reader.GetString(name);
                tboxGDatum.Text = reader.GetString(geburtsdatum);
                tboxGeschlecht.Text = reader.GetString(geschlecht);
                tboxNummer.Text = reader.GetString(nummer);
                tboxEmail.Text = reader.GetString(email);
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
            tboxEmail.ReadOnly = true;
            tboxNummer.ReadOnly = true;
        }

        void disableReadOnly()
        {
            tboxAnkunft.ReadOnly = false;
            tboxGDatum.ReadOnly = false;
            tboxGeschlecht.ReadOnly = false;
            tboxName.ReadOnly = false;
            tboxVorname.ReadOnly = false;
            tboxEmail.ReadOnly = false;
            tboxNummer.ReadOnly = false;
        }

        void getTotalRows()
        {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT COUNT(*) FROM PatientDB";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
        }

        void updateEntry(string vorname, string name, string geburtsDatum, string geschlecht, string ankunft) {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = con.CreateCommand();
            sqlite_cmd.CommandText = $"UPDATE PatientDB SET Vorname = '{vorname}', Name = '{name}', Geburtsdatum = '{geburtsDatum}', Geschlecht = '{geschlecht}', Ankunft = '{ankunft}', Auskunft = 'Null' WHERE ID = {position};";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //disableReadOnly();
            //btnUpdate.Visible = false;
            //btnUpdateSpeichern.Visible = true;
            
            if (btnUpdate.Text == "Speichern")
            {
                readOnlyTboxes();
                updateEntry(tboxVorname.Text, tboxName.Text, tboxGDatum.Text, tboxGeschlecht.Text, tboxAnkunft.Text);
                btnUpdate.Text = "Update";
            }
            else {
                disableReadOnly();
                btnUpdate.Text = "Speichern";
            }

        }

        //private void btnUpdateSpeichern_Click(object sender, EventArgs e)
        //{
        //    readOnlyTboxes();
        //    updateEntry(tboxVorname.Text, tboxName.Text, tboxGDatum.Text, tboxGeschlecht.Text, tboxAnkunft.Text);
        //    btnUpdate.Visible = true;
        //    btnUpdateSpeichern.Visible = false;
        //}

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB WHERE Vorname || Name || Geburtsdatum || ID || Geschlecht || Ankunft || Age LIKE '%{tSearch.Text}%'";
            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                position = reader.GetInt32(id);
                if (id == 0) MessageBox.Show("No such Patient");
                else loadPatient();
            }
        }

        private void lSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
