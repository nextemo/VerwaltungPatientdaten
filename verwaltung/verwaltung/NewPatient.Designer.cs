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
            this.button1 = new System.Windows.Forms.Button();
            this.rWeiblich = new System.Windows.Forms.RadioButton();
            this.rMänlich = new System.Windows.Forms.RadioButton();
            this.gebDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.lbPGebDatum = new System.Windows.Forms.Label();
            this.tboxPNachname = new System.Windows.Forms.TextBox();
            this.tboxPVorname = new System.Windows.Forms.TextBox();
            this.btnPZurück = new System.Windows.Forms.Button();
            this.lbPNachname = new System.Windows.Forms.Label();
            this.lbPVorname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(396, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.Location = new System.Drawing.Point(396, 150);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(113, 30);
            this.rWeiblich.TabIndex = 35;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.Location = new System.Drawing.Point(241, 150);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(105, 30);
            this.rMänlich.TabIndex = 34;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(170, 97);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(398, 35);
            this.gebDatumPicker.TabIndex = 33;
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.Location = new System.Drawing.Point(8, 97);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(156, 26);
            this.lbPGebDatum.TabIndex = 32;
            this.lbPGebDatum.Text = "Geburtsdatum:";
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(170, 52);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(398, 35);
            this.tboxPNachname.TabIndex = 31;
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(170, 7);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(398, 35);
            this.tboxPVorname.TabIndex = 30;
            // 
            // btnPZurück
            // 
            this.btnPZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPZurück.Location = new System.Drawing.Point(220, 208);
            this.btnPZurück.Name = "btnPZurück";
            this.btnPZurück.Size = new System.Drawing.Size(126, 35);
            this.btnPZurück.TabIndex = 29;
            this.btnPZurück.Text = "Zurück";
            this.btnPZurück.UseVisualStyleBackColor = true;
            this.btnPZurück.Click += new System.EventHandler(this.btnPZurück_Click);
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.Location = new System.Drawing.Point(40, 58);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(124, 26);
            this.lbPNachname.TabIndex = 28;
            this.lbPNachname.Text = "Nachname:";
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.Location = new System.Drawing.Point(57, 13);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(107, 26);
            this.lbPVorname.TabIndex = 27;
            this.lbPVorname.Text = "Vorname:";
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rWeiblich);
            this.Controls.Add(this.rMänlich);
            this.Controls.Add(this.gebDatumPicker);
            this.Controls.Add(this.lbPGebDatum);
            this.Controls.Add(this.tboxPNachname);
            this.Controls.Add(this.tboxPVorname);
            this.Controls.Add(this.btnPZurück);
            this.Controls.Add(this.lbPNachname);
            this.Controls.Add(this.lbPVorname);
            this.Name = "NewPatient";
            this.Size = new System.Drawing.Size(578, 254);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
