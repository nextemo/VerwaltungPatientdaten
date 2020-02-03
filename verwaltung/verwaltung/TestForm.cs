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
    public partial class TestForm : Form
    {
        string pName, pVorname;
        DateTime pGebDatum;
        int pAlter;
        string pGeschlecht;
        SQLiteConnection con = new SQLiteConnection("Data Source = C:/sqlite/Patient.db; Version = 3;");
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnPSpeichern_Click(object sender, EventArgs e)
        {
            var vName = tboxPVorname.Text;
            var nName = tboxPNachname.Text;
            var geburtsdatum = gebDatumPicker.Value;
            if (rMänlich.Checked) pGeschlecht = "Mänlich";
            else if (rWeiblich.Checked) pGeschlecht = "Weiblich";
            else pGeschlecht = "Not available";
            var neuPatient = new Patient(vName, nName, geburtsdatum, pGeschlecht);

            pName = neuPatient.Name;
            pVorname = neuPatient.Vorname;
            pGebDatum = neuPatient.Geburtsdatum;
            pGeschlecht = neuPatient.Geschlecht;
            pAlter = neuPatient.Alter;

            DialogResult preview = MessageBox.Show($"Vorname: {pVorname} {Environment.NewLine}Name: {pName} { Environment.NewLine}Geburtsdatum: {pGebDatum.ToShortDateString()}{Environment.NewLine}Geschlecht: {pGeschlecht}{Environment.NewLine}Alter: {pAlter}", "Preview", MessageBoxButtons.OKCancel);

            if (preview == DialogResult.OK)
            {
                this.tboxPVorname.Clear();
                this.tboxPNachname.Clear();

                con.Open();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO PatientDB (Vorname, Name, Geburtsdatum, Geschlecht, Age, Ankunft, Auskunft) VALUES('{pVorname}', '{pName}', '{pGebDatum.ToLongDateString()}', '{pGeschlecht}', {pAlter}, '{DateTime.UtcNow}', 'Null');";
                sqlite_cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
