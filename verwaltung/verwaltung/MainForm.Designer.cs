namespace verwaltung
{
    partial class MainForm
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
            this.tSearch = new System.Windows.Forms.TextBox();
            this.lSearch = new System.Windows.Forms.Label();
            this.btnNeuPatient = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.tboxAnkunft = new System.Windows.Forms.TextBox();
            this.tboxGeschlecht = new System.Windows.Forms.TextBox();
            this.tboxGDatum = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxVorname = new System.Windows.Forms.TextBox();
            this.lbAnkunft = new System.Windows.Forms.Label();
            this.lbGeschlecht = new System.Windows.Forms.Label();
            this.lbGeburtsdatum = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbVorname = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxNummer = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNummer = new System.Windows.Forms.Label();
            this.newPatient1 = new verwaltung.NewPatient();
            this.SuspendLayout();
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearch.Location = new System.Drawing.Point(705, 14);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(239, 32);
            this.tSearch.TabIndex = 0;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(542, 17);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(162, 26);
            this.lSearch.TabIndex = 1;
            this.lSearch.Text = "Patientensuche";
            this.lSearch.Click += new System.EventHandler(this.lSearch_Click);
            // 
            // btnNeuPatient
            // 
            this.btnNeuPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuPatient.Location = new System.Drawing.Point(91, 12);
            this.btnNeuPatient.Name = "btnNeuPatient";
            this.btnNeuPatient.Size = new System.Drawing.Size(159, 35);
            this.btnNeuPatient.TabIndex = 2;
            this.btnNeuPatient.Text = "Neuer Patient";
            this.btnNeuPatient.UseVisualStyleBackColor = true;
            this.btnNeuPatient.Click += new System.EventHandler(this.btnNeuPatient_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(292, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(219, 35);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sortieren";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // tboxAnkunft
            // 
            this.tboxAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAnkunft.Location = new System.Drawing.Point(376, 394);
            this.tboxAnkunft.Name = "tboxAnkunft";
            this.tboxAnkunft.Size = new System.Drawing.Size(398, 35);
            this.tboxAnkunft.TabIndex = 35;
            // 
            // tboxGeschlecht
            // 
            this.tboxGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGeschlecht.Location = new System.Drawing.Point(376, 252);
            this.tboxGeschlecht.Name = "tboxGeschlecht";
            this.tboxGeschlecht.Size = new System.Drawing.Size(398, 35);
            this.tboxGeschlecht.TabIndex = 34;
            // 
            // tboxGDatum
            // 
            this.tboxGDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGDatum.Location = new System.Drawing.Point(376, 202);
            this.tboxGDatum.Name = "tboxGDatum";
            this.tboxGDatum.Size = new System.Drawing.Size(398, 35);
            this.tboxGDatum.TabIndex = 33;
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(376, 158);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(398, 35);
            this.tboxName.TabIndex = 32;
            // 
            // tboxVorname
            // 
            this.tboxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVorname.Location = new System.Drawing.Point(376, 113);
            this.tboxVorname.Name = "tboxVorname";
            this.tboxVorname.Size = new System.Drawing.Size(398, 35);
            this.tboxVorname.TabIndex = 31;
            // 
            // lbAnkunft
            // 
            this.lbAnkunft.AutoSize = true;
            this.lbAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnkunft.Location = new System.Drawing.Point(278, 399);
            this.lbAnkunft.Name = "lbAnkunft";
            this.lbAnkunft.Size = new System.Drawing.Size(86, 26);
            this.lbAnkunft.TabIndex = 30;
            this.lbAnkunft.Text = "Ankunft";
            // 
            // lbGeschlecht
            // 
            this.lbGeschlecht.AutoSize = true;
            this.lbGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeschlecht.Location = new System.Drawing.Point(245, 257);
            this.lbGeschlecht.Name = "lbGeschlecht";
            this.lbGeschlecht.Size = new System.Drawing.Size(121, 26);
            this.lbGeschlecht.TabIndex = 29;
            this.lbGeschlecht.Text = "Geschlecht";
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtsdatum.Location = new System.Drawing.Point(219, 207);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(150, 26);
            this.lbGeburtsdatum.TabIndex = 28;
            this.lbGeburtsdatum.Text = "Geburtsdatum";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(428, 452);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 35);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "🡄";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(498, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 35);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "🡆 ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(250, 162);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 26);
            this.lbName.TabIndex = 25;
            this.lbName.Text = "Nachname";
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorname.Location = new System.Drawing.Point(266, 118);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(101, 26);
            this.lbVorname.TabIndex = 24;
            this.lbVorname.Text = "Vorname";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(605, 452);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 35);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(376, 348);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(398, 35);
            this.tboxEmail.TabIndex = 42;
            // 
            // tboxNummer
            // 
            this.tboxNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNummer.Location = new System.Drawing.Point(376, 301);
            this.tboxNummer.Name = "tboxNummer";
            this.tboxNummer.Size = new System.Drawing.Size(398, 35);
            this.tboxNummer.TabIndex = 41;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(295, 353);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(68, 26);
            this.lbEmail.TabIndex = 40;
            this.lbEmail.Text = "Email";
            // 
            // lbNummer
            // 
            this.lbNummer.AutoSize = true;
            this.lbNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNummer.Location = new System.Drawing.Point(231, 304);
            this.lbNummer.Name = "lbNummer";
            this.lbNummer.Size = new System.Drawing.Size(138, 26);
            this.lbNummer.TabIndex = 39;
            this.lbNummer.Text = "Tel. Nummer";
            // 
            // newPatient1
            // 
            this.newPatient1.Location = new System.Drawing.Point(122, 75);
            this.newPatient1.Name = "newPatient1";
            this.newPatient1.Size = new System.Drawing.Size(832, 470);
            this.newPatient1.TabIndex = 43;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 599);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxNummer);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNummer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tboxAnkunft);
            this.Controls.Add(this.tboxGeschlecht);
            this.Controls.Add(this.tboxGDatum);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxVorname);
            this.Controls.Add(this.lbAnkunft);
            this.Controls.Add(this.lbGeschlecht);
            this.Controls.Add(this.lbGeburtsdatum);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbVorname);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnNeuPatient);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.tSearch);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.Button btnNeuPatient;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox tboxAnkunft;
        private System.Windows.Forms.TextBox tboxGeschlecht;
        private System.Windows.Forms.TextBox tboxGDatum;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxVorname;
        private System.Windows.Forms.Label lbAnkunft;
        private System.Windows.Forms.Label lbGeschlecht;
        private System.Windows.Forms.Label lbGeburtsdatum;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbVorname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxNummer;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNummer;
        private NewPatient newPatient1;
    }
}