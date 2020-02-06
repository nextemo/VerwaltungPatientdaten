using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verwaltung
{
    public partial class TabForm : Form
    {
        string pName, pVorname, pGeschlecht, pEmail;
        DateTime pGebDatum;
        int pAlter, pNummer;
        static string path = System.IO.Directory.GetCurrentDirectory();
        SQLiteConnection con = new SQLiteConnection($"Data Source = {path}/Patient.db; Version = 3;");

        int id = 0;
        int vorname = 1;
        int name = 2;
        int geburtsdatum = 3;
        int geschlecht = 4;
        int alter = 5;
        int angemeldet = 6;
        int abgemeldet = 7;
        int nummer = 8;
        int email = 9;
        int position;
        int count;
        public TabForm()
        {
            InitializeComponent();
            con.Open();
            getFirstID();
            getTotalRows();
            loadPatient();
        }

        private void btnPSpeichern_Click(object sender, EventArgs e)
        {
            var vName = tboxPVorname.Text;
            var nName = tboxPNachname.Text;
            var geburtsdatum = gebDatumPicker.Value;
            if (rMänlich.Checked) pGeschlecht = "Mänlich";
            else if (rWeiblich.Checked) pGeschlecht = "Weiblich";
            else pGeschlecht = "Not available";
            try
            {
                var nummer = int.Parse(tboxPNumber.Text);
            }
            catch
            {
                MessageBox.Show("Telefon-Nummer darf nur Nummern enthalten!");
                return;
            }

            var email = tboxPEmail.Text;

            //update the Values
            vName = vName.Replace("  ", " ");
            nName = nName.Replace("  ", " ");
            Regex re = new Regex(@"\d");
            string regnummer = nummer.ToString();
            try
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Mail-Addresse nicht valide!");
                return;
            }
            


            //neuer Patient
            var neuPatient = new Patient(vName, nName, geburtsdatum, pGeschlecht, email, nummer);



            pName = neuPatient.Name;
            pVorname = neuPatient.Vorname;
            pGebDatum = neuPatient.Geburtsdatum;
            pGeschlecht = neuPatient.Geschlecht;
            pAlter = neuPatient.Alter;
            pNummer = neuPatient.Nummer;
            pEmail = neuPatient.Email;

            DialogResult preview = MessageBox.Show($"Vorname: {pVorname} {Environment.NewLine}Name: {pName} { Environment.NewLine}Geburtsdatum: {pGebDatum.ToShortDateString()}{Environment.NewLine}Geschlecht: {pGeschlecht}{Environment.NewLine}Alter: {pAlter}{Environment.NewLine}Tel. Nummer: {pNummer.ToString()}{Environment.NewLine}Email: {pEmail}", "Preview", MessageBoxButtons.OKCancel);

            if (preview == DialogResult.OK)
            {
                tboxClear();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO PatientDB (Vorname, Name, Geburtsdatum, Geschlecht, Age, Angemeldet, Abgemeldet, Nummer, Email) VALUES('{pVorname}', '{pName}', '{pGebDatum.ToShortDateString()}', '{pGeschlecht}', {pAlter}, '{DateTime.UtcNow}', '{null}', {pNummer}, '{pEmail}');";
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            SQLiteCommand command;
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB WHERE Vorname || Name || Geburtsdatum || ID || Geschlecht || Angemeldet || Age LIKE '%{tSearch.Text}%'";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                position = reader.GetInt32(id);
                loadPatient();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNextColorChanged();
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
                btnNext.BackColor = Color.DodgerBlue;
                btnNext.ForeColor = Color.White;
                position--;
                loadPatient();
            }
            else if (position == 1) { btnPrevious.BackColor = Color.Red; btnPrevious.ForeColor = Color.White; return; }
            else
            {
                position--;
                loadPatient();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Speichern")
            {
                readOnlyTboxes();
                updateEntry(tboxVorname.Text, tboxName.Text, tboxGDatum.Text, tboxGeschlecht.Text, tboxAngemeldet.Text, tboxNummer.Text, tboxEmail.Text);
                btnUpdate.Text = "Update";
            }
            else
            {
                disableReadOnly();
                btnUpdate.Text = "Speichern";
            }
        }



        //########################################################################### METHODE ##############################################################################

        void btnNextColorChanged() {
            if (btnUpdate.Text == "Speichern")
            {
                readOnlyTboxes();
                btnUpdate.Text = "Update";
            }
            else if (btnPrevious.BackColor == Color.Red && btnPrevious.ForeColor == Color.White)
            {
                btnPrevious.BackColor = Color.DodgerBlue;
                btnPrevious.ForeColor = Color.White;
                position++;
                loadPatient();
            }
            else if (position >= count) { btnNext.BackColor = Color.Red; btnNext.ForeColor = Color.White; }
            else
            {
                position++;
                loadPatient();
            }
        }

        void btnPreviousColorChanged() {
            if (btnUpdate.Text == "Speichern")
            {
                readOnlyTboxes();
                btnUpdate.Text = "Update";
            }
            else if (btnNext.BackColor == Color.Red && btnNext.ForeColor == Color.White)
            {
                btnNext.BackColor = Color.DodgerBlue;
                btnNext.ForeColor = Color.White;
                position--;
                loadPatient();
            }
            else if (position == 1) { btnPrevious.BackColor = Color.Red; btnPrevious.ForeColor = Color.White; return; }
            else
            {
                position--;
                loadPatient();
            }
        }

        void tboxClear()
        {
            tboxPVorname.Clear();
            tboxPNachname.Clear();
            tboxPEmail.Clear();
            tboxPNumber.Clear();
        }

        public void getFirstID()
        {
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
                tboxAngemeldet.Text = reader.GetString(angemeldet);
            }
        }//LOAD THE LIST OF PATIENT
        void readOnlyTboxes()
        {
            tboxAngemeldet.ReadOnly = true;
            tboxGDatum.ReadOnly = true;
            tboxGeschlecht.ReadOnly = true;
            tboxName.ReadOnly = true;
            tboxVorname.ReadOnly = true;
            tboxEmail.ReadOnly = true;
            tboxNummer.ReadOnly = true;
        }

        private void Tab_KeyDown(object sender, KeyEventArgs e)//Arrow keys
        {
            if (e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = true;
                btnNextColorChanged();
            }
            else if (e.KeyCode == Keys.Left)
            {
                btnPreviousColorChanged();
            }
            else if (e.KeyCode == Keys.Escape) {
                Environment.Exit(0);
            }
            else return;
        }

        void disableReadOnly()
        {
            tboxAngemeldet.ReadOnly = false;
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

        void updateEntry(string vorname, string name, string geburtsDatum, string geschlecht, string ankunft, string nummer, string email)//UPDATE DATA
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = con.CreateCommand();
            sqlite_cmd.CommandText = $"UPDATE PatientDB SET Vorname = '{vorname}', Name = '{name}', Geburtsdatum = '{geburtsDatum}', Geschlecht = '{geschlecht}', Angemeldet = '{ankunft}', Abgemeldet = '{null}', Nummer = '{nummer}', Email = '{email}' WHERE ID = {position};";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)//So called reload database
        {
            getFirstID();
            getTotalRows();
            loadPatient();
        }
    }
}
