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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tab.SuspendLayout();
            this.ListOfPatient.SuspendLayout();
            this.NewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.ListOfPatient);
            this.Tab.Controls.Add(this.NewPatient);
            this.Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.Location = new System.Drawing.Point(15, 12);
            this.Tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1429, 753);
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
            this.ListOfPatient.Controls.Add(this.pictureBox1);
            this.ListOfPatient.Location = new System.Drawing.Point(4, 40);
            this.ListOfPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListOfPatient.Name = "ListOfPatient";
            this.ListOfPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListOfPatient.Size = new System.Drawing.Size(1421, 709);
            this.ListOfPatient.TabIndex = 0;
            this.ListOfPatient.Text = "Patient";
            this.ListOfPatient.UseVisualStyleBackColor = true;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.BackColor = System.Drawing.Color.Transparent;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(855, 22);
            this.lSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(202, 31);
            this.lSearch.TabIndex = 61;
            this.lSearch.Text = "Patientensuche";
            // 
            // tSearch
            // 
            this.tSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearch.Location = new System.Drawing.Point(1079, 18);
            this.tSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(317, 38);
            this.tSearch.TabIndex = 60;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(251, 389);
            this.tboxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(529, 41);
            this.tboxEmail.TabIndex = 59;
            // 
            // tboxNummer
            // 
            this.tboxNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNummer.Location = new System.Drawing.Point(251, 331);
            this.tboxNummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNummer.Name = "tboxNummer";
            this.tboxNummer.Size = new System.Drawing.Size(529, 41);
            this.tboxNummer.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email";
            // 
            // lbNummer
            // 
            this.lbNummer.AutoSize = true;
            this.lbNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNummer.Location = new System.Drawing.Point(57, 335);
            this.lbNummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNummer.Name = "lbNummer";
            this.lbNummer.Size = new System.Drawing.Size(170, 31);
            this.lbNummer.TabIndex = 56;
            this.lbNummer.Text = "Tel. Nummer";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowDrop = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(553, 517);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 57);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tboxAngemeldet
            // 
            this.tboxAngemeldet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAngemeldet.Location = new System.Drawing.Point(251, 446);
            this.tboxAngemeldet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxAngemeldet.Name = "tboxAngemeldet";
            this.tboxAngemeldet.Size = new System.Drawing.Size(529, 41);
            this.tboxAngemeldet.TabIndex = 54;
            // 
            // tboxGeschlecht
            // 
            this.tboxGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGeschlecht.Location = new System.Drawing.Point(251, 271);
            this.tboxGeschlecht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxGeschlecht.Name = "tboxGeschlecht";
            this.tboxGeschlecht.Size = new System.Drawing.Size(529, 41);
            this.tboxGeschlecht.TabIndex = 53;
            // 
            // tboxGDatum
            // 
            this.tboxGDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGDatum.Location = new System.Drawing.Point(251, 209);
            this.tboxGDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxGDatum.Name = "tboxGDatum";
            this.tboxGDatum.Size = new System.Drawing.Size(529, 41);
            this.tboxGDatum.TabIndex = 52;
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(251, 155);
            this.tboxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(529, 41);
            this.tboxName.TabIndex = 51;
            // 
            // tboxVorname
            // 
            this.tboxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVorname.Location = new System.Drawing.Point(251, 100);
            this.tboxVorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxVorname.Name = "tboxVorname";
            this.tboxVorname.Size = new System.Drawing.Size(529, 41);
            this.tboxVorname.TabIndex = 50;
            // 
            // lbAnkunft
            // 
            this.lbAnkunft.AutoSize = true;
            this.lbAnkunft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnkunft.Location = new System.Drawing.Point(22, 452);
            this.lbAnkunft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnkunft.Name = "lbAnkunft";
            this.lbAnkunft.Size = new System.Drawing.Size(202, 31);
            this.lbAnkunft.TabIndex = 49;
            this.lbAnkunft.Text = "Angemeldet am";
            // 
            // lbGeschlecht
            // 
            this.lbGeschlecht.AutoSize = true;
            this.lbGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeschlecht.Location = new System.Drawing.Point(76, 277);
            this.lbGeschlecht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeschlecht.Name = "lbGeschlecht";
            this.lbGeschlecht.Size = new System.Drawing.Size(151, 31);
            this.lbGeschlecht.TabIndex = 48;
            this.lbGeschlecht.Text = "Geschlecht";
            // 
            // lbGeburtsdatum
            // 
            this.lbGeburtsdatum.AutoSize = true;
            this.lbGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtsdatum.Location = new System.Drawing.Point(41, 215);
            this.lbGeburtsdatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeburtsdatum.Name = "lbGeburtsdatum";
            this.lbGeburtsdatum.Size = new System.Drawing.Size(186, 31);
            this.lbGeburtsdatum.TabIndex = 47;
            this.lbGeburtsdatum.Text = "Geburtsdatum";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(317, 517);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 57);
            this.btnPrevious.TabIndex = 46;
            this.btnPrevious.Text = "🡄";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(411, 517);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 57);
            this.btnNext.TabIndex = 45;
            this.btnNext.Text = "🡆 ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(83, 160);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 31);
            this.lbName.TabIndex = 44;
            this.lbName.Text = "Nachname";
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorname.Location = new System.Drawing.Point(104, 106);
            this.lbVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(123, 31);
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
            this.NewPatient.Location = new System.Drawing.Point(4, 40);
            this.NewPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPatient.Size = new System.Drawing.Size(1421, 709);
            this.NewPatient.TabIndex = 1;
            this.NewPatient.Text = "Neu Patient ";
            this.NewPatient.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(147, 337);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(81, 31);
            this.lbEmail.TabIndex = 68;
            this.lbEmail.Text = "Email";
            // 
            // lbTelpNum
            // 
            this.lbTelpNum.AutoSize = true;
            this.lbTelpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelpNum.Location = new System.Drawing.Point(59, 277);
            this.lbTelpNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelpNum.Name = "lbTelpNum";
            this.lbTelpNum.Size = new System.Drawing.Size(170, 31);
            this.lbTelpNum.TabIndex = 67;
            this.lbTelpNum.Text = "Tel. Nummer";
            // 
            // tboxPEmail
            // 
            this.tboxPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPEmail.Location = new System.Drawing.Point(251, 331);
            this.tboxPEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPEmail.Name = "tboxPEmail";
            this.tboxPEmail.Size = new System.Drawing.Size(529, 41);
            this.tboxPEmail.TabIndex = 66;
            // 
            // tboxPNumber
            // 
            this.tboxPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNumber.Location = new System.Drawing.Point(251, 271);
            this.tboxPNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPNumber.Name = "tboxPNumber";
            this.tboxPNumber.Size = new System.Drawing.Size(529, 41);
            this.tboxPNumber.TabIndex = 65;
            // 
            // btnPSpeichern
            // 
            this.btnPSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSpeichern.Location = new System.Drawing.Point(423, 466);
            this.btnPSpeichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPSpeichern.Name = "btnPSpeichern";
            this.btnPSpeichern.Size = new System.Drawing.Size(168, 57);
            this.btnPSpeichern.TabIndex = 64;
            this.btnPSpeichern.Text = "Speichern";
            this.btnPSpeichern.UseVisualStyleBackColor = true;
            this.btnPSpeichern.Click += new System.EventHandler(this.btnPSpeichern_Click);
            // 
            // rWeiblich
            // 
            this.rWeiblich.AutoSize = true;
            this.rWeiblich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rWeiblich.Location = new System.Drawing.Point(552, 384);
            this.rWeiblich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rWeiblich.Name = "rWeiblich";
            this.rWeiblich.Size = new System.Drawing.Size(137, 35);
            this.rWeiblich.TabIndex = 63;
            this.rWeiblich.TabStop = true;
            this.rWeiblich.Text = "Weiblich";
            this.rWeiblich.UseVisualStyleBackColor = true;
            // 
            // rMänlich
            // 
            this.rMänlich.AutoSize = true;
            this.rMänlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMänlich.Location = new System.Drawing.Point(345, 384);
            this.rMänlich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rMänlich.Name = "rMänlich";
            this.rMänlich.Size = new System.Drawing.Size(128, 35);
            this.rMänlich.TabIndex = 62;
            this.rMänlich.TabStop = true;
            this.rMänlich.Text = "Mänlich";
            this.rMänlich.UseVisualStyleBackColor = true;
            // 
            // gebDatumPicker
            // 
            this.gebDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebDatumPicker.Location = new System.Drawing.Point(251, 210);
            this.gebDatumPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gebDatumPicker.Name = "gebDatumPicker";
            this.gebDatumPicker.Size = new System.Drawing.Size(529, 41);
            this.gebDatumPicker.TabIndex = 61;
            // 
            // lbPGebDatum
            // 
            this.lbPGebDatum.AutoSize = true;
            this.lbPGebDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPGebDatum.Location = new System.Drawing.Point(43, 217);
            this.lbPGebDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPGebDatum.Name = "lbPGebDatum";
            this.lbPGebDatum.Size = new System.Drawing.Size(186, 31);
            this.lbPGebDatum.TabIndex = 60;
            this.lbPGebDatum.Text = "Geburtsdatum";
            // 
            // tboxPNachname
            // 
            this.tboxPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPNachname.Location = new System.Drawing.Point(251, 155);
            this.tboxPNachname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPNachname.Name = "tboxPNachname";
            this.tboxPNachname.Size = new System.Drawing.Size(529, 41);
            this.tboxPNachname.TabIndex = 59;
            // 
            // tboxPVorname
            // 
            this.tboxPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPVorname.Location = new System.Drawing.Point(251, 100);
            this.tboxPVorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPVorname.Name = "tboxPVorname";
            this.tboxPVorname.Size = new System.Drawing.Size(529, 41);
            this.tboxPVorname.TabIndex = 58;
            // 
            // lbPNachname
            // 
            this.lbPNachname.AutoSize = true;
            this.lbPNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNachname.Location = new System.Drawing.Point(83, 161);
            this.lbPNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPNachname.Name = "lbPNachname";
            this.lbPNachname.Size = new System.Drawing.Size(145, 31);
            this.lbPNachname.TabIndex = 56;
            this.lbPNachname.Text = "Nachname";
            // 
            // lbPVorname
            // 
            this.lbPVorname.AutoSize = true;
            this.lbPVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVorname.Location = new System.Drawing.Point(105, 106);
            this.lbPVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPVorname.Name = "lbPVorname";
            this.lbPVorname.Size = new System.Drawing.Size(123, 31);
            this.lbPVorname.TabIndex = 55;
            this.lbPVorname.Text = "Vorname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1408, 698);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 779);
            this.Controls.Add(this.Tab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Tab.ResumeLayout(false);
            this.ListOfPatient.ResumeLayout(false);
            this.ListOfPatient.PerformLayout();
            this.NewPatient.ResumeLayout(false);
            this.NewPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}