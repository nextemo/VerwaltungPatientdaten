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
        static string path = System.IO.Directory.GetCurrentDirectory();
        SQLiteConnection con = new SQLiteConnection($"Data Source = {path}/Patient.db; Version = 3;");//database initialize
        Font fontFamily = new Font("Microsoft Tai Le", 18, FontStyle.Bold);

        string pName, pVorname, pGeschlecht, pEmail;
        DateTime pGebDatum;
        int pAlter, pNummer;
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
        Point _mouseLoc;
        public TabForm()
        {
            InitializeComponent();
            con.Open();
            getFirstID();
            getTotalRows();
            loadPatient();
            tboxStyle(Color.Beige, Color.Teal);
            buttonStyle();
        }

        private void btnPSpeichern_Click(object sender, EventArgs e)// save the entered data
        {
            var vName = tboxPVorname.Text;
            var nName = tboxPNachname.Text;
            var geburtsdatum = gebDatumPicker.Value;

            if (rMänlich.Checked) pGeschlecht = "Mänlich";
            else if (rWeiblich.Checked) pGeschlecht = "Weiblich";
            else pGeschlecht = "Not available";

            try
            {
                pNummer = int.Parse(tboxPNumber.Text);
            }
            catch
            {
                MessageBox.Show("Telefon-Nummer darf nur Nummern enthalten!", "Actung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var email = tboxPEmail.Text;

            //update the Values
            vName = vName.Replace("  ", " ");
            nName = nName.Replace("  ", " ");

            try
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Mail-Addresse ist nicht gültig!", "Actung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //neuer Patient
            var neuPatient = new Patient(vName, nName, geburtsdatum, pGeschlecht, email, pNummer);

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

        private void tSearch_TextChanged(object sender, EventArgs e)//search patient
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
            btnPreviousColorChanged();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "SPEICHERN")
            {
                readOnlyTboxes();
                tboxesBorderDisabled();
                updateEntry(tboxVorname.Text, tboxName.Text, tboxGDatum.Text, tboxGeschlecht.Text, tboxAngemeldet.Text, tboxNummer.Text, tboxEmail.Text);
                btnUpdate.Text = "UPDATE";
            }
            else
            {
                disableReadOnly();
                tboxesBorderApplied();
                btnUpdate.Text = "SPEICHERN";
            }
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
            else if (e.KeyCode == Keys.Escape)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else return;
        }

        private void btnLogout_Click(object sender, EventArgs e)//logout or exit button
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void TabForm_MouseDown(object sender, MouseEventArgs e)//to make form moveable
        {
            _mouseLoc = e.Location;
        }

        private void TabForm_MouseMove(object sender, MouseEventArgs e)//form moveable
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        //########################################################################### METHODE ##############################################################################

        void tboxesBorderDisabled() {
            tboxName.BorderStyle = BorderStyle.None;
            tboxVorname.BorderStyle = BorderStyle.None;
            tboxGDatum.BorderStyle = BorderStyle.None;
            tboxGeschlecht.BorderStyle = BorderStyle.None;
            tboxNummer.BorderStyle = BorderStyle.None;
            tboxEmail.BorderStyle = BorderStyle.None;
            tboxAngemeldet.BorderStyle = BorderStyle.None;
        }

        void tboxesBorderApplied() {
            tboxName.BorderStyle = BorderStyle.FixedSingle;
            tboxVorname.BorderStyle = BorderStyle.FixedSingle;
            tboxGDatum.BorderStyle = BorderStyle.FixedSingle;
            tboxGeschlecht.BorderStyle = BorderStyle.FixedSingle;
            tboxNummer.BorderStyle = BorderStyle.FixedSingle;
            tboxEmail.BorderStyle = BorderStyle.FixedSingle;
            tboxAngemeldet.BorderStyle = BorderStyle.FixedSingle;
        }
        void buttonStyle() {
            btnUpdate.Font = fontFamily;
            btnPSpeichern.Font = fontFamily;

            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.CheckedBackColor = Color.Transparent;

            btnNext.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNext.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderColor = Color.White;

            btnPrevious.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPrevious.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrevious.FlatAppearance.BorderColor = Color.White;

            btnPSpeichern.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPSpeichern.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPSpeichern.FlatAppearance.BorderColor = Color.White;
        }
        
        void tboxStyle(Color backColor, Color textColor) {//textboxes style
            tboxVorname.BackColor = backColor;
            tboxVorname.ForeColor = textColor;
            tboxVorname.Font = fontFamily;
            //tboxVorname.TextAlign = HorizontalAlignment.Center;

            tboxName.BackColor = backColor;
            tboxName.ForeColor = textColor;
            tboxName.Font = fontFamily;
            //tboxName.TextAlign = HorizontalAlignment.Center;

            tboxGDatum.BackColor = backColor;
            tboxGDatum.ForeColor = textColor;
            tboxGDatum.Font = fontFamily;
            //tboxGDatum.TextAlign = HorizontalAlignment.Center;

            tboxGeschlecht.BackColor = backColor;
            tboxGeschlecht.ForeColor = textColor;
            tboxGeschlecht.Font = fontFamily;
            //tboxGeschlecht.TextAlign = HorizontalAlignment.Center;

            tboxNummer.BackColor = backColor;
            tboxNummer.ForeColor = textColor;
            tboxNummer.Font = fontFamily;
            //tboxNummer.TextAlign = HorizontalAlignment.Center;

            tboxEmail.BackColor = backColor;
            tboxEmail.ForeColor = textColor;
            tboxEmail.Font = fontFamily;
            //tboxEmail.TextAlign = HorizontalAlignment.Center;

            tboxAngemeldet.BackColor = backColor;
            tboxAngemeldet.ForeColor = textColor;
            tboxAngemeldet.Font = fontFamily;
            //tboxAngemeldet.TextAlign = HorizontalAlignment.Center;
        }


        void btnNextColorChanged() {
            if (btnUpdate.Text == "SPEICHERN")
            {
                readOnlyTboxes();
                tboxesBorderDisabled();
                btnUpdate.Text = "UPDATE";
            }
            else if (btnPrevious.ForeColor == Color.Red)
            {
                btnPrevious.ForeColor = Color.DodgerBlue;
                position++;
                loadPatient();
            }
            else if (position >= count) { btnNext.ForeColor = Color.Red; return; }
            else
            {
                position++;
                loadPatient();
            }
        }

        void btnPreviousColorChanged() {
            if (btnUpdate.Text == "SPEICHERN")
            {
                readOnlyTboxes();
                tboxesBorderDisabled();
                btnUpdate.Text = "UPDATE";
            }
            else if (btnNext.ForeColor == Color.Red)
            {
                btnNext.ForeColor = Color.DodgerBlue;
                position--;
                loadPatient();
            }
            else if (position == 1) { btnPrevious.ForeColor = Color.Red; return; }
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
        }//clear values in the textboxes 

        public void getFirstID()//getting the first ID of the first row
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

        public void loadPatient()//LOAD THE LIST OF PATIENT
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
        }
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

        void getTotalRows()//getting total rows available in the database
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

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)//database will be reloaded when tabpages change
        {
            getFirstID();
            getTotalRows();
            loadPatient();
        }
    }
}
