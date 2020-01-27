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
            this.lvPatientListview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvPatientListview
            // 
            this.lvPatientListview.HideSelection = false;
            this.lvPatientListview.Location = new System.Drawing.Point(39, 35);
            this.lvPatientListview.Name = "lvPatientListview";
            this.lvPatientListview.Size = new System.Drawing.Size(643, 368);
            this.lvPatientListview.TabIndex = 0;
            this.lvPatientListview.UseCompatibleStateImageBehavior = false;
            // 
            // ListOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPatientListview);
            this.Name = "ListOfPatient";
            this.Size = new System.Drawing.Size(727, 448);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPatientListview;
    }
}
