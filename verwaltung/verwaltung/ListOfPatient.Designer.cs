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
            this.lbGeburtsdatum = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Location = new System.Drawing.Point(84, 74);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(35, 13);
            this.lbVorname.TabIndex = 0;
            this.lbVorname.Text = "label1";
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Location = new System.Drawing.Point(84, 109);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(35, 13);
            this.lbGeburtsdatum.TabIndex = 1;
            this.lbGeburtsdatum.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(360, 319);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(159, 319);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // ListOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbGeburtsdatum);
            this.Controls.Add(this.lbVorname);
            this.Name = "ListOfPatient";
            this.Size = new System.Drawing.Size(727, 448);
            this.Load += new System.EventHandler(this.ListOfPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVorname;
        private System.Windows.Forms.Label lbGeburtsdatum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}
