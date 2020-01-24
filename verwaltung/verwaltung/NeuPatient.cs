﻿using System;
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
        string pName, pVorname, pGebDatum, pAlter, pGeschlecht;
       
        public NeuPatient()
        {
            InitializeComponent();
        }

        private void btnPZurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPSpeichern_Click(object sender, EventArgs e) //neuer Patient anlegen
        {
            var vName = tboxPVorname.Text;
            var nName = tboxPNachname.Text;
            var geschlecht = tboxPGeschlecht.Text;
            var geburtsdatum = gebDatumPicker.Value;
            var neuPatient = new Patient(vName, nName, geburtsdatum, geschlecht);

            pName = neuPatient.Name;
            pVorname = neuPatient.Vorname;
            pGebDatum = neuPatient.Geburtsdatum.ToShortDateString();
            pGeschlecht = neuPatient.Geschlecht;
            pAlter = neuPatient.Alter.ToString();
        }

        private void btnPPreview_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Vorname: {pVorname} {Environment.NewLine}Name: {pName} { Environment.NewLine}Geburtsdatum: {pGebDatum}{Environment.NewLine}Geschlecht: {pGeschlecht}");
        }
    }
}