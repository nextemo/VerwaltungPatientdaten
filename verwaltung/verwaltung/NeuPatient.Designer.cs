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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPSpeichern = new System.Windows.Forms.Button();
            this.btnPSpeichernZurück = new System.Windows.Forms.Button();
            this.btnPZurück = new System.Windows.Forms.Button();
            this.tboxVorname = new System.Windows.Forms.TextBox();
            this.tboxNachname = new System.Windows.Forms.TextBox();
            this.btnPPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neuer Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nachname:";
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.Location = new System.Drawing.Point(12, 397);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnPSpeichern.TabIndex = 3;
            this.btnPSpeichern.Text = "Speichern";
            this.btnPSpeichern.UseVisualStyleBackColor = true;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            // 
            // btnPSpeichernZurück
            // 
            this.btnPSpeichernZurück.Location = new System.Drawing.Point(104, 397);
            this.btnPSpeichernZurück.Name = "btnPSpeichernZurück";
            this.btnPSpeichernZurück.Size = new System.Drawing.Size(122, 23);
            this.btnPSpeichernZurück.TabIndex = 4;
            this.btnPSpeichernZurück.Text = "Speicher und Zurück";
            this.btnPSpeichernZurück.UseVisualStyleBackColor = true;
            // 
            // btnPZurück
            // 
            this.btnPZurück.Location = new System.Drawing.Point(6, 2);
            this.btnPZurück.Name = "btnPZurück";
            this.btnPZurück.Size = new System.Drawing.Size(75, 23);
            this.btnPZurück.TabIndex = 5;
            this.btnPZurück.Text = "Zurück";
            this.btnPZurück.UseVisualStyleBackColor = true;
            this.btnPZurück.Click += new System.EventHandler(this.btnPZurück_Click);
            // 
            // tboxVorname
            // 
            this.tboxVorname.Location = new System.Drawing.Point(82, 74);
            this.tboxVorname.Name = "tboxVorname";
            this.tboxVorname.Size = new System.Drawing.Size(100, 20);
            this.tboxVorname.TabIndex = 6;
            // 
            // tboxNachname
            // 
            this.tboxNachname.Location = new System.Drawing.Point(82, 99);
            this.tboxNachname.Name = "tboxNachname";
            this.tboxNachname.Size = new System.Drawing.Size(100, 20);
            this.tboxNachname.TabIndex = 7;
            // 
            // btnPPreview
            // 
            this.btnPPreview.Location = new System.Drawing.Point(550, 397);
            this.btnPPreview.Name = "btnPPreview";
            this.btnPPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPPreview.TabIndex = 8;
            this.btnPPreview.Text = "Preview";
            this.btnPPreview.UseVisualStyleBackColor = true;
            // 
            // NeuPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPPreview);
            this.Controls.Add(this.tboxNachname);
            this.Controls.Add(this.tboxVorname);
            this.Controls.Add(this.btnPZurück);
            this.Controls.Add(this.btnPSpeichernZurück);
            this.Controls.Add(this.btnPSpeichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NeuPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neu Patient ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPSpeichern;
        private System.Windows.Forms.Button btnPSpeichernZurück;
        private System.Windows.Forms.Button btnPZurück;
        private System.Windows.Forms.TextBox tboxVorname;
        private System.Windows.Forms.TextBox tboxNachname;
        private System.Windows.Forms.Button btnPPreview;
    }
}