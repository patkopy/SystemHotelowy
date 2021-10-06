
namespace SystemHotelowy
{
    partial class PracownicyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPracownicy = new System.Windows.Forms.DataGridView();
            this.IdPracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pensja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanowisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataZatrudnienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdPracownika = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNrTel = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStanowisko = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPensja = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataZatrudnienia = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonSzukajPracownika = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPracownicy
            // 
            this.dataGridViewPracownicy.AllowUserToDeleteRows = false;
            this.dataGridViewPracownicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPracownicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPracownika,
            this.Imie,
            this.Nazwisko,
            this.Pesel,
            this.Miasto,
            this.Adres,
            this.NrTel,
            this.Email,
            this.Pensja,
            this.Stanowisko,
            this.DataZatrudnienia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPracownicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPracownicy.EnableHeadersVisualStyles = false;
            this.dataGridViewPracownicy.Location = new System.Drawing.Point(400, 140);
            this.dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            this.dataGridViewPracownicy.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPracownicy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPracownicy.RowTemplate.Height = 30;
            this.dataGridViewPracownicy.Size = new System.Drawing.Size(825, 504);
            this.dataGridViewPracownicy.TabIndex = 87;
            this.dataGridViewPracownicy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPracownicy_MouseDoubleClick);
            // 
            // IdPracownika
            // 
            this.IdPracownika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdPracownika.DataPropertyName = "IdPracownika";
            this.IdPracownika.HeaderText = "ID Pracownika";
            this.IdPracownika.Name = "IdPracownika";
            this.IdPracownika.ReadOnly = true;
            this.IdPracownika.Width = 121;
            // 
            // Imie
            // 
            this.Imie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Imie.DataPropertyName = "Imie";
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            this.Imie.Width = 62;
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nazwisko.DataPropertyName = "Nazwisko";
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            this.Nazwisko.Width = 99;
            // 
            // Pesel
            // 
            this.Pesel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pesel.DataPropertyName = "Pesel";
            this.Pesel.HeaderText = "Pesel";
            this.Pesel.Name = "Pesel";
            this.Pesel.ReadOnly = true;
            this.Pesel.Width = 73;
            // 
            // Miasto
            // 
            this.Miasto.DataPropertyName = "Miasto";
            this.Miasto.HeaderText = "Miasto";
            this.Miasto.Name = "Miasto";
            this.Miasto.ReadOnly = true;
            this.Miasto.Width = 79;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.Width = 74;
            // 
            // NrTel
            // 
            this.NrTel.DataPropertyName = "NrTel";
            this.NrTel.HeaderText = "Numer telefonu";
            this.NrTel.Name = "NrTel";
            this.NrTel.ReadOnly = true;
            this.NrTel.Width = 125;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Adres e-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 111;
            // 
            // Pensja
            // 
            this.Pensja.DataPropertyName = "Pensja";
            this.Pensja.HeaderText = "Pensja";
            this.Pensja.Name = "Pensja";
            this.Pensja.ReadOnly = true;
            this.Pensja.Width = 81;
            // 
            // Stanowisko
            // 
            this.Stanowisko.DataPropertyName = "Stanowisko";
            this.Stanowisko.HeaderText = "Stanowisko";
            this.Stanowisko.Name = "Stanowisko";
            this.Stanowisko.ReadOnly = true;
            this.Stanowisko.Width = 112;
            // 
            // DataZatrudnienia
            // 
            this.DataZatrudnienia.DataPropertyName = "DataZatrudnienia";
            this.DataZatrudnienia.HeaderText = "Data zatrudnienia";
            this.DataZatrudnienia.Name = "DataZatrudnienia";
            this.DataZatrudnienia.ReadOnly = true;
            this.DataZatrudnienia.Width = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(30, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Miasto:";
            // 
            // textBoxIdPracownika
            // 
            this.textBoxIdPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdPracownika.Location = new System.Drawing.Point(207, 142);
            this.textBoxIdPracownika.Multiline = true;
            this.textBoxIdPracownika.Name = "textBoxIdPracownika";
            this.textBoxIdPracownika.Size = new System.Drawing.Size(166, 30);
            this.textBoxIdPracownika.TabIndex = 86;
            this.textBoxIdPracownika.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(30, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "Identyfikator pracownika:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(207, 394);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(166, 30);
            this.textBoxEmail.TabIndex = 84;
            this.textBoxEmail.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(31, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 83;
            this.label7.Text = "Adres e-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(30, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "Numer telefonu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(31, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(30, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Nazwisko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Imię:";
            // 
            // textBoxNrTel
            // 
            this.textBoxNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNrTel.Location = new System.Drawing.Point(207, 358);
            this.textBoxNrTel.Multiline = true;
            this.textBoxNrTel.Name = "textBoxNrTel";
            this.textBoxNrTel.Size = new System.Drawing.Size(166, 30);
            this.textBoxNrTel.TabIndex = 77;
            this.textBoxNrTel.WordWrap = false;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxAdres.Location = new System.Drawing.Point(207, 322);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(166, 30);
            this.textBoxAdres.TabIndex = 76;
            this.textBoxAdres.WordWrap = false;
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxMiasto.Location = new System.Drawing.Point(207, 286);
            this.textBoxMiasto.Multiline = true;
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(166, 30);
            this.textBoxMiasto.TabIndex = 75;
            this.textBoxMiasto.WordWrap = false;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNazwisko.Location = new System.Drawing.Point(207, 214);
            this.textBoxNazwisko.Multiline = true;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(166, 30);
            this.textBoxNazwisko.TabIndex = 74;
            this.textBoxNazwisko.WordWrap = false;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxImie.Location = new System.Drawing.Point(207, 178);
            this.textBoxImie.Multiline = true;
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(166, 30);
            this.textBoxImie.TabIndex = 73;
            this.textBoxImie.WordWrap = false;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPesel.Location = new System.Drawing.Point(207, 250);
            this.textBoxPesel.Multiline = true;
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(166, 30);
            this.textBoxPesel.TabIndex = 72;
            this.textBoxPesel.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Pesel:";
            // 
            // textBoxStanowisko
            // 
            this.textBoxStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxStanowisko.Location = new System.Drawing.Point(207, 466);
            this.textBoxStanowisko.Multiline = true;
            this.textBoxStanowisko.Name = "textBoxStanowisko";
            this.textBoxStanowisko.Size = new System.Drawing.Size(165, 30);
            this.textBoxStanowisko.TabIndex = 96;
            this.textBoxStanowisko.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(30, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 95;
            this.label10.Text = "Stanowisko";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(29, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 94;
            this.label11.Text = "Pensja:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(29, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 18);
            this.label12.TabIndex = 93;
            this.label12.Text = "Data zatrudnienia:";
            // 
            // textBoxPensja
            // 
            this.textBoxPensja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPensja.Location = new System.Drawing.Point(207, 430);
            this.textBoxPensja.Multiline = true;
            this.textBoxPensja.Name = "textBoxPensja";
            this.textBoxPensja.Size = new System.Drawing.Size(165, 30);
            this.textBoxPensja.TabIndex = 92;
            this.textBoxPensja.WordWrap = false;
            // 
            // dateTimePickerDataZatrudnienia
            // 
            this.dateTimePickerDataZatrudnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerDataZatrudnienia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataZatrudnienia.Location = new System.Drawing.Point(207, 502);
            this.dateTimePickerDataZatrudnienia.Name = "dateTimePickerDataZatrudnienia";
            this.dateTimePickerDataZatrudnienia.Size = new System.Drawing.Size(165, 24);
            this.dateTimePickerDataZatrudnienia.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(395, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 25);
            this.label13.TabIndex = 101;
            this.label13.Text = "Lista pracowników";
            // 
            // panelTytulowy
            // 
            this.panelTytulowy.BackColor = System.Drawing.Color.Teal;
            this.panelTytulowy.Controls.Add(this.label14);
            this.panelTytulowy.Controls.Add(this.labelZalogowany);
            this.panelTytulowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytulowy.Location = new System.Drawing.Point(0, 0);
            this.panelTytulowy.Name = "panelTytulowy";
            this.panelTytulowy.Size = new System.Drawing.Size(1264, 80);
            this.panelTytulowy.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(529, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 39);
            this.label14.TabIndex = 0;
            this.label14.Text = "PRACOWNICY";
            // 
            // labelZalogowany
            // 
            this.labelZalogowany.AutoSize = true;
            this.labelZalogowany.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZalogowany.ForeColor = System.Drawing.Color.White;
            this.labelZalogowany.Location = new System.Drawing.Point(1121, 9);
            this.labelZalogowany.Name = "labelZalogowany";
            this.labelZalogowany.Size = new System.Drawing.Size(131, 25);
            this.labelZalogowany.TabIndex = 88;
            this.labelZalogowany.Text = "labelZalogowany";
            this.labelZalogowany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 99;
            this.label15.Text = "Pracownik";
            // 
            // buttonSzukajPracownika
            // 
            this.buttonSzukajPracownika.BackColor = System.Drawing.Color.Teal;
            this.buttonSzukajPracownika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSzukajPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSzukajPracownika.ForeColor = System.Drawing.Color.White;
            this.buttonSzukajPracownika.Location = new System.Drawing.Point(298, 541);
            this.buttonSzukajPracownika.Name = "buttonSzukajPracownika";
            this.buttonSzukajPracownika.Size = new System.Drawing.Size(75, 34);
            this.buttonSzukajPracownika.TabIndex = 106;
            this.buttonSzukajPracownika.Text = "Szukaj";
            this.buttonSzukajPracownika.UseVisualStyleBackColor = false;
            this.buttonSzukajPracownika.Click += new System.EventHandler(this.buttonSzukajPracownika_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(209, 541);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 34);
            this.buttonAnuluj.TabIndex = 105;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = false;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.Color.Teal;
            this.buttonUsun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUsun.ForeColor = System.Drawing.Color.White;
            this.buttonUsun.Location = new System.Drawing.Point(122, 541);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 34);
            this.buttonUsun.TabIndex = 104;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = false;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.Teal;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(34, 541);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 34);
            this.buttonDodaj.TabIndex = 103;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // PracownicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSzukajPracownika);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePickerDataZatrudnienia);
            this.Controls.Add(this.textBoxStanowisko);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPensja);
            this.Controls.Add(this.dataGridViewPracownicy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdPracownika);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNrTel);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxMiasto);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.label1);
            this.Name = "PracownicyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.PracownicyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPracownicy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdPracownika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNrTel;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStanowisko;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPensja;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataZatrudnienia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSzukajPracownika;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pensja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanowisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataZatrudnienia;
    }
}