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
        SQLiteCommand command; 
        Font fontFamily = new Font("Microsoft Tai Le", 18, FontStyle.Bold);

        string pName, pVorname, pGeschlecht, pEmail, pKrankheit;
        DateTime pGebDatum;
        int pAlter, pNummer, position, count;

        int id = 0;
        int vorname = 1;
        int name = 2;
        int geburtsdatum = 3;
        int geschlecht = 4;
        int angemeldet = 6;
        int nummer = 8;
        int email = 9;
        int krankheit = 10;

        Point mouseLoc;
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
            if (rMänlich.Checked) pGeschlecht = "Mänlich";
            else if (rWeiblich.Checked) pGeschlecht = "Weiblich";
            else pGeschlecht = "Not available";

            try
            {
                pNummer = Convert.ToInt32(tboxPNumber.Text);
            }
            catch
            {
                MessageBox.Show("Telefon-Nummer darf nur Nummern enthalten!", "Actung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //update the Values
            tboxPVorname.Text = tboxPVorname.Text.Replace("  ", " ");
            tboxPNachname.Text = tboxPNachname.Text.Replace("  ", " ");

            try //check the email format
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(tboxPEmail.Text);
            }
            catch
            {
                MessageBox.Show("Mail-Addresse ist nicht gültig!", "Actung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //neuer Patient
            var neuPatient = new Patient(tboxPVorname.Text, tboxPNachname.Text, gebDatumPicker.Value, pGeschlecht, tboxPEmail.Text, pNummer, tboxPKrankheit.Text);

            pName = neuPatient.Name;
            pVorname = neuPatient.Vorname;
            pGebDatum = neuPatient.Geburtsdatum;
            pGeschlecht = neuPatient.Geschlecht;
            pAlter = neuPatient.Alter;
            pNummer = neuPatient.Nummer;
            pEmail = neuPatient.Email;
            pKrankheit = neuPatient.Krankheit;

            DialogResult preview = MessageBox.Show($"Vorname: {pVorname} {Environment.NewLine}Name: {pName} { Environment.NewLine}Geburtsdatum: {pGebDatum.ToShortDateString()}{Environment.NewLine}Geschlecht: {pGeschlecht}{Environment.NewLine}Alter: {pAlter}{Environment.NewLine}Tel. Nummer: {pNummer.ToString()}{Environment.NewLine}Email: {pEmail}{Environment.NewLine}Krankheit: {pKrankheit}"
            ,"Eintrag richtig?", MessageBoxButtons.OKCancel);

            if (preview == DialogResult.OK)
            {
                tboxClear();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO PatientDB (Vorname, Name, Geburtsdatum, Geschlecht, Age, Angemeldet, Abgemeldet, Nummer, Email, Krankheit) VALUES('{pVorname}', '{pName}', '{pGebDatum.ToShortDateString()}', '{pGeschlecht}', {pAlter}, '{DateTime.UtcNow}', '{null}', {pNummer}, '{pEmail}', '{pKrankheit}')";
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        private void tSearch_TextChanged(object sender, EventArgs e)//search patient
        {
            command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM PatientDB WHERE Vorname || Name || Geburtsdatum || ID || Geschlecht || Angemeldet || Age LIKE '%{tSearch.Text}%'";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                position = reader.GetInt32(id);
                loadPatient();
            }
        }

        public void getFirstID()//getting the first ID of the first row
        {
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
                tboxKrankheit.Text = reader.GetString(krankheit);
            }
        }

        void getTotalRows()//getting total rows available in the database
        {
            command = con.CreateCommand();
            command.CommandText = $"SELECT COUNT(*) FROM PatientDB";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
        }

        void updateEntry(string vorname, string name, string geburtsDatum, string geschlecht, string ankunft, string nummer, string email, string krankheit)//UPDATE DATA
        {
            command = con.CreateCommand();
            command.CommandText = $"UPDATE PatientDB SET Vorname = '{vorname}', Name = '{name}', Geburtsdatum = '{geburtsDatum}', Geschlecht = '{geschlecht}', Angemeldet = '{ankunft}', Abgemeldet = '{null}', Nummer = '{nummer}', Email = '{email}', Krankheit = '{krankheit}' WHERE ID = {position};";
            command.ExecuteNonQuery();
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
                updateEntry(tboxVorname.Text, tboxName.Text, tboxGDatum.Text, tboxGeschlecht.Text, tboxAngemeldet.Text, tboxNummer.Text, tboxEmail.Text, tboxKrankheit.Text);
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
            mouseLoc = e.Location;
        }

        private void TabForm_MouseMove(object sender, MouseEventArgs e)//form moveable
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        //########################################################################### User Interface ##############################################################################

        void tboxesBorderDisabled() {
            tboxName.BorderStyle = BorderStyle.None;
            tboxVorname.BorderStyle = BorderStyle.None;
            tboxGDatum.BorderStyle = BorderStyle.None;
            tboxGeschlecht.BorderStyle = BorderStyle.None;
            tboxNummer.BorderStyle = BorderStyle.None;
            tboxEmail.BorderStyle = BorderStyle.None;
            tboxAngemeldet.BorderStyle = BorderStyle.None;
            tboxKrankheit.BorderStyle = BorderStyle.None;
        }

        void tboxesBorderApplied() {
            tboxName.BorderStyle = BorderStyle.FixedSingle;
            tboxVorname.BorderStyle = BorderStyle.FixedSingle;
            tboxGDatum.BorderStyle = BorderStyle.FixedSingle;
            tboxGeschlecht.BorderStyle = BorderStyle.FixedSingle;
            tboxNummer.BorderStyle = BorderStyle.FixedSingle;
            tboxEmail.BorderStyle = BorderStyle.FixedSingle;
            tboxAngemeldet.BorderStyle = BorderStyle.FixedSingle;
            tboxKrankheit.BorderStyle = BorderStyle.FixedSingle;
        }
        void buttonStyle() {
            btnUpdate.Font = fontFamily;
            btnPSpeichern.Font = fontFamily;

            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatAppearance.CheckedBackColor = Color.Transparent;

            btnNext.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNext.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderColor = Color.White;
            btnNext.FlatAppearance.CheckedBackColor = Color.Transparent;


            btnPrevious.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPrevious.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrevious.FlatAppearance.BorderColor = Color.White;
            btnPrevious.FlatAppearance.CheckedBackColor = Color.Transparent;

            btnPSpeichern.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPSpeichern.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPSpeichern.FlatAppearance.BorderColor = Color.White;
            btnPSpeichern.FlatAppearance.CheckedBackColor = Color.Transparent;
        }
        
        void tboxStyle(Color backColor, Color textColor) {//textboxes style
            tboxVorname.BackColor = backColor;
            tboxVorname.ForeColor = textColor;
            tboxVorname.Font = fontFamily;

            tboxName.BackColor = backColor;
            tboxName.ForeColor = textColor;
            tboxName.Font = fontFamily;

            tboxGDatum.BackColor = backColor;
            tboxGDatum.ForeColor = textColor;
            tboxGDatum.Font = fontFamily;

            tboxGeschlecht.BackColor = backColor;
            tboxGeschlecht.ForeColor = textColor;
            tboxGeschlecht.Font = fontFamily;

            tboxNummer.BackColor = backColor;
            tboxNummer.ForeColor = textColor;
            tboxNummer.Font = fontFamily;

            tboxEmail.BackColor = backColor;
            tboxEmail.ForeColor = textColor;
            tboxEmail.Font = fontFamily;

            tboxAngemeldet.BackColor = backColor;
            tboxAngemeldet.ForeColor = textColor;
            tboxAngemeldet.Font = fontFamily;

            tboxKrankheit.BackColor = backColor;
            tboxKrankheit.ForeColor = textColor;
            tboxKrankheit.Font = fontFamily;
        }

        void btnNextColorChanged() {
            btnNext.FindForm();
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
            else if(btnNext.ForeColor == Color.Red) return;
            else if (position >= count) { btnNext.ForeColor = Color.Red; return; }
            else
            {
                position++;
                loadPatient();
            }
        }

        void btnPreviousColorChanged() {
            btnPrevious.FindForm();
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
            else if (btnPrevious.ForeColor == Color.Red) return;
            else if (position == 1) { btnPrevious.ForeColor = Color.Red; return; }
            else
            {
                position--;
                loadPatient();
            }
        }

        void tboxClear()//clear values in the textboxes 
        {
            tboxPVorname.Clear();
            tboxPNachname.Clear();
            tboxPEmail.Clear();
            tboxPNumber.Clear();
            tboxPKrankheit.Clear();
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
            tboxKrankheit.ReadOnly = true;
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
            tboxKrankheit.ReadOnly = false;
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)//database will be reloaded when tabpages change
        {
            getFirstID();
            getTotalRows();
            loadPatient();
        }

        //################################################################## BUTTON PRESSED ANIMATION ################################################################
        private void btnNext_MouseUp(object sender, MouseEventArgs e)
        {
            btnNext.Location = new Point(569, 27);
        }

        private void btnNext_MouseDown(object sender, MouseEventArgs e)
        {
            btnNext.Location = new Point(570, 28);
        }

        private void btnPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            btnPrevious.Location = new Point(13, 28);
        }

        private void btnPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            btnPrevious.Location = new Point(12, 27);
        }

        private void btnUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            btnUpdate.Location = new Point(133, 404);
        }

        private void btnUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            btnUpdate.Location = new Point(132, 403);
        }

        private void btnPSpeichern_MouseDown(object sender, MouseEventArgs e)
        {
            btnPSpeichern.Location = new Point(162, 522);
        }

        private void btnPSpeichern_MouseUp(object sender, MouseEventArgs e)
        {
            btnPSpeichern.Location = new Point(161, 521);
        }
    }
}
