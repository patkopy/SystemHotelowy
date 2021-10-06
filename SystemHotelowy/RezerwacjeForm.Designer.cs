
namespace SystemHotelowy
{
    partial class RezerwacjeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRezerwacje = new System.Windows.Forms.DataGridView();
            this.IdRezerwacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKlienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiczbaOsob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyAktywna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdRezerwacji = new System.Windows.Forms.TextBox();
            this.textBoxIdKlienta = new System.Windows.Forms.TextBox();
            this.textBoxIdPokoju = new System.Windows.Forms.TextBox();
            this.textBoxIloscOsob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdPracownika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxCzyAktywna = new System.Windows.Forms.CheckBox();
            this.dataGridViewPokoje = new System.Windows.Forms.DataGridView();
            this.PokojeIdPokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiczbaMiejsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaZaDobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyWolny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyPosprzatany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSprawdzPokoje = new System.Windows.Forms.Button();
            this.dateTimePickerDataOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataDo = new System.Windows.Forms.DateTimePicker();
            this.buttonWyswietlWszystkieRezerwacje = new System.Windows.Forms.Button();
            this.buttonWyswietlAktualneRezerwacje = new System.Windows.Forms.Button();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonSzukajMeldunkuKlienta = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNrTel = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezerwacje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokoje)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRezerwacje
            // 
            this.dataGridViewRezerwacje.AllowUserToDeleteRows = false;
            this.dataGridViewRezerwacje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRezerwacje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRezerwacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezerwacje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRezerwacji,
            this.IdKlienta,
            this.IdPokoju,
            this.LiczbaOsob,
            this.DataOd,
            this.DataDo,
            this.CzyAktywna,
            this.IdPracownika});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRezerwacje.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRezerwacje.EnableHeadersVisualStyles = false;
            this.dataGridViewRezerwacje.Location = new System.Drawing.Point(400, 140);
            this.dataGridViewRezerwacje.Name = "dataGridViewRezerwacje";
            this.dataGridViewRezerwacje.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRezerwacje.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRezerwacje.RowTemplate.Height = 30;
            this.dataGridViewRezerwacje.Size = new System.Drawing.Size(825, 266);
            this.dataGridViewRezerwacje.TabIndex = 1;
            this.dataGridViewRezerwacje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRezerwacje_MouseDoubleClick);
            // 
            // IdRezerwacji
            // 
            this.IdRezerwacji.DataPropertyName = "IdRezerwacji";
            this.IdRezerwacji.HeaderText = "ID Rezerwacji";
            this.IdRezerwacji.Name = "IdRezerwacji";
            this.IdRezerwacji.ReadOnly = true;
            this.IdRezerwacji.Width = 117;
            // 
            // IdKlienta
            // 
            this.IdKlienta.DataPropertyName = "IdKlienta";
            this.IdKlienta.HeaderText = "ID Klienta";
            this.IdKlienta.Name = "IdKlienta";
            this.IdKlienta.ReadOnly = true;
            this.IdKlienta.Width = 91;
            // 
            // IdPokoju
            // 
            this.IdPokoju.DataPropertyName = "IdPokoju";
            this.IdPokoju.HeaderText = "ID Pokoju";
            this.IdPokoju.Name = "IdPokoju";
            this.IdPokoju.ReadOnly = true;
            this.IdPokoju.Width = 92;
            // 
            // LiczbaOsob
            // 
            this.LiczbaOsob.DataPropertyName = "LiczbaOsob";
            this.LiczbaOsob.HeaderText = "Liczba osób";
            this.LiczbaOsob.Name = "LiczbaOsob";
            this.LiczbaOsob.ReadOnly = true;
            this.LiczbaOsob.Width = 107;
            // 
            // DataOd
            // 
            this.DataOd.DataPropertyName = "DataOd";
            this.DataOd.HeaderText = "Data rozpoczęcia";
            this.DataOd.Name = "DataOd";
            this.DataOd.ReadOnly = true;
            this.DataOd.Width = 141;
            // 
            // DataDo
            // 
            this.DataDo.DataPropertyName = "DataDo";
            this.DataDo.HeaderText = "Data zakończenia";
            this.DataDo.Name = "DataDo";
            this.DataDo.ReadOnly = true;
            this.DataDo.Width = 142;
            // 
            // CzyAktywna
            // 
            this.CzyAktywna.DataPropertyName = "CzyAktywna";
            this.CzyAktywna.HeaderText = "Status aktywności";
            this.CzyAktywna.Name = "CzyAktywna";
            this.CzyAktywna.ReadOnly = true;
            this.CzyAktywna.Width = 142;
            // 
            // IdPracownika
            // 
            this.IdPracownika.DataPropertyName = "IdPracownika";
            this.IdPracownika.HeaderText = "ID Pracownika";
            this.IdPracownika.Name = "IdPracownika";
            this.IdPracownika.ReadOnly = true;
            this.IdPracownika.Width = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identyfikator rezerwacji:";
            // 
            // textBoxIdRezerwacji
            // 
            this.textBoxIdRezerwacji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdRezerwacji.Location = new System.Drawing.Point(207, 140);
            this.textBoxIdRezerwacji.Multiline = true;
            this.textBoxIdRezerwacji.Name = "textBoxIdRezerwacji";
            this.textBoxIdRezerwacji.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdRezerwacji.TabIndex = 3;
            this.textBoxIdRezerwacji.WordWrap = false;
            // 
            // textBoxIdKlienta
            // 
            this.textBoxIdKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdKlienta.Location = new System.Drawing.Point(207, 176);
            this.textBoxIdKlienta.Multiline = true;
            this.textBoxIdKlienta.Name = "textBoxIdKlienta";
            this.textBoxIdKlienta.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdKlienta.TabIndex = 4;
            this.textBoxIdKlienta.WordWrap = false;
            // 
            // textBoxIdPokoju
            // 
            this.textBoxIdPokoju.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdPokoju.Location = new System.Drawing.Point(207, 212);
            this.textBoxIdPokoju.Multiline = true;
            this.textBoxIdPokoju.Name = "textBoxIdPokoju";
            this.textBoxIdPokoju.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdPokoju.TabIndex = 5;
            this.textBoxIdPokoju.WordWrap = false;
            // 
            // textBoxIloscOsob
            // 
            this.textBoxIloscOsob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIloscOsob.Location = new System.Drawing.Point(207, 248);
            this.textBoxIloscOsob.Multiline = true;
            this.textBoxIloscOsob.Name = "textBoxIloscOsob";
            this.textBoxIloscOsob.Size = new System.Drawing.Size(168, 30);
            this.textBoxIloscOsob.TabIndex = 10;
            this.textBoxIloscOsob.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Identyfikator klienta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(31, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Identyfikator pokoju:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(31, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data rozpoczęcia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(31, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data zakończenia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(31, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Liczba osób:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(31, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status aktywności:";
            // 
            // textBoxIdPracownika
            // 
            this.textBoxIdPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdPracownika.Location = new System.Drawing.Point(207, 284);
            this.textBoxIdPracownika.Multiline = true;
            this.textBoxIdPracownika.Name = "textBoxIdPracownika";
            this.textBoxIdPracownika.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdPracownika.TabIndex = 18;
            this.textBoxIdPracownika.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(31, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Identyfikator pracownika:";
            // 
            // checkBoxCzyAktywna
            // 
            this.checkBoxCzyAktywna.AutoSize = true;
            this.checkBoxCzyAktywna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxCzyAktywna.Location = new System.Drawing.Point(207, 400);
            this.checkBoxCzyAktywna.Name = "checkBoxCzyAktywna";
            this.checkBoxCzyAktywna.Size = new System.Drawing.Size(82, 22);
            this.checkBoxCzyAktywna.TabIndex = 20;
            this.checkBoxCzyAktywna.Text = "Aktywna";
            this.checkBoxCzyAktywna.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPokoje
            // 
            this.dataGridViewPokoje.AllowUserToDeleteRows = false;
            this.dataGridViewPokoje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPokoje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPokoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokoje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PokojeIdPokoju,
            this.Numer,
            this.LiczbaMiejsc,
            this.CenaZaDobe,
            this.CzyWolny,
            this.CzyPosprzatany});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPokoje.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPokoje.EnableHeadersVisualStyles = false;
            this.dataGridViewPokoje.Location = new System.Drawing.Point(400, 486);
            this.dataGridViewPokoje.Name = "dataGridViewPokoje";
            this.dataGridViewPokoje.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPokoje.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPokoje.RowTemplate.Height = 30;
            this.dataGridViewPokoje.Size = new System.Drawing.Size(825, 158);
            this.dataGridViewPokoje.TabIndex = 29;
            this.dataGridViewPokoje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPokoje_MouseDoubleClick);
            // 
            // PokojeIdPokoju
            // 
            this.PokojeIdPokoju.DataPropertyName = "IdPokoju";
            this.PokojeIdPokoju.HeaderText = "ID Pokoju";
            this.PokojeIdPokoju.Name = "PokojeIdPokoju";
            this.PokojeIdPokoju.ReadOnly = true;
            // 
            // Numer
            // 
            this.Numer.DataPropertyName = "Numer";
            this.Numer.HeaderText = "Numer";
            this.Numer.Name = "Numer";
            this.Numer.ReadOnly = true;
            // 
            // LiczbaMiejsc
            // 
            this.LiczbaMiejsc.DataPropertyName = "LiczbaMiejsc";
            this.LiczbaMiejsc.HeaderText = "Liczba miejsc";
            this.LiczbaMiejsc.Name = "LiczbaMiejsc";
            this.LiczbaMiejsc.ReadOnly = true;
            // 
            // CenaZaDobe
            // 
            this.CenaZaDobe.DataPropertyName = "CenaZaDobe";
            this.CenaZaDobe.HeaderText = "Cena za dzień";
            this.CenaZaDobe.Name = "CenaZaDobe";
            this.CenaZaDobe.ReadOnly = true;
            // 
            // CzyWolny
            // 
            this.CzyWolny.DataPropertyName = "CzyWolny";
            this.CzyWolny.HeaderText = "Dostępność";
            this.CzyWolny.Name = "CzyWolny";
            this.CzyWolny.ReadOnly = true;
            // 
            // CzyPosprzatany
            // 
            this.CzyPosprzatany.DataPropertyName = "CzyPosprzatany";
            this.CzyPosprzatany.HeaderText = "Stan sprzątania";
            this.CzyPosprzatany.Name = "CzyPosprzatany";
            this.CzyPosprzatany.ReadOnly = true;
            // 
            // buttonSprawdzPokoje
            // 
            this.buttonSprawdzPokoje.BackColor = System.Drawing.Color.Teal;
            this.buttonSprawdzPokoje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSprawdzPokoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSprawdzPokoje.ForeColor = System.Drawing.Color.White;
            this.buttonSprawdzPokoje.Location = new System.Drawing.Point(115, 476);
            this.buttonSprawdzPokoje.Name = "buttonSprawdzPokoje";
            this.buttonSprawdzPokoje.Size = new System.Drawing.Size(260, 34);
            this.buttonSprawdzPokoje.TabIndex = 32;
            this.buttonSprawdzPokoje.Text = "Sprawdź wolne pokoje";
            this.buttonSprawdzPokoje.UseVisualStyleBackColor = false;
            this.buttonSprawdzPokoje.Click += new System.EventHandler(this.buttonSprawdzPokoje_Click);
            // 
            // dateTimePickerDataOd
            // 
            this.dateTimePickerDataOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerDataOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataOd.Location = new System.Drawing.Point(207, 320);
            this.dateTimePickerDataOd.Name = "dateTimePickerDataOd";
            this.dateTimePickerDataOd.Size = new System.Drawing.Size(168, 24);
            this.dateTimePickerDataOd.TabIndex = 33;
            // 
            // dateTimePickerDataDo
            // 
            this.dateTimePickerDataDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerDataDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDo.Location = new System.Drawing.Point(207, 358);
            this.dateTimePickerDataDo.Name = "dateTimePickerDataDo";
            this.dateTimePickerDataDo.Size = new System.Drawing.Size(168, 24);
            this.dateTimePickerDataDo.TabIndex = 34;
            // 
            // buttonWyswietlWszystkieRezerwacje
            // 
            this.buttonWyswietlWszystkieRezerwacje.BackColor = System.Drawing.Color.Teal;
            this.buttonWyswietlWszystkieRezerwacje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWyswietlWszystkieRezerwacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonWyswietlWszystkieRezerwacje.ForeColor = System.Drawing.Color.White;
            this.buttonWyswietlWszystkieRezerwacje.Location = new System.Drawing.Point(965, 412);
            this.buttonWyswietlWszystkieRezerwacje.Name = "buttonWyswietlWszystkieRezerwacje";
            this.buttonWyswietlWszystkieRezerwacje.Size = new System.Drawing.Size(260, 34);
            this.buttonWyswietlWszystkieRezerwacje.TabIndex = 35;
            this.buttonWyswietlWszystkieRezerwacje.Text = "Wyświetl wszystkie rezerwacje";
            this.buttonWyswietlWszystkieRezerwacje.UseVisualStyleBackColor = false;
            this.buttonWyswietlWszystkieRezerwacje.Click += new System.EventHandler(this.buttonWyswietlWszystkieRezerwacje_Click);
            // 
            // buttonWyswietlAktualneRezerwacje
            // 
            this.buttonWyswietlAktualneRezerwacje.BackColor = System.Drawing.Color.Teal;
            this.buttonWyswietlAktualneRezerwacje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWyswietlAktualneRezerwacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonWyswietlAktualneRezerwacje.ForeColor = System.Drawing.Color.White;
            this.buttonWyswietlAktualneRezerwacje.Location = new System.Drawing.Point(687, 412);
            this.buttonWyswietlAktualneRezerwacje.Name = "buttonWyswietlAktualneRezerwacje";
            this.buttonWyswietlAktualneRezerwacje.Size = new System.Drawing.Size(260, 34);
            this.buttonWyswietlAktualneRezerwacje.TabIndex = 36;
            this.buttonWyswietlAktualneRezerwacje.Text = "Wyświetl aktualne rezerwacje";
            this.buttonWyswietlAktualneRezerwacje.UseVisualStyleBackColor = false;
            this.buttonWyswietlAktualneRezerwacje.Click += new System.EventHandler(this.buttonWyswietlAktualneRezerwacje_Click);
            // 
            // panelTytulowy
            // 
            this.panelTytulowy.BackColor = System.Drawing.Color.Teal;
            this.panelTytulowy.Controls.Add(this.label16);
            this.panelTytulowy.Controls.Add(this.labelZalogowany);
            this.panelTytulowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytulowy.Location = new System.Drawing.Point(0, 0);
            this.panelTytulowy.Name = "panelTytulowy";
            this.panelTytulowy.Size = new System.Drawing.Size(1264, 80);
            this.panelTytulowy.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(527, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(214, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "REZERWACJE";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(395, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 25);
            this.label14.TabIndex = 106;
            this.label14.Text = "Lista rezerwacji";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 25);
            this.label15.TabIndex = 105;
            this.label15.Text = "Rezerwacja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(395, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 108;
            this.label11.Text = "Lista pokojów";
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(300, 433);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 34);
            this.buttonAnuluj.TabIndex = 111;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = false;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.Color.Teal;
            this.buttonUsun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.ForeColor = System.Drawing.Color.White;
            this.buttonUsun.Location = new System.Drawing.Point(207, 433);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 34);
            this.buttonUsun.TabIndex = 110;
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
            this.buttonDodaj.Location = new System.Drawing.Point(115, 433);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 34);
            this.buttonDodaj.TabIndex = 109;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonSzukajMeldunkuKlienta
            // 
            this.buttonSzukajMeldunkuKlienta.BackColor = System.Drawing.Color.Teal;
            this.buttonSzukajMeldunkuKlienta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSzukajMeldunkuKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSzukajMeldunkuKlienta.ForeColor = System.Drawing.Color.White;
            this.buttonSzukajMeldunkuKlienta.Location = new System.Drawing.Point(298, 635);
            this.buttonSzukajMeldunkuKlienta.Name = "buttonSzukajMeldunkuKlienta";
            this.buttonSzukajMeldunkuKlienta.Size = new System.Drawing.Size(75, 34);
            this.buttonSzukajMeldunkuKlienta.TabIndex = 160;
            this.buttonSzukajMeldunkuKlienta.Text = "Szukaj";
            this.buttonSzukajMeldunkuKlienta.UseVisualStyleBackColor = false;
            this.buttonSzukajMeldunkuKlienta.Click += new System.EventHandler(this.buttonSzukajKlienta_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(29, 522);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(265, 25);
            this.label17.TabIndex = 159;
            this.label17.Text = "Znajdź identyfikator klienta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(31, 598);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 158;
            this.label9.Text = "Numer telefonu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(31, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 157;
            this.label13.Text = "Nazwisko:";
            // 
            // textBoxNrTel
            // 
            this.textBoxNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNrTel.Location = new System.Drawing.Point(207, 595);
            this.textBoxNrTel.Multiline = true;
            this.textBoxNrTel.Name = "textBoxNrTel";
            this.textBoxNrTel.Size = new System.Drawing.Size(166, 30);
            this.textBoxNrTel.TabIndex = 156;
            this.textBoxNrTel.WordWrap = false;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNazwisko.Location = new System.Drawing.Point(207, 559);
            this.textBoxNazwisko.Multiline = true;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(166, 30);
            this.textBoxNazwisko.TabIndex = 155;
            this.textBoxNazwisko.WordWrap = false;
            // 
            // RezerwacjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSzukajMeldunkuKlienta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxNrTel);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonWyswietlAktualneRezerwacje);
            this.Controls.Add(this.buttonWyswietlWszystkieRezerwacje);
            this.Controls.Add(this.dateTimePickerDataDo);
            this.Controls.Add(this.dateTimePickerDataOd);
            this.Controls.Add(this.buttonSprawdzPokoje);
            this.Controls.Add(this.dataGridViewPokoje);
            this.Controls.Add(this.checkBoxCzyAktywna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxIdPracownika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIloscOsob);
            this.Controls.Add(this.textBoxIdPokoju);
            this.Controls.Add(this.textBoxIdKlienta);
            this.Controls.Add(this.textBoxIdRezerwacji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRezerwacje);
            this.Name = "RezerwacjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezerwacje";
            this.Load += new System.EventHandler(this.RezerwacjeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezerwacje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokoje)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRezerwacje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdRezerwacji;
        private System.Windows.Forms.TextBox textBoxIdKlienta;
        private System.Windows.Forms.TextBox textBoxIdPokoju;
        private System.Windows.Forms.TextBox textBoxIloscOsob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIdPracownika;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxCzyAktywna;
        private System.Windows.Forms.DataGridView dataGridViewPokoje;
        private System.Windows.Forms.Button buttonSprawdzPokoje;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDo;
        private System.Windows.Forms.Button buttonWyswietlWszystkieRezerwacje;
        private System.Windows.Forms.Button buttonWyswietlAktualneRezerwacje;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonSzukajMeldunkuKlienta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNrTel;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn PokojeIdPokoju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaMiejsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaZaDobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyWolny;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyPosprzatany;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRezerwacji;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPokoju;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaOsob;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyAktywna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPracownika;
    }
}