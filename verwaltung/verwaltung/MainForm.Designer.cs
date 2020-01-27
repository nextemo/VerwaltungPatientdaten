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
            this.btnPatientBearb = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearch.Location = new System.Drawing.Point(675, 14);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(239, 32);
            this.tSearch.TabIndex = 0;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(507, 17);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(162, 26);
            this.lSearch.TabIndex = 1;
            this.lSearch.Text = "Patientensuche";
            // 
            // btnNeuPatient
            // 
            this.btnNeuPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuPatient.Location = new System.Drawing.Point(12, 12);
            this.btnNeuPatient.Name = "btnNeuPatient";
            this.btnNeuPatient.Size = new System.Drawing.Size(159, 35);
            this.btnNeuPatient.TabIndex = 2;
            this.btnNeuPatient.Text = "Neuer Patient";
            this.btnNeuPatient.UseVisualStyleBackColor = true;
            this.btnNeuPatient.Click += new System.EventHandler(this.btnNeuPatient_Click);
            // 
            // btnPatientBearb
            // 
            this.btnPatientBearb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientBearb.Location = new System.Drawing.Point(228, 12);
            this.btnPatientBearb.Name = "btnPatientBearb";
            this.btnPatientBearb.Size = new System.Drawing.Size(219, 35);
            this.btnPatientBearb.TabIndex = 3;
            this.btnPatientBearb.Text = "Patient bearbeiten";
            this.btnPatientBearb.UseVisualStyleBackColor = true;
            this.btnPatientBearb.Click += new System.EventHandler(this.btnPatientBearb_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuchen.Location = new System.Drawing.Point(920, 12);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(93, 35);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 599);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnPatientBearb);
            this.Controls.Add(this.btnNeuPatient);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.tSearch);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.Button btnNeuPatient;
        private System.Windows.Forms.Button btnPatientBearb;
        private System.Windows.Forms.Button btnSuchen;
    }
}