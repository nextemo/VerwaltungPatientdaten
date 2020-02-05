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
using System.Data.SQLite;

namespace verwaltung
{
    public partial class NewPatient : UserControl
    {
        string pName, pVorname, pGeschlecht, pEmail;
        DateTime pGebDatum;
        int pAlter, pNummer;

        SQLiteConnection con = new SQLiteConnection("Data Source = C:/sqlite/Patient.db; Version = 3;");
        public NewPatient()
        {
            InitializeComponent();
        }

        private void btnPZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.tboxPVorname.Clear();
            this.tboxPNachname.Clear();
            MainForm mainForm = new MainForm();
            mainForm.loadPatient();
        }

        private void btnPSpeichern_Click(object sender, EventArgs e)
        {
            var vName = tboxPVorname.Text;
            var nName = tboxPNachname.Text;
            var geburtsdatum = gebDatumPicker.Value;
            if (rMänlich.Checked) pGeschlecht = "Mänlich";
            else if (rWeiblich.Checked) pGeschlecht = "Weiblich";
            else pGeschlecht = "Not available";
            var nummer = Convert.ToInt32(tboxTelpNumber.Text);
            var email = tboxEmail.Text;
            var neuPatient = new Patient(vName, nName, geburtsdatum, pGeschlecht, email, nummer);

            pName = neuPatient.Name;
            pVorname = neuPatient.Vorname;
            pGebDatum = neuPatient.Geburtsdatum;
            pGeschlecht = neuPatient.Geschlecht;
            pAlter = neuPatient.Alter;
            pNummer = neuPatient.Nummer;
            pEmail = neuPatient.Email;

            DialogResult preview = MessageBox.Show($"Vorname: {pVorname} {Environment.NewLine}Name: {pName} { Environment.NewLine}Geburtsdatum: {pGebDatum.ToShortDateString()}{Environment.NewLine}Geschlecht: {pGeschlecht}{Environment.NewLine}Alter: {pAlter}{Environment.NewLine}Tel. Nummer: {pNummer.ToString()}{Environment.NewLine}Email: {pEmail}", "Preview", MessageBoxButtons.OKCancel);

            if (preview == DialogResult.OK) {
                tboxClear();
                con.Open();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO PatientDB (Vorname, Name, Geburtsdatum, Geschlecht, Age, Ankunft, Auskunft, Nummer, Email) VALUES('{pVorname}', '{pName}', '{pGebDatum.ToShortDateString()}', '{pGeschlecht}', {pAlter}, '{DateTime.UtcNow}', 'Null', {pNummer}, '{pEmail}');";
                sqlite_cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        void tboxClear() {
            tboxPVorname.Clear();
            tboxPNachname.Clear();
            tboxEmail.Clear();
            tboxTelpNumber.Clear();
        }
    }
}
