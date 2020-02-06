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
            this.Tab = new System.Windows.Forms.TabControl();
            this.ListOfPatient = new System.Windows.Forms.TabPage();
            this.lSearch = new System.Windows.Forms.Label();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxNummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNummer = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tboxAngemeldet = new System.Windows.Forms.TextBox();
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
            this.NewPatient = new System.Windows.Forms.TabPage();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelpNum = new System.Windows.Forms.Label();
            this.tboxPEmail = new System.Windows.Forms.TextBox();
            this.tboxPNumber = new System.Windows.Forms.TextBox();
            this.btnPSpeichern = new System.Windows.Forms.Button();
            this.rWeiblich = new System.Windows.Forms.RadioButton();
            this.rMänlich = new System.Windows.Forms.RadioButton();
            this.gebDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.lbPGebDatum = new System.Windows.Forms.Label();
            this.tboxPNachname = new System.Windows.Forms.TextBox();
            this.tboxPVorname = new System.Windows.Forms.TextBox();
            this.lbPNachname = new System.Windows.Forms.Label();
            this.lbPVorname = new System.Windows.Forms.Label();
            this.picBoxMedicalTeam = new System.Windows.Forms.PictureBox();
            this.picBoxPatient = new System.Windows.Forms.PictureBox();
            this.picBoxNeuPatient = new System.Windows.Forms.PictureBox();
            this.Tab.SuspendLayout();
            this.ListOfPatient.SuspendLayout();
            this.NewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMedicalTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNeuPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.ListOfPatient);
            this.Tab.Controls.Add(this.NewPatient);
            this.Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.Location = new System.Drawing.Point(11, 10);
            this.Tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1072, 612);
            this.Tab.TabIndex = 0;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            this.Tab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tab_KeyDown);
            // 
            // ListOfPatient
            // 
            this.ListOfPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ListOfPatient.Controls.Add(this.lSearch);
            this.ListOfPatient.Controls.Add(this.tSearch);
            this.ListOfPatient.Controls.Add(this.tboxEmail);
            this.ListOfPatient.Controls.Add(this.tboxNummer);
            this.ListOfPatient.Controls.Add(this.label1);
            this.ListOfPatient.Controls.Add(this.lbNummer);
            this.ListOfPatient.Controls.Add(this.btnUpdate);
            this.ListOfPatient.Controls.Add(this.tboxAngemeldet);
            this.ListOfPatient.Controls.Add(this.tboxGeschlecht);
            this.ListOfPatient.Controls.Add(this.tboxGDatum);
            this.ListOfPatient.Controls.Add(this.tboxName);
            this.ListOfPatient.Controls.Add(this.tboxVorname);
            this.ListOfPatient.Controls.Add(this.lbAnkunft);
            this.ListOfPatient.Controls.Add(this.lbGeschlecht);
            this.ListOfPatient.Controls.Add(this.lbGeburtsdatum);
            this.ListOfPatient.Controls.Add(this.btnPrevious);
            this.ListOfPatient.Controls.Add(this.btnNext);
            this.ListOfPatient.Controls.Add(this.lbName);
            this.ListOfPatient.Controls.Add(this.lbVorname);
            this.ListOfPatient.Controls.Add(this.picBoxMedicalTeam);
            this.ListOfPatient.Controls.Add(this.picBoxPatient);
            this.ListOfPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ListOfPatient.Location = new System.Drawing.Point(4, 34);
            this.ListOfPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListOfPatient.Name = "ListOfPatient";
            this.ListOfPatient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListOfPatient.Size = new System.Drawing.Size(1064, 574);
            this.ListOfPatient.TabIndex = 0;
            this.ListOfPatient.Text = "Patient";
            this.ListOfPatient.UseVisualStyleBackColor = true;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.BackColor = System.Drawing.Color.Transparent;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(641, 18);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(162, 26);
            this.lSearch.TabIndex = 61;
            this.lSearch.Text = "Patientensuche";
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
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(188, 316);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(398, 35);
            this.tboxEmail.TabIndex = 59;
            // 
            // tboxNummer
            // 
            this.tboxNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNummer.Location = new System.Drawing.Point(188, 269);
            this.tboxNummer.Name = "tboxNummer";
            this.tboxNummer.Size = new System.Drawing.Size(398, 35);
            this.tboxNummer.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email";
            // 
            // lbNummer
            // 
            this.lbNummer.AutoSize = true;
            this.lbNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNummer.Location = new System.Drawing.Point(43, 272);
            this.lbNummer.Name = "lbNummer";
            this.lbNummer.Size = new System.Drawing.Size(138, 26);
            this.lbNummer.TabIndex = 56;
            this.lbNummer.Text = "Tel. Nummer";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowDrop = true;
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(415, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 46);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tboxAngemeldet
            // 
            this.tboxAngemeldet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAngemeldet.Location = new System.Drawing.Point(188, 362);
            this.tboxAngemeldet.Name = "tboxAngemeldet";
            this.tboxAngemeldet.Size = new System.Drawing.Size(398, 35);
            this.tboxAngemeldet.TabIndex = 54;
            // 
            // tboxGeschlecht
            // 
            this.tboxGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGeschlecht.Location = new System.Drawing.Point(188, 220);
            this.tboxGeschlecht.Name = "tboxGeschlecht";
            this.tboxGeschlecht.Size = new System.Drawing.Size(398, 35);
            this.tboxGeschlecht.TabIndex = 53;
            // 
            // tboxGDatum
            // 
            this.tboxGDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGDatum.Location = new System.Drawing.Point(188, 170);
            this.tboxGDatum.Name = "tboxGDatum";
            this.tboxGDatum.Size = new System.Drawing.Size(398, 35);
            this.tboxGDatum.TabIndex = 52;
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(188, 126);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(398, 35);
            this.tboxName.TabIndex = 51;
            // 
            // tboxVorname
            // 
            this.tboxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVorname.Location = new System.Drawing.Point(188, 81);
            this.tboxVorname.Name = "tboxVorname";
            this.tboxVorname.Size = new System.Drawing.Size(398, 35);
            this.tboxVorname.TabIndex = 50;
            // 
            // lbAnkunft
            // 
            this.lbAnkunft.AutoSize = true;
            this.lbAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnkunft.Location = new System.Drawing.Point(16, 367);
            this.lbAnkunft.Name = "lbAnkunft";
            this.lbAnkunft.Size = new System.Drawing.Size(166, 26);
            this.lbAnkunft.TabIndex = 49;
            this.lbAnkunft.Text = "Angemeldet am";
            // 
            // lbGeschlecht
            // 
            this.lbGeschlecht.AutoSize = true;
            this.lbGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeschlecht.Location = new System.Drawing.Point(57, 225);
            this.lbGeschlecht.Name = "lbGeschlecht";
            this.lbGeschlecht.Size = new System.Drawing.Size(121, 26);
            this.lbGeschlecht.TabIndex = 48;
            this.lbGeschlecht.Text = "Geschlecht";
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtsdatum.Location = new System.Drawing.Point(31, 175);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(150, 26);
            this.lbGeburtsdatum.TabIndex = 47;
            this.lbGeburtsdatum.Text = "Geburtsdatum";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(188, 420);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 46);
            this.btnPrevious.TabIndex = 46;
            this.btnPrevious.Text = "🡄";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(285, 420);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 46);
            this.btnNext.TabIndex = 45;
            this.btnNext.Text = "🡆 ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(62, 130);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 26);
            this.lbName.TabIndex = 44;
            this.lbName.Text = "Nachname";
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorname.Location = new System.Drawing.Point(78, 86);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(101, 26);
            this.lbVorname.TabIndex = 43;
            this.lbVorname.Text = "Vorname";
            // 
            // NewPatient
            // 
            this.NewPatient.Controls.Add(this.lbEmail);
            this.NewPatient.Controls.Add(this.lbTelpNum);
            this.NewPatient.Controls.Add(this.tboxPEmail);
            this.NewPatient.Controls.Add(this.tboxPNumber);
            this.NewPatient.Controls.Add(this.btnPSpeichern);
            this.NewPatient.Controls.Add(this.rWeiblich);
            this.NewPatient.Controls.Add(this.rMänlich);
            this.NewPatient.Controls.Add(this.gebDatumPicker);
            this.NewPatient.Controls.Add(this.lbPGebDatum);
            this.NewPatient.Controls.Add(this.tboxPNachname);
            this.NewPatient.Controls.Add(this.tboxPVorname);
            this.NewPatient.Controls.Add(this.lbPNachname);
            this.NewPatient.Controls.Add(this.lbPVorname);
            this.NewPatient.Controls.Add(this.picBoxNeuPatient);
            this.NewPatient.Location = new System.Drawing.Point(4, 34);
            this.NewPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewPatient.Size = new System.Drawing.Size(1064, 574);
            this.NewPatient.TabIndex = 1;
            this.NewPatient.Text = "Neu Patient ";
            this.NewPatient.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(110, 274);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(68, 26);
            this.lbEmail.TabIndex = 68;
            this.lbEmail.Text = "Email";
            // 
            // lbTelpNum
            // 
            this.lbTelpNum.AutoSize = true;
            this.lbTelpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelpNum.Location = new System.Drawing.Point(44, 225);
            this.lbTelpNum.Name = "lbTelpNum";
            this.lbTelpNum.Size = new System.Drawing.Size(138, 26);
            this.lbTelpNum.TabIndex = 67;
            this.lbTelpNum.Text = "Tel. Nummer";
            // 
            // tboxPEmail
            // 
            this.tboxPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPEmail.Location = new System.Drawing.Point(188, 269);
            this.tboxPEmail.Name = "tboxPEmail";
            this.tboxPEmail.Size = new System.Drawing.Size(398, 35);
            this.tboxPEmail.TabIndex = 66;
            // 
            // tboxPNumber
            // 
            this.tboxPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNumber.Location = new System.Drawing.Point(188, 220);
            this.tboxPNumber.Name = "tboxPNumber";
            this.tboxPNumber.Size = new System.Drawing.Size(398, 35);
            this.tboxPNumber.TabIndex = 65;
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichern.ForeColor = System.Drawing.Color.White;
            this.btnPSpeichern.Location = new System.Drawing.Point(308, 372);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(171, 46);
            this.btnPSpeichern.TabIndex = 64;
            this.btnPSpeichern.Text = "SPEICHERN";
            this.btnPSpeichern.UseVisualStyleBackColor = false;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.Location = new System.Drawing.Point(414, 312);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(113, 30);
            this.rWeiblich.TabIndex = 63;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.Location = new System.Drawing.Point(259, 312);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(105, 30);
            this.rMänlich.TabIndex = 62;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(188, 171);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(398, 35);
            this.gebDatumPicker.TabIndex = 61;
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.Location = new System.Drawing.Point(32, 176);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(150, 26);
            this.lbPGebDatum.TabIndex = 60;
            this.lbPGebDatum.Text = "Geburtsdatum";
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(188, 126);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(398, 35);
            this.tboxPNachname.TabIndex = 59;
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(188, 81);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(398, 35);
            this.tboxPVorname.TabIndex = 58;
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.Location = new System.Drawing.Point(62, 131);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(118, 26);
            this.lbPNachname.TabIndex = 56;
            this.lbPNachname.Text = "Nachname";
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.Location = new System.Drawing.Point(79, 86);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(101, 26);
            this.lbPVorname.TabIndex = 55;
            this.lbPVorname.Text = "Vorname";
            // 
            // picBoxMedicalTeam
            // 
            this.picBoxMedicalTeam.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMedicalTeam.BackgroundImage = global::verwaltung.Properties.Resources.medicalTeam;
            this.picBoxMedicalTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxMedicalTeam.Location = new System.Drawing.Point(-10, 457);
            this.picBoxMedicalTeam.Name = "picBoxMedicalTeam";
            this.picBoxMedicalTeam.Size = new System.Drawing.Size(326, 141);
            this.picBoxMedicalTeam.TabIndex = 63;
            this.picBoxMedicalTeam.TabStop = false;
            // 
            // picBoxPatient
            // 
            this.picBoxPatient.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPatient.BackgroundImage = global::verwaltung.Properties.Resources.background;
            this.picBoxPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxPatient.Location = new System.Drawing.Point(298, 91);
            this.picBoxPatient.Name = "picBoxPatient";
            this.picBoxPatient.Size = new System.Drawing.Size(1056, 567);
            this.picBoxPatient.TabIndex = 62;
            this.picBoxPatient.TabStop = false;
            // 
            // picBoxNeuPatient
            // 
            this.picBoxNeuPatient.BackgroundImage = global::verwaltung.Properties.Resources.background2;
            this.picBoxNeuPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxNeuPatient.Location = new System.Drawing.Point(254, 5);
            this.picBoxNeuPatient.Name = "picBoxNeuPatient";
            this.picBoxNeuPatient.Size = new System.Drawing.Size(1054, 564);
            this.picBoxNeuPatient.TabIndex = 69;
            this.picBoxNeuPatient.TabStop = false;
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 633);
            this.Controls.Add(this.Tab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Tab.ResumeLayout(false);
            this.ListOfPatient.ResumeLayout(false);
            this.ListOfPatient.PerformLayout();
            this.NewPatient.ResumeLayout(false);
            this.NewPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMedicalTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPatient)).EndInit();
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
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNummer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tboxAngemeldet;
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
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.PictureBox picBoxPatient;
        private System.Windows.Forms.PictureBox picBoxNeuPatient;
        private System.Windows.Forms.PictureBox picBoxMedicalTeam;
    }
}