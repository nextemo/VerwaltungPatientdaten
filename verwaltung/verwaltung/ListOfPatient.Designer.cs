namespace verwaltung
{
    partial class ListOfPatient
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
            this.lbVorname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbGeburtsdatum = new System.Windows.Forms.Label();
            this.lbGeschlecht = new System.Windows.Forms.Label();
            this.lbAnkunft = new System.Windows.Forms.Label();
            this.tboxVorname = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxGDatum = new System.Windows.Forms.TextBox();
            this.tboxGeschlecht = new System.Windows.Forms.TextBox();
            this.tboxAnkunft = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorname.Location = new System.Drawing.Point(66, 21);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(101, 26);
            this.lbVorname.TabIndex = 0;
            this.lbVorname.Text = "Vorname";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(96, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(360, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(173, 298);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(126, 35);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtsdatum.Location = new System.Drawing.Point(17, 133);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(150, 26);
            this.lbGeburtsdatum.TabIndex = 4;
            this.lbGeburtsdatum.Text = "Geburtsdatum";
            // 
            // lbGeschlecht
            // 
            this.lbGeschlecht.AutoSize = true;
            this.lbGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeschlecht.Location = new System.Drawing.Point(46, 191);
            this.lbGeschlecht.Name = "lbGeschlecht";
            this.lbGeschlecht.Size = new System.Drawing.Size(121, 26);
            this.lbGeschlecht.TabIndex = 5;
            this.lbGeschlecht.Text = "Geschlecht";
            // 
            // lbAnkunft
            // 
            this.lbAnkunft.AutoSize = true;
            this.lbAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnkunft.Location = new System.Drawing.Point(81, 249);
            this.lbAnkunft.Name = "lbAnkunft";
            this.lbAnkunft.Size = new System.Drawing.Size(86, 26);
            this.lbAnkunft.TabIndex = 6;
            this.lbAnkunft.Text = "Ankunft";
            // 
            // tboxVorname
            // 
            this.tboxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVorname.Location = new System.Drawing.Point(173, 15);
            this.tboxVorname.Name = "tboxVorname";
            this.tboxVorname.Size = new System.Drawing.Size(313, 35);
            this.tboxVorname.TabIndex = 7;
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(173, 68);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(313, 35);
            this.tboxName.TabIndex = 8;
            // 
            // tboxGDatum
            // 
            this.tboxGDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGDatum.Location = new System.Drawing.Point(173, 127);
            this.tboxGDatum.Name = "tboxGDatum";
            this.tboxGDatum.Size = new System.Drawing.Size(313, 35);
            this.tboxGDatum.TabIndex = 9;
            // 
            // tboxGeschlecht
            // 
            this.tboxGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGeschlecht.Location = new System.Drawing.Point(173, 185);
            this.tboxGeschlecht.Name = "tboxGeschlecht";
            this.tboxGeschlecht.Size = new System.Drawing.Size(313, 35);
            this.tboxGeschlecht.TabIndex = 10;
            // 
            // tboxAnkunft
            // 
            this.tboxAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAnkunft.Location = new System.Drawing.Point(173, 243);
            this.tboxAnkunft.Name = "tboxAnkunft";
            this.tboxAnkunft.Size = new System.Drawing.Size(313, 35);
            this.tboxAnkunft.TabIndex = 11;
            // 
            // ListOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "ListOfPatient";
            this.Size = new System.Drawing.Size(507, 348);
            this.Load += new System.EventHandler(this.ListOfPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVorname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lbGeburtsdatum;
        private System.Windows.Forms.Label lbGeschlecht;
        private System.Windows.Forms.Label lbAnkunft;
        private System.Windows.Forms.TextBox tboxVorname;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxGDatum;
        private System.Windows.Forms.TextBox tboxGeschlecht;
        private System.Windows.Forms.TextBox tboxAnkunft;
    }
}
