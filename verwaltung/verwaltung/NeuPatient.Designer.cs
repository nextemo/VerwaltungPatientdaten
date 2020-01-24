namespace verwaltung
{
    partial class NeuPatient
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
            this.lbPVorname = new System.Windows.Forms.Label();
            this.lbPNachname = new System.Windows.Forms.Label();
            this.btnPSpeichern = new System.Windows.Forms.Button();
            this.btnPSpeichernZurück = new System.Windows.Forms.Button();
            this.btnPZurück = new System.Windows.Forms.Button();
            this.tboxPVorname = new System.Windows.Forms.TextBox();
            this.tboxPNachname = new System.Windows.Forms.TextBox();
            this.btnPPreview = new System.Windows.Forms.Button();
            this.lbPGebDatum = new System.Windows.Forms.Label();
            this.gebDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.rMänlich = new System.Windows.Forms.RadioButton();
            this.rWeiblich = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.Location = new System.Drawing.Point(270, 134);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(107, 26);
            this.lbPVorname.TabIndex = 1;
            this.lbPVorname.Text = "Vorname:";
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.Location = new System.Drawing.Point(253, 179);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(124, 26);
            this.lbPNachname.TabIndex = 2;
            this.lbPNachname.Text = "Nachname:";
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichern.Location = new System.Drawing.Point(383, 329);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(126, 35);
            this.btnPSpeichern.TabIndex = 3;
            this.btnPSpeichern.Text = "Speichern";
            this.btnPSpeichern.UseVisualStyleBackColor = true;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            // 
            // btnPSpeichernZurück
            // 
            this.btnPSpeichernZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichernZurück.Location = new System.Drawing.Point(552, 329);
            this.btnPSpeichernZurück.Name = "btnPSpeichernZurück";
            this.btnPSpeichernZurück.Size = new System.Drawing.Size(229, 35);
            this.btnPSpeichernZurück.TabIndex = 4;
            this.btnPSpeichernZurück.Text = "Speicher und Zurück";
            this.btnPSpeichernZurück.UseVisualStyleBackColor = true;
            // 
            // btnPZurück
            // 
            this.btnPZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPZurück.Location = new System.Drawing.Point(12, 12);
            this.btnPZurück.Name = "btnPZurück";
            this.btnPZurück.Size = new System.Drawing.Size(97, 35);
            this.btnPZurück.TabIndex = 5;
            this.btnPZurück.Text = "Zurück";
            this.btnPZurück.UseVisualStyleBackColor = true;
            this.btnPZurück.Click += new System.EventHandler(this.btnPZurück_Click);
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(383, 128);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(398, 35);
            this.tboxPVorname.TabIndex = 6;
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(383, 173);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(398, 35);
            this.tboxPNachname.TabIndex = 7;
            // 
            // btnPPreview
            // 
            this.btnPPreview.Location = new System.Drawing.Point(911, 549);
            this.btnPPreview.Name = "btnPPreview";
            this.btnPPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPPreview.TabIndex = 8;
            this.btnPPreview.Text = "Preview";
            this.btnPPreview.UseVisualStyleBackColor = true;
            this.btnPPreview.Click += new System.EventHandler(this.btnPPreview_Click);
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.Location = new System.Drawing.Point(221, 218);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(156, 26);
            this.lbPGebDatum.TabIndex = 9;
            this.lbPGebDatum.Text = "Geburtsdatum:";
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(383, 218);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(398, 35);
            this.gebDatumPicker.TabIndex = 10;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.Location = new System.Drawing.Point(454, 271);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(105, 30);
            this.rMänlich.TabIndex = 15;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.Location = new System.Drawing.Point(609, 271);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(113, 30);
            this.rWeiblich.TabIndex = 16;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // NeuPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 599);
            this.Controls.Add(this.rWeiblich);
            this.Controls.Add(this.rMänlich);
            this.Controls.Add(this.gebDatumPicker);
            this.Controls.Add(this.lbPGebDatum);
            this.Controls.Add(this.btnPPreview);
            this.Controls.Add(this.tboxPNachname);
            this.Controls.Add(this.tboxPVorname);
            this.Controls.Add(this.btnPZurück);
            this.Controls.Add(this.btnPSpeichernZurück);
            this.Controls.Add(this.btnPSpeichern);
            this.Controls.Add(this.lbPNachname);
            this.Controls.Add(this.lbPVorname);
            this.Name = "NeuPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neu Patient ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPVorname;
        private System.Windows.Forms.Label lbPNachname;
        private System.Windows.Forms.Button btnPSpeichern;
        private System.Windows.Forms.Button btnPSpeichernZurück;
        private System.Windows.Forms.Button btnPZurück;
        private System.Windows.Forms.TextBox tboxPVorname;
        private System.Windows.Forms.TextBox tboxPNachname;
        private System.Windows.Forms.Button btnPPreview;
        private System.Windows.Forms.Label lbPGebDatum;
        private System.Windows.Forms.DateTimePicker gebDatumPicker;
        private System.Windows.Forms.RadioButton rMänlich;
        private System.Windows.Forms.RadioButton rWeiblich;
    }
}