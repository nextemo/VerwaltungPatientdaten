namespace verwaltung
{
    partial class TabForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabForm));
            this.Tab = new System.Windows.Forms.TabControl();
            this.ListOfPatient = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxKrankheit = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxNummer = new System.Windows.Forms.TextBox();
            this.tboxAngemeldet = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tboxGeschlecht = new System.Windows.Forms.TextBox();
            this.tboxGDatum = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxVorname = new System.Windows.Forms.TextBox();
            this.lSearch = new System.Windows.Forms.Label();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNummer = new System.Windows.Forms.Label();
            this.lbGeschlecht = new System.Windows.Forms.Label();
            this.lbGeburtsdatum = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbVorname = new System.Windows.Forms.Label();
            this.lbAnkunft = new System.Windows.Forms.Label();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.picBoxPatient = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxMedicalTeam = new System.Windows.Forms.PictureBox();
            this.NewPatient = new System.Windows.Forms.TabPage();
            this.lbKrankheit = new System.Windows.Forms.Label();
            this.tboxPKrankheit = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPGebDatum = new System.Windows.Forms.Label();
            this.lbPNachname = new System.Windows.Forms.Label();
            this.lbPVorname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelpNum = new System.Windows.Forms.Label();
            this.tboxPEmail = new System.Windows.Forms.TextBox();
            this.tboxPNumber = new System.Windows.Forms.TextBox();
            this.btnPSpeichern = new System.Windows.Forms.Button();
            this.rWeiblich = new System.Windows.Forms.RadioButton();
            this.rMänlich = new System.Windows.Forms.RadioButton();
            this.gebDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.tboxPNachname = new System.Windows.Forms.TextBox();
            this.tboxPVorname = new System.Windows.Forms.TextBox();
            this.pShadow1 = new System.Windows.Forms.Panel();
            this.pShadow2 = new System.Windows.Forms.Panel();
            this.pShadow3 = new System.Windows.Forms.Panel();
            this.pShadow4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBoxNeuPatient = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.ListOfPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMedicalTeam)).BeginInit();
            this.NewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNeuPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.ListOfPatient);
            this.Tab.Controls.Add(this.NewPatient);
            this.Tab.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Margin = new System.Windows.Forms.Padding(2);
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1094, 633);
            this.Tab.TabIndex = 0;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            this.Tab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tab_KeyDown);
            // 
            // ListOfPatient
            // 
            this.ListOfPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ListOfPatient.Controls.Add(this.panel1);
            this.ListOfPatient.Controls.Add(this.lSearch);
            this.ListOfPatient.Controls.Add(this.panelLabel);
            this.ListOfPatient.Controls.Add(this.tSearch);
            this.ListOfPatient.Controls.Add(this.picBoxPatient);
            this.ListOfPatient.Controls.Add(this.btnPrevious);
            this.ListOfPatient.Controls.Add(this.btnNext);
            this.ListOfPatient.Controls.Add(this.panelShadow);
            this.ListOfPatient.Controls.Add(this.panel2);
            this.ListOfPatient.Controls.Add(this.picBoxMedicalTeam);
            this.ListOfPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ListOfPatient.Location = new System.Drawing.Point(4, 36);
            this.ListOfPatient.Margin = new System.Windows.Forms.Padding(2);
            this.ListOfPatient.Name = "ListOfPatient";
            this.ListOfPatient.Padding = new System.Windows.Forms.Padding(2);
            this.ListOfPatient.Size = new System.Drawing.Size(1086, 593);
            this.ListOfPatient.TabIndex = 0;
            this.ListOfPatient.Text = "Patient";
            this.ListOfPatient.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tboxKrankheit);
            this.panel1.Controls.Add(this.tboxEmail);
            this.panel1.Controls.Add(this.tboxNummer);
            this.panel1.Controls.Add(this.tboxAngemeldet);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tboxGeschlecht);
            this.panel1.Controls.Add(this.tboxGDatum);
            this.panel1.Controls.Add(this.tboxName);
            this.panel1.Controls.Add(this.tboxVorname);
            this.panel1.Location = new System.Drawing.Point(261, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 454);
            this.panel1.TabIndex = 65;
            // 
            // tboxKrankheit
            // 
            this.tboxKrankheit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxKrankheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxKrankheit.Location = new System.Drawing.Point(12, 355);
            this.tboxKrankheit.Name = "tboxKrankheit";
            this.tboxKrankheit.Size = new System.Drawing.Size(279, 28);
            this.tboxKrankheit.TabIndex = 60;
            // 
            // tboxEmail
            // 
            this.tboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(12, 260);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(279, 28);
            this.tboxEmail.TabIndex = 59;
            // 
            // tboxNummer
            // 
            this.tboxNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNummer.Location = new System.Drawing.Point(12, 213);
            this.tboxNummer.Name = "tboxNummer";
            this.tboxNummer.Size = new System.Drawing.Size(279, 28);
            this.tboxNummer.TabIndex = 58;
            // 
            // tboxAngemeldet
            // 
            this.tboxAngemeldet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxAngemeldet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAngemeldet.Location = new System.Drawing.Point(12, 306);
            this.tboxAngemeldet.Name = "tboxAngemeldet";
            this.tboxAngemeldet.Size = new System.Drawing.Size(279, 28);
            this.tboxAngemeldet.TabIndex = 54;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowDrop = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(132, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 46);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseDown);
            this.btnUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseUp);
            // 
            // tboxGeschlecht
            // 
            this.tboxGeschlecht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGeschlecht.Location = new System.Drawing.Point(12, 164);
            this.tboxGeschlecht.Name = "tboxGeschlecht";
            this.tboxGeschlecht.Size = new System.Drawing.Size(279, 28);
            this.tboxGeschlecht.TabIndex = 53;
            // 
            // tboxGDatum
            // 
            this.tboxGDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxGDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGDatum.Location = new System.Drawing.Point(12, 114);
            this.tboxGDatum.Name = "tboxGDatum";
            this.tboxGDatum.Size = new System.Drawing.Size(279, 28);
            this.tboxGDatum.TabIndex = 52;
            // 
            // tboxName
            // 
            this.tboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(12, 70);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(279, 28);
            this.tboxName.TabIndex = 51;
            // 
            // tboxVorname
            // 
            this.tboxVorname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxVorname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVorname.Location = new System.Drawing.Point(12, 25);
            this.tboxVorname.Name = "tboxVorname";
            this.tboxVorname.Size = new System.Drawing.Size(279, 28);
            this.tboxVorname.TabIndex = 50;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.BackColor = System.Drawing.Color.Transparent;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.ForeColor = System.Drawing.Color.Teal;
            this.lSearch.Location = new System.Drawing.Point(641, 18);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(162, 26);
            this.lSearch.TabIndex = 61;
            this.lSearch.Text = "Patientensuche";
            // 
            // panelLabel
            // 
            this.panelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLabel.Controls.Add(this.label2);
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.Controls.Add(this.lbNummer);
            this.panelLabel.Controls.Add(this.lbGeschlecht);
            this.panelLabel.Controls.Add(this.lbGeburtsdatum);
            this.panelLabel.Controls.Add(this.lbName);
            this.panelLabel.Controls.Add(this.lbVorname);
            this.panelLabel.Controls.Add(this.lbAnkunft);
            this.panelLabel.Location = new System.Drawing.Point(55, 15);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(207, 454);
            this.panelLabel.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(100, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "Krankheit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(136, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email";
            // 
            // lbNummer
            // 
            this.lbNummer.AutoSize = true;
            this.lbNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNummer.ForeColor = System.Drawing.Color.Teal;
            this.lbNummer.Location = new System.Drawing.Point(66, 213);
            this.lbNummer.Name = "lbNummer";
            this.lbNummer.Size = new System.Drawing.Size(138, 26);
            this.lbNummer.TabIndex = 56;
            this.lbNummer.Text = "Tel. Nummer";
            // 
            // lbGeschlecht
            // 
            this.lbGeschlecht.AutoSize = true;
            this.lbGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeschlecht.ForeColor = System.Drawing.Color.Teal;
            this.lbGeschlecht.Location = new System.Drawing.Point(83, 164);
            this.lbGeschlecht.Name = "lbGeschlecht";
            this.lbGeschlecht.Size = new System.Drawing.Size(121, 26);
            this.lbGeschlecht.TabIndex = 48;
            this.lbGeschlecht.Text = "Geschlecht";
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtsdatum.ForeColor = System.Drawing.Color.Teal;
            this.lbGeburtsdatum.Location = new System.Drawing.Point(54, 114);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(150, 26);
            this.lbGeburtsdatum.TabIndex = 47;
            this.lbGeburtsdatum.Text = "Geburtsdatum";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Teal;
            this.lbName.Location = new System.Drawing.Point(86, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 26);
            this.lbName.TabIndex = 44;
            this.lbName.Text = "Nachname";
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorname.ForeColor = System.Drawing.Color.Teal;
            this.lbVorname.Location = new System.Drawing.Point(103, 25);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(101, 26);
            this.lbVorname.TabIndex = 43;
            this.lbVorname.Text = "Vorname";
            // 
            // lbAnkunft
            // 
            this.lbAnkunft.AutoSize = true;
            this.lbAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnkunft.ForeColor = System.Drawing.Color.Teal;
            this.lbAnkunft.Location = new System.Drawing.Point(38, 306);
            this.lbAnkunft.Name = "lbAnkunft";
            this.lbAnkunft.Size = new System.Drawing.Size(166, 26);
            this.lbAnkunft.TabIndex = 49;
            this.lbAnkunft.Text = "Angemeldet am";
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearch.Location = new System.Drawing.Point(809, 15);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(239, 32);
            this.tSearch.TabIndex = 60;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // picBoxPatient
            // 
            this.picBoxPatient.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxPatient.BackgroundImage")));
            this.picBoxPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxPatient.Location = new System.Drawing.Point(591, 164);
            this.picBoxPatient.Name = "picBoxPatient";
            this.picBoxPatient.Size = new System.Drawing.Size(477, 459);
            this.picBoxPatient.TabIndex = 62;
            this.picBoxPatient.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrevious.Location = new System.Drawing.Point(12, 27);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(37, 46);
            this.btnPrevious.TabIndex = 46;
            this.btnPrevious.Text = "🡄";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrevious_MouseDown);
            this.btnPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPrevious_MouseUp);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Location = new System.Drawing.Point(569, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 46);
            this.btnNext.TabIndex = 45;
            this.btnNext.Text = "🡆 ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseDown);
            this.btnNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseUp);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Gainsboro;
            this.panelShadow.Location = new System.Drawing.Point(59, 21);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(508, 453);
            this.panelShadow.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(815, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 33);
            this.panel2.TabIndex = 67;
            // 
            // picBoxMedicalTeam
            // 
            this.picBoxMedicalTeam.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMedicalTeam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxMedicalTeam.BackgroundImage")));
            this.picBoxMedicalTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxMedicalTeam.Location = new System.Drawing.Point(-15, 455);
            this.picBoxMedicalTeam.Name = "picBoxMedicalTeam";
            this.picBoxMedicalTeam.Size = new System.Drawing.Size(326, 141);
            this.picBoxMedicalTeam.TabIndex = 63;
            this.picBoxMedicalTeam.TabStop = false;
            // 
            // NewPatient
            // 
            this.NewPatient.Controls.Add(this.lbKrankheit);
            this.NewPatient.Controls.Add(this.tboxPKrankheit);
            this.NewPatient.Controls.Add(this.panel4);
            this.NewPatient.Controls.Add(this.lbPGebDatum);
            this.NewPatient.Controls.Add(this.lbPNachname);
            this.NewPatient.Controls.Add(this.lbPVorname);
            this.NewPatient.Controls.Add(this.lbEmail);
            this.NewPatient.Controls.Add(this.lbTelpNum);
            this.NewPatient.Controls.Add(this.tboxPEmail);
            this.NewPatient.Controls.Add(this.tboxPNumber);
            this.NewPatient.Controls.Add(this.btnPSpeichern);
            this.NewPatient.Controls.Add(this.rWeiblich);
            this.NewPatient.Controls.Add(this.rMänlich);
            this.NewPatient.Controls.Add(this.gebDatumPicker);
            this.NewPatient.Controls.Add(this.tboxPNachname);
            this.NewPatient.Controls.Add(this.tboxPVorname);
            this.NewPatient.Controls.Add(this.pShadow1);
            this.NewPatient.Controls.Add(this.pShadow2);
            this.NewPatient.Controls.Add(this.pShadow3);
            this.NewPatient.Controls.Add(this.pShadow4);
            this.NewPatient.Controls.Add(this.panel3);
            this.NewPatient.Controls.Add(this.picBoxNeuPatient);
            this.NewPatient.Location = new System.Drawing.Point(4, 36);
            this.NewPatient.Margin = new System.Windows.Forms.Padding(2);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Padding = new System.Windows.Forms.Padding(2);
            this.NewPatient.Size = new System.Drawing.Size(1086, 593);
            this.NewPatient.TabIndex = 1;
            this.NewPatient.Text = "Neu Patient ";
            this.NewPatient.UseVisualStyleBackColor = true;
            // 
            // lbKrankheit
            // 
            this.lbKrankheit.AutoSize = true;
            this.lbKrankheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKrankheit.ForeColor = System.Drawing.Color.Teal;
            this.lbKrankheit.Location = new System.Drawing.Point(67, 362);
            this.lbKrankheit.Name = "lbKrankheit";
            this.lbKrankheit.Size = new System.Drawing.Size(88, 24);
            this.lbKrankheit.TabIndex = 80;
            this.lbKrankheit.Text = "Krankheit";
            // 
            // tboxPKrankheit
            // 
            this.tboxPKrankheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPKrankheit.Location = new System.Drawing.Point(59, 380);
            this.tboxPKrankheit.Multiline = true;
            this.tboxPKrankheit.Name = "tboxPKrankheit";
            this.tboxPKrankheit.Size = new System.Drawing.Size(398, 85);
            this.tboxPKrankheit.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(64, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 86);
            this.panel4.TabIndex = 79;
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.ForeColor = System.Drawing.Color.Teal;
            this.lbPGebDatum.Location = new System.Drawing.Point(67, 148);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(128, 24);
            this.lbPGebDatum.TabIndex = 60;
            this.lbPGebDatum.Text = "Geburtsdatum";
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.ForeColor = System.Drawing.Color.Teal;
            this.lbPNachname.Location = new System.Drawing.Point(67, 74);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(103, 24);
            this.lbPNachname.TabIndex = 56;
            this.lbPNachname.Text = "Nachname";
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.ForeColor = System.Drawing.Color.Teal;
            this.lbPVorname.Location = new System.Drawing.Point(67, 6);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(88, 24);
            this.lbPVorname.TabIndex = 55;
            this.lbPVorname.Text = "Vorname";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Teal;
            this.lbEmail.Location = new System.Drawing.Point(67, 294);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 24);
            this.lbEmail.TabIndex = 68;
            this.lbEmail.Text = "Email";
            // 
            // lbTelpNum
            // 
            this.lbTelpNum.AutoSize = true;
            this.lbTelpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelpNum.ForeColor = System.Drawing.Color.Teal;
            this.lbTelpNum.Location = new System.Drawing.Point(67, 220);
            this.lbTelpNum.Name = "lbTelpNum";
            this.lbTelpNum.Size = new System.Drawing.Size(121, 24);
            this.lbTelpNum.TabIndex = 67;
            this.lbTelpNum.Text = "Tel. Nummer";
            // 
            // tboxPEmail
            // 
            this.tboxPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPEmail.Location = new System.Drawing.Point(59, 311);
            this.tboxPEmail.Name = "tboxPEmail";
            this.tboxPEmail.Size = new System.Drawing.Size(398, 35);
            this.tboxPEmail.TabIndex = 66;
            // 
            // tboxPNumber
            // 
            this.tboxPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNumber.Location = new System.Drawing.Point(59, 238);
            this.tboxPNumber.Name = "tboxPNumber";
            this.tboxPNumber.Size = new System.Drawing.Size(398, 35);
            this.tboxPNumber.TabIndex = 65;
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.BackColor = System.Drawing.Color.Transparent;
            this.btnPSpeichern.FlatAppearance.BorderSize = 0;
            this.btnPSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichern.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPSpeichern.Location = new System.Drawing.Point(161, 521);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(171, 46);
            this.btnPSpeichern.TabIndex = 64;
            this.btnPSpeichern.Text = "SPEICHERN";
            this.btnPSpeichern.UseVisualStyleBackColor = false;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            this.btnPSpeichern.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPSpeichern_MouseDown);
            this.btnPSpeichern.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPSpeichern_MouseUp);
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.ForeColor = System.Drawing.Color.Fuchsia;
            this.rWeiblich.Location = new System.Drawing.Point(280, 486);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(121, 33);
            this.rWeiblich.TabIndex = 63;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rMänlich.Location = new System.Drawing.Point(125, 486);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(113, 33);
            this.rMänlich.TabIndex = 62;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(59, 166);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(398, 35);
            this.gebDatumPicker.TabIndex = 61;
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(59, 92);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(398, 35);
            this.tboxPNachname.TabIndex = 59;
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(59, 23);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(398, 35);
            this.tboxPVorname.TabIndex = 58;
            // 
            // pShadow1
            // 
            this.pShadow1.BackColor = System.Drawing.Color.Gainsboro;
            this.pShadow1.Location = new System.Drawing.Point(64, 28);
            this.pShadow1.Name = "pShadow1";
            this.pShadow1.Size = new System.Drawing.Size(396, 33);
            this.pShadow1.TabIndex = 71;
            // 
            // pShadow2
            // 
            this.pShadow2.BackColor = System.Drawing.Color.Gainsboro;
            this.pShadow2.Location = new System.Drawing.Point(64, 97);
            this.pShadow2.Name = "pShadow2";
            this.pShadow2.Size = new System.Drawing.Size(396, 34);
            this.pShadow2.TabIndex = 72;
            // 
            // pShadow3
            // 
            this.pShadow3.BackColor = System.Drawing.Color.Gainsboro;
            this.pShadow3.Location = new System.Drawing.Point(64, 171);
            this.pShadow3.Name = "pShadow3";
            this.pShadow3.Size = new System.Drawing.Size(396, 34);
            this.pShadow3.TabIndex = 73;
            // 
            // pShadow4
            // 
            this.pShadow4.BackColor = System.Drawing.Color.Gainsboro;
            this.pShadow4.Location = new System.Drawing.Point(64, 243);
            this.pShadow4.Name = "pShadow4";
            this.pShadow4.Size = new System.Drawing.Size(396, 34);
            this.pShadow4.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(64, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 34);
            this.panel3.TabIndex = 75;
            // 
            // picBoxNeuPatient
            // 
            this.picBoxNeuPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxNeuPatient.BackgroundImage")));
            this.picBoxNeuPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxNeuPatient.Location = new System.Drawing.Point(520, 37);
            this.picBoxNeuPatient.Name = "picBoxNeuPatient";
            this.picBoxNeuPatient.Size = new System.Drawing.Size(554, 535);
            this.picBoxNeuPatient.TabIndex = 69;
            this.picBoxNeuPatient.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowDrop = true;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(995, -12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 41);
            this.btnLogout.TabIndex = 64;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1094, 633);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATIENT VERWALTUNG";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TabForm_MouseMove);
            this.Tab.ResumeLayout(false);
            this.ListOfPatient.ResumeLayout(false);
            this.ListOfPatient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMedicalTeam)).EndInit();
            this.NewPatient.ResumeLayout(false);
            this.NewPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNeuPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage ListOfPatient;
        private System.Windows.Forms.TabPage NewPatient;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelpNum;
        private System.Windows.Forms.TextBox tboxPEmail;
        private System.Windows.Forms.TextBox tboxPNumber;
        private System.Windows.Forms.Button btnPSpeichern;
        private System.Windows.Forms.RadioButton rWeiblich;
        private System.Windows.Forms.RadioButton rMänlich;
        private System.Windows.Forms.DateTimePicker gebDatumPicker;
        private System.Windows.Forms.Label lbPGebDatum;
        private System.Windows.Forms.TextBox tboxPNachname;
        private System.Windows.Forms.TextBox tboxPVorname;
        private System.Windows.Forms.Label lbPNachname;
        private System.Windows.Forms.Label lbPVorname;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.PictureBox picBoxPatient;
        private System.Windows.Forms.PictureBox picBoxNeuPatient;
        private System.Windows.Forms.PictureBox picBoxMedicalTeam;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxNummer;
        private System.Windows.Forms.TextBox tboxAngemeldet;
        private System.Windows.Forms.TextBox tboxGeschlecht;
        private System.Windows.Forms.TextBox tboxGDatum;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxVorname;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNummer;
        private System.Windows.Forms.Label lbGeschlecht;
        private System.Windows.Forms.Label lbGeburtsdatum;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbVorname;
        private System.Windows.Forms.Label lbAnkunft;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel pShadow1;
        private System.Windows.Forms.Panel pShadow2;
        private System.Windows.Forms.Panel pShadow3;
        private System.Windows.Forms.Panel pShadow4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbKrankheit;
        private System.Windows.Forms.TextBox tboxPKrankheit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tboxKrankheit;
        private System.Windows.Forms.Label label2;
    }
}