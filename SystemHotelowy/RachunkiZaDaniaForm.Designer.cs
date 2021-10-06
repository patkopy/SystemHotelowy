
namespace SystemHotelowy
{
    partial class RachunkiZaDaniaForm
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
            this.dateTimePickerTerminZaplaty = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNrTel = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.checkBoxCzyZaplacono = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdRachunkuZaDanie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewRachunkiZaDania = new System.Windows.Forms.DataGridView();
            this.IdRachunkuZaDanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKlienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminZaplaty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyZaplacono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdPracownika = new System.Windows.Forms.TextBox();
            this.textBoxKwota = new System.Windows.Forms.TextBox();
            this.textBoxIdDania = new System.Windows.Forms.TextBox();
            this.textBoxIdKlienta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDania = new System.Windows.Forms.DataGridView();
            this.DaniaIdDania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTyp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLiczbaDan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSzukajDania = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonSzukajKlienta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRachunkiZaDania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDania)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerTerminZaplaty
            // 
            this.dateTimePickerTerminZaplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerTerminZaplaty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTerminZaplaty.Location = new System.Drawing.Point(208, 358);
            this.dateTimePickerTerminZaplaty.Name = "dateTimePickerTerminZaplaty";
            this.dateTimePickerTerminZaplaty.Size = new System.Drawing.Size(168, 24);
            this.dateTimePickerTerminZaplaty.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(31, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 58;
            this.label10.Text = "Numer telefonu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(31, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nazwisko:";
            // 
            // textBoxNrTel
            // 
            this.textBoxNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNrTel.Location = new System.Drawing.Point(208, 575);
            this.textBoxNrTel.Multiline = true;
            this.textBoxNrTel.Name = "textBoxNrTel";
            this.textBoxNrTel.Size = new System.Drawing.Size(168, 30);
            this.textBoxNrTel.TabIndex = 54;
            this.textBoxNrTel.WordWrap = false;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNazwisko.Location = new System.Drawing.Point(208, 539);
            this.textBoxNazwisko.Multiline = true;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(168, 30);
            this.textBoxNazwisko.TabIndex = 53;
            this.textBoxNazwisko.WordWrap = false;
            // 
            // checkBoxCzyZaplacono
            // 
            this.checkBoxCzyZaplacono.AutoSize = true;
            this.checkBoxCzyZaplacono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxCzyZaplacono.Location = new System.Drawing.Point(206, 399);
            this.checkBoxCzyZaplacono.Name = "checkBoxCzyZaplacono";
            this.checkBoxCzyZaplacono.Size = new System.Drawing.Size(97, 22);
            this.checkBoxCzyZaplacono.TabIndex = 52;
            this.checkBoxCzyZaplacono.Text = "Zapłacono";
            this.checkBoxCzyZaplacono.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(30, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "Identyfikator rachunku:";
            // 
            // textBoxIdRachunkuZaDanie
            // 
            this.textBoxIdRachunkuZaDanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdRachunkuZaDanie.Location = new System.Drawing.Point(208, 142);
            this.textBoxIdRachunkuZaDanie.Multiline = true;
            this.textBoxIdRachunkuZaDanie.Name = "textBoxIdRachunkuZaDanie";
            this.textBoxIdRachunkuZaDanie.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdRachunkuZaDanie.TabIndex = 50;
            this.textBoxIdRachunkuZaDanie.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(31, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Status płatności:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(31, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Identyfikator pracownika:";
            // 
            // dataGridViewRachunkiZaDania
            // 
            this.dataGridViewRachunkiZaDania.AllowUserToDeleteRows = false;
            this.dataGridViewRachunkiZaDania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRachunkiZaDania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRachunkiZaDania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRachunkiZaDania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRachunkuZaDanie,
            this.IdKlienta,
            this.IdDania,
            this.Kwota,
            this.TerminZaplaty,
            this.CzyZaplacono,
            this.IdPracownika});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRachunkiZaDania.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRachunkiZaDania.EnableHeadersVisualStyles = false;
            this.dataGridViewRachunkiZaDania.Location = new System.Drawing.Point(400, 137);
            this.dataGridViewRachunkiZaDania.Name = "dataGridViewRachunkiZaDania";
            this.dataGridViewRachunkiZaDania.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRachunkiZaDania.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRachunkiZaDania.RowTemplate.Height = 30;
            this.dataGridViewRachunkiZaDania.Size = new System.Drawing.Size(825, 278);
            this.dataGridViewRachunkiZaDania.TabIndex = 36;
            this.dataGridViewRachunkiZaDania.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRachunkiZaDania_MouseDoubleClick);
            // 
            // IdRachunkuZaDanie
            // 
            this.IdRachunkuZaDanie.DataPropertyName = "IdRachunkuZaDanie";
            this.IdRachunkuZaDanie.HeaderText = "ID Rachunku";
            this.IdRachunkuZaDanie.Name = "IdRachunkuZaDanie";
            this.IdRachunkuZaDanie.ReadOnly = true;
            // 
            // IdKlienta
            // 
            this.IdKlienta.DataPropertyName = "IdKlienta";
            this.IdKlienta.HeaderText = "ID Klienta";
            this.IdKlienta.Name = "IdKlienta";
            this.IdKlienta.ReadOnly = true;
            // 
            // IdDania
            // 
            this.IdDania.DataPropertyName = "IdDania";
            this.IdDania.HeaderText = "ID Dania";
            this.IdDania.Name = "IdDania";
            this.IdDania.ReadOnly = true;
            // 
            // Kwota
            // 
            this.Kwota.DataPropertyName = "Kwota";
            this.Kwota.HeaderText = "Kwota";
            this.Kwota.Name = "Kwota";
            this.Kwota.ReadOnly = true;
            // 
            // TerminZaplaty
            // 
            this.TerminZaplaty.DataPropertyName = "TerminZaplaty";
            this.TerminZaplaty.HeaderText = "Termin zapłaty";
            this.TerminZaplaty.Name = "TerminZaplaty";
            this.TerminZaplaty.ReadOnly = true;
            // 
            // CzyZaplacono
            // 
            this.CzyZaplacono.DataPropertyName = "CzyZaplacono";
            this.CzyZaplacono.HeaderText = "Status płatności";
            this.CzyZaplacono.Name = "CzyZaplacono";
            this.CzyZaplacono.ReadOnly = true;
            // 
            // IdPracownika
            // 
            this.IdPracownika.DataPropertyName = "IdPracownika";
            this.IdPracownika.HeaderText = "ID Pracownika";
            this.IdPracownika.Name = "IdPracownika";
            this.IdPracownika.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(31, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Termin zapłaty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(31, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Kwota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Identyfikator dania:";
            // 
            // textBoxIdPracownika
            // 
            this.textBoxIdPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdPracownika.Location = new System.Drawing.Point(208, 322);
            this.textBoxIdPracownika.Multiline = true;
            this.textBoxIdPracownika.Name = "textBoxIdPracownika";
            this.textBoxIdPracownika.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdPracownika.TabIndex = 43;
            this.textBoxIdPracownika.WordWrap = false;
            // 
            // textBoxKwota
            // 
            this.textBoxKwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxKwota.Location = new System.Drawing.Point(208, 250);
            this.textBoxKwota.Multiline = true;
            this.textBoxKwota.Name = "textBoxKwota";
            this.textBoxKwota.Size = new System.Drawing.Size(168, 30);
            this.textBoxKwota.TabIndex = 40;
            this.textBoxKwota.WordWrap = false;
            // 
            // textBoxIdDania
            // 
            this.textBoxIdDania.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdDania.Location = new System.Drawing.Point(208, 214);
            this.textBoxIdDania.Multiline = true;
            this.textBoxIdDania.Name = "textBoxIdDania";
            this.textBoxIdDania.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdDania.TabIndex = 39;
            this.textBoxIdDania.WordWrap = false;
            // 
            // textBoxIdKlienta
            // 
            this.textBoxIdKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdKlienta.Location = new System.Drawing.Point(208, 178);
            this.textBoxIdKlienta.Multiline = true;
            this.textBoxIdKlienta.Name = "textBoxIdKlienta";
            this.textBoxIdKlienta.Size = new System.Drawing.Size(168, 30);
            this.textBoxIdKlienta.TabIndex = 38;
            this.textBoxIdKlienta.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Identyfikator klienta:";
            // 
            // dataGridViewDania
            // 
            this.dataGridViewDania.AllowUserToDeleteRows = false;
            this.dataGridViewDania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDania.ColumnHeadersHeight = 37;
            this.dataGridViewDania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DaniaIdDania,
            this.Typ,
            this.Nazwa,
            this.Cena,
            this.Opis});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDania.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDania.EnableHeadersVisualStyles = false;
            this.dataGridViewDania.Location = new System.Drawing.Point(400, 485);
            this.dataGridViewDania.Name = "dataGridViewDania";
            this.dataGridViewDania.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDania.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDania.RowTemplate.Height = 30;
            this.dataGridViewDania.Size = new System.Drawing.Size(825, 158);
            this.dataGridViewDania.TabIndex = 88;
            this.dataGridViewDania.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDania_MouseDoubleClick);
            // 
            // DaniaIdDania
            // 
            this.DaniaIdDania.DataPropertyName = "IdDania";
            this.DaniaIdDania.HeaderText = "ID Dania";
            this.DaniaIdDania.Name = "DaniaIdDania";
            this.DaniaIdDania.ReadOnly = true;
            // 
            // Typ
            // 
            this.Typ.DataPropertyName = "Typ";
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // comboBoxTyp
            // 
            this.comboBoxTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxTyp.FormattingEnabled = true;
            this.comboBoxTyp.Location = new System.Drawing.Point(1012, 449);
            this.comboBoxTyp.Name = "comboBoxTyp";
            this.comboBoxTyp.Size = new System.Drawing.Size(121, 26);
            this.comboBoxTyp.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(931, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 94;
            this.label5.Text = "Typ dania:";
            // 
            // textBoxLiczbaDan
            // 
            this.textBoxLiczbaDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLiczbaDan.Location = new System.Drawing.Point(208, 286);
            this.textBoxLiczbaDan.Multiline = true;
            this.textBoxLiczbaDan.Name = "textBoxLiczbaDan";
            this.textBoxLiczbaDan.Size = new System.Drawing.Size(168, 30);
            this.textBoxLiczbaDan.TabIndex = 97;
            this.textBoxLiczbaDan.WordWrap = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(31, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 98;
            this.label13.Text = "Liczba dań:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(395, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 25);
            this.label14.TabIndex = 104;
            this.label14.Text = "Lista rachunków";
            // 
            // panelTytulowy
            // 
            this.panelTytulowy.BackColor = System.Drawing.Color.Teal;
            this.panelTytulowy.Controls.Add(this.label15);
            this.panelTytulowy.Controls.Add(this.labelZalogowany);
            this.panelTytulowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytulowy.Location = new System.Drawing.Point(0, 0);
            this.panelTytulowy.Name = "panelTytulowy";
            this.panelTytulowy.Size = new System.Drawing.Size(1264, 80);
            this.panelTytulowy.TabIndex = 103;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(477, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(321, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "RACHUNKI ZA DANIA";
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(29, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 25);
            this.label16.TabIndex = 102;
            this.label16.Text = "Rachunek";
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(302, 427);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 34);
            this.buttonAnuluj.TabIndex = 108;
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
            this.buttonUsun.Location = new System.Drawing.Point(215, 427);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 34);
            this.buttonUsun.TabIndex = 107;
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
            this.buttonDodaj.Location = new System.Drawing.Point(127, 427);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 34);
            this.buttonDodaj.TabIndex = 106;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(395, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 109;
            this.label11.Text = "Lista dań";
            // 
            // buttonSzukajDania
            // 
            this.buttonSzukajDania.BackColor = System.Drawing.Color.Teal;
            this.buttonSzukajDania.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSzukajDania.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSzukajDania.ForeColor = System.Drawing.Color.White;
            this.buttonSzukajDania.Location = new System.Drawing.Point(1150, 445);
            this.buttonSzukajDania.Name = "buttonSzukajDania";
            this.buttonSzukajDania.Size = new System.Drawing.Size(75, 34);
            this.buttonSzukajDania.TabIndex = 110;
            this.buttonSzukajDania.Text = "Szukaj";
            this.buttonSzukajDania.UseVisualStyleBackColor = false;
            this.buttonSzukajDania.Click += new System.EventHandler(this.buttonSzukajDania_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(29, 499);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(265, 25);
            this.label17.TabIndex = 111;
            this.label17.Text = "Znajdź identyfikator klienta";
            // 
            // buttonSzukajKlienta
            // 
            this.buttonSzukajKlienta.BackColor = System.Drawing.Color.Teal;
            this.buttonSzukajKlienta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSzukajKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSzukajKlienta.ForeColor = System.Drawing.Color.White;
            this.buttonSzukajKlienta.Location = new System.Drawing.Point(302, 620);
            this.buttonSzukajKlienta.Name = "buttonSzukajKlienta";
            this.buttonSzukajKlienta.Size = new System.Drawing.Size(75, 34);
            this.buttonSzukajKlienta.TabIndex = 112;
            this.buttonSzukajKlienta.Text = "Szukaj";
            this.buttonSzukajKlienta.UseVisualStyleBackColor = false;
            this.buttonSzukajKlienta.Click += new System.EventHandler(this.buttonSzukajKlienta_Click);
            // 
            // RachunkiZaDaniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSzukajKlienta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonSzukajDania);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxLiczbaDan);
            this.Controls.Add(this.comboBoxTyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewDania);
            this.Controls.Add(this.dateTimePickerTerminZaplaty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNrTel);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.checkBoxCzyZaplacono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxIdRachunkuZaDanie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewRachunkiZaDania);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdPracownika);
            this.Controls.Add(this.textBoxKwota);
            this.Controls.Add(this.textBoxIdDania);
            this.Controls.Add(this.textBoxIdKlienta);
            this.Controls.Add(this.label1);
            this.Name = "RachunkiZaDaniaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rachunki za dania";
            this.Load += new System.EventHandler(this.RachunkiZaDaniaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRachunkiZaDania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDania)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerTerminZaplaty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNrTel;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.CheckBox checkBoxCzyZaplacono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdRachunkuZaDanie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewRachunkiZaDania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdPracownika;
        private System.Windows.Forms.TextBox textBoxKwota;
        private System.Windows.Forms.TextBox textBoxIdDania;
        private System.Windows.Forms.TextBox textBoxIdKlienta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDania;
        private System.Windows.Forms.ComboBox comboBoxTyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLiczbaDan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaniaIdDania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSzukajDania;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonSzukajKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRachunkuZaDanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminZaplaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyZaplacono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPracownika;
    }
}