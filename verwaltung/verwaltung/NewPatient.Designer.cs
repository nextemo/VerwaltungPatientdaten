namespace verwaltung
{
    partial class NewPatient
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.tboxTelpNumber = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.lbTelpNum = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichern.Location = new System.Drawing.Point(648, 405);
            this.btnPSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(168, 43);
            this.btnPSpeichern.TabIndex = 36;
            this.btnPSpeichern.Text = "Speichern";
            this.btnPSpeichern.UseVisualStyleBackColor = true;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.Location = new System.Drawing.Point(648, 334);
            this.rWeiblich.Margin = new System.Windows.Forms.Padding(4);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(137, 35);
            this.rWeiblich.TabIndex = 35;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.Location = new System.Drawing.Point(441, 334);
            this.rMänlich.Margin = new System.Windows.Forms.Padding(4);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(128, 35);
            this.rMänlich.TabIndex = 34;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(346, 160);
            this.gebDatumPicker.Margin = new System.Windows.Forms.Padding(4);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(529, 41);
            this.gebDatumPicker.TabIndex = 33;
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.Location = new System.Drawing.Point(138, 167);
            this.lbPGebDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(186, 31);
            this.lbPGebDatum.TabIndex = 32;
            this.lbPGebDatum.Text = "Geburtsdatum";
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(346, 105);
            this.tboxPNachname.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(529, 41);
            this.tboxPNachname.TabIndex = 31;
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(346, 50);
            this.tboxPVorname.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(529, 41);
            this.tboxPVorname.TabIndex = 30;
            // 
            // btnPZurück
            // 
            this.btnPZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPZurück.Location = new System.Drawing.Point(413, 405);
            this.btnPZurück.Margin = new System.Windows.Forms.Padding(4);
            this.btnPZurück.Name = "btnPZurück";
            this.btnPZurück.Size = new System.Drawing.Size(168, 43);
            this.btnPZurück.TabIndex = 29;
            this.btnPZurück.Text = "Zurück";
            this.btnPZurück.UseVisualStyleBackColor = true;
            this.btnPZurück.Click += new System.EventHandler(this.btnPZurück_Click);
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.Location = new System.Drawing.Point(179, 111);
            this.lbPNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(145, 31);
            this.lbPNachname.TabIndex = 28;
            this.lbPNachname.Text = "Nachname";
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.Location = new System.Drawing.Point(201, 56);
            this.lbPVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(123, 31);
            this.lbPVorname.TabIndex = 27;
            this.lbPVorname.Text = "Vorname";
            // 
            // tboxTelpNumber
            // 
            this.tboxTelpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTelpNumber.Location = new System.Drawing.Point(346, 221);
            this.tboxTelpNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tboxTelpNumber.Name = "tboxTelpNumber";
            this.tboxTelpNumber.Size = new System.Drawing.Size(529, 41);
            this.tboxTelpNumber.TabIndex = 37;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(346, 281);
            this.tboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(529, 41);
            this.tboxEmail.TabIndex = 38;
            // 
            // lbTelpNum
            // 
            this.lbTelpNum.AutoSize = true;
            this.lbTelpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelpNum.Location = new System.Drawing.Point(154, 227);
            this.lbTelpNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelpNum.Name = "lbTelpNum";
            this.lbTelpNum.Size = new System.Drawing.Size(170, 31);
            this.lbTelpNum.TabIndex = 39;
            this.lbTelpNum.Text = "Tel. Nummer";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(243, 287);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(81, 31);
            this.lbEmail.TabIndex = 40;
            this.lbEmail.Text = "Email";
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelpNum);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxTelpNumber);
            this.Controls.Add(this.btnPSpeichern);
            this.Controls.Add(this.rWeiblich);
            this.Controls.Add(this.rMänlich);
            this.Controls.Add(this.gebDatumPicker);
            this.Controls.Add(this.lbPGebDatum);
            this.Controls.Add(this.tboxPNachname);
            this.Controls.Add(this.tboxPVorname);
            this.Controls.Add(this.btnPZurück);
            this.Controls.Add(this.lbPNachname);
            this.Controls.Add(this.lbPVorname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPatient";
            this.Size = new System.Drawing.Size(1057, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tboxTelpNumber;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label lbTelpNum;
        private System.Windows.Forms.Label lbEmail;
    }
}
