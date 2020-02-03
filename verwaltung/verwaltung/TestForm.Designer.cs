namespace verwaltung
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListPatient = new System.Windows.Forms.TabControl();
            this.NewPatient = new System.Windows.Forms.TabPage();
            this.PatientList = new System.Windows.Forms.TabPage();
            this.btnPSpeichern = new System.Windows.Forms.Button();
            this.rWeiblich = new System.Windows.Forms.RadioButton();
            this.rMänlich = new System.Windows.Forms.RadioButton();
            this.gebDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.lbPGebDatum = new System.Windows.Forms.Label();
            this.tboxPNachname = new System.Windows.Forms.TextBox();
            this.tboxPVorname = new System.Windows.Forms.TextBox();
            this.btnPZurück = new System.Windows.Forms.Button();
            this.lbPNachname = new System.Windows.Forms.Label();
            this.lbPVorname = new System.Windows.Forms.Label();
            this.ListPatient.SuspendLayout();
            this.NewPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPatient
            // 
            this.ListPatient.Controls.Add(this.NewPatient);
            this.ListPatient.Controls.Add(this.PatientList);
            this.ListPatient.Location = new System.Drawing.Point(12, 12);
            this.ListPatient.Name = "ListPatient";
            this.ListPatient.SelectedIndex = 0;
            this.ListPatient.Size = new System.Drawing.Size(1128, 598);
            this.ListPatient.TabIndex = 0;
            // 
            // NewPatient
            // 
            this.NewPatient.Controls.Add(this.btnPSpeichern);
            this.NewPatient.Controls.Add(this.rWeiblich);
            this.NewPatient.Controls.Add(this.rMänlich);
            this.NewPatient.Controls.Add(this.gebDatumPicker);
            this.NewPatient.Controls.Add(this.lbPGebDatum);
            this.NewPatient.Controls.Add(this.tboxPNachname);
            this.NewPatient.Controls.Add(this.tboxPVorname);
            this.NewPatient.Controls.Add(this.btnPZurück);
            this.NewPatient.Controls.Add(this.lbPNachname);
            this.NewPatient.Controls.Add(this.lbPVorname);
            this.NewPatient.Location = new System.Drawing.Point(4, 25);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Padding = new System.Windows.Forms.Padding(3);
            this.NewPatient.Size = new System.Drawing.Size(1120, 569);
            this.NewPatient.TabIndex = 0;
            this.NewPatient.Text = "New Patient";
            this.NewPatient.UseVisualStyleBackColor = true;
            // 
            // PatientList
            // 
            this.PatientList.Location = new System.Drawing.Point(4, 25);
            this.PatientList.Name = "PatientList";
            this.PatientList.Padding = new System.Windows.Forms.Padding(3);
            this.PatientList.Size = new System.Drawing.Size(1120, 569);
            this.PatientList.TabIndex = 1;
            this.PatientList.Text = "List of Patient";
            this.PatientList.UseVisualStyleBackColor = true;
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichern.Location = new System.Drawing.Point(658, 320);
            this.btnPSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(168, 43);
            this.btnPSpeichern.TabIndex = 46;
            this.btnPSpeichern.Text = "Speichern";
            this.btnPSpeichern.UseVisualStyleBackColor = true;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.Location = new System.Drawing.Point(658, 249);
            this.rWeiblich.Margin = new System.Windows.Forms.Padding(4);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(137, 35);
            this.rWeiblich.TabIndex = 45;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.Location = new System.Drawing.Point(451, 249);
            this.rMänlich.Margin = new System.Windows.Forms.Padding(4);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(128, 35);
            this.rMänlich.TabIndex = 44;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(357, 183);
            this.gebDatumPicker.Margin = new System.Windows.Forms.Padding(4);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(529, 41);
            this.gebDatumPicker.TabIndex = 43;
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.Location = new System.Drawing.Point(141, 183);
            this.lbPGebDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(194, 31);
            this.lbPGebDatum.TabIndex = 42;
            this.lbPGebDatum.Text = "Geburtsdatum:";
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(357, 128);
            this.tboxPNachname.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(529, 41);
            this.tboxPNachname.TabIndex = 41;
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(357, 73);
            this.tboxPVorname.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(529, 41);
            this.tboxPVorname.TabIndex = 40;
            // 
            // btnPZurück
            // 
            this.btnPZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPZurück.Location = new System.Drawing.Point(423, 320);
            this.btnPZurück.Margin = new System.Windows.Forms.Padding(4);
            this.btnPZurück.Name = "btnPZurück";
            this.btnPZurück.Size = new System.Drawing.Size(168, 43);
            this.btnPZurück.TabIndex = 39;
            this.btnPZurück.Text = "Zurück";
            this.btnPZurück.UseVisualStyleBackColor = true;
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.Location = new System.Drawing.Point(183, 135);
            this.lbPNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(153, 31);
            this.lbPNachname.TabIndex = 38;
            this.lbPNachname.Text = "Nachname:";
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.Location = new System.Drawing.Point(206, 80);
            this.lbPVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(131, 31);
            this.lbPVorname.TabIndex = 37;
            this.lbPVorname.Text = "Vorname:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 737);
            this.Controls.Add(this.ListPatient);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ListPatient.ResumeLayout(false);
            this.NewPatient.ResumeLayout(false);
            this.NewPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ListPatient;
        private System.Windows.Forms.TabPage NewPatient;
        private System.Windows.Forms.TabPage PatientList;
        private System.Windows.Forms.Button btnPSpeichern;
        private System.Windows.Forms.RadioButton rWeiblich;
        private System.Windows.Forms.RadioButton rMänlich;
        private System.Windows.Forms.DateTimePicker gebDatumPicker;
        private System.Windows.Forms.Label lbPGebDatum;
        private System.Windows.Forms.TextBox tboxPNachname;
        private System.Windows.Forms.TextBox tboxPVorname;
        private System.Windows.Forms.Button btnPZurück;
        private System.Windows.Forms.Label lbPNachname;
        private System.Windows.Forms.Label lbPVorname;
    }
}