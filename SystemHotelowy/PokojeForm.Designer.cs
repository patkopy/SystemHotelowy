
namespace SystemHotelowy
{
    partial class PokojeForm
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
            this.textBoxIdPokoju = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLiczbaMiejsc = new System.Windows.Forms.TextBox();
            this.textBoxNumer = new System.Windows.Forms.TextBox();
            this.dataGridViewPokoje = new System.Windows.Forms.DataGridView();
            this.IdPokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiczbaMiejsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaZaDobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyWolny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyPosprzatany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCzyWolny = new System.Windows.Forms.CheckBox();
            this.checkBoxCzyPosprzatany = new System.Windows.Forms.CheckBox();
            this.buttonWyswietlWolnePokoje = new System.Windows.Forms.Button();
            this.buttonWyswietlWszystkiePokoje = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSzukajPokoju = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokoje)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIdPokoju
            // 
            this.textBoxIdPokoju.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdPokoju.Location = new System.Drawing.Point(176, 142);
            this.textBoxIdPokoju.Multiline = true;
            this.textBoxIdPokoju.Name = "textBoxIdPokoju";
            this.textBoxIdPokoju.Size = new System.Drawing.Size(200, 30);
            this.textBoxIdPokoju.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(30, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "Identyfikator pokoju:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(30, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 97;
            this.label3.Text = "Liczba miejsc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(30, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 96;
            this.label2.Text = "Numer:";
            // 
            // textBoxLiczbaMiejsc
            // 
            this.textBoxLiczbaMiejsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLiczbaMiejsc.Location = new System.Drawing.Point(176, 214);
            this.textBoxLiczbaMiejsc.Multiline = true;
            this.textBoxLiczbaMiejsc.Name = "textBoxLiczbaMiejsc";
            this.textBoxLiczbaMiejsc.Size = new System.Drawing.Size(201, 30);
            this.textBoxLiczbaMiejsc.TabIndex = 95;
            // 
            // textBoxNumer
            // 
            this.textBoxNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNumer.Location = new System.Drawing.Point(176, 178);
            this.textBoxNumer.Multiline = true;
            this.textBoxNumer.Name = "textBoxNumer";
            this.textBoxNumer.Size = new System.Drawing.Size(201, 30);
            this.textBoxNumer.TabIndex = 94;
            // 
            // dataGridViewPokoje
            // 
            this.dataGridViewPokoje.AllowUserToDeleteRows = false;
            this.dataGridViewPokoje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPokoje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPokoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokoje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPokoju,
            this.Numer,
            this.LiczbaMiejsc,
            this.CenaZaDobe,
            this.CzyWolny,
            this.CzyPosprzatany});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPokoje.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPokoje.EnableHeadersVisualStyles = false;
            this.dataGridViewPokoje.Location = new System.Drawing.Point(400, 140);
            this.dataGridViewPokoje.Name = "dataGridViewPokoje";
            this.dataGridViewPokoje.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPokoje.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPokoje.RowTemplate.Height = 30;
            this.dataGridViewPokoje.Size = new System.Drawing.Size(825, 488);
            this.dataGridViewPokoje.TabIndex = 101;
            this.dataGridViewPokoje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPokoje_MouseDoubleClick);
            // 
            // IdPokoju
            // 
            this.IdPokoju.DataPropertyName = "IdPokoju";
            this.IdPokoju.HeaderText = "ID Pokoju";
            this.IdPokoju.Name = "IdPokoju";
            this.IdPokoju.ReadOnly = true;
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
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCena.Location = new System.Drawing.Point(176, 250);
            this.textBoxCena.Multiline = true;
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(201, 30);
            this.textBoxCena.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 106;
            this.label1.Text = "Cena za dobę:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(30, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 107;
            this.label4.Text = "Dostępność:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(30, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Stan sprzątania:";
            // 
            // checkBoxCzyWolny
            // 
            this.checkBoxCzyWolny.AutoSize = true;
            this.checkBoxCzyWolny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxCzyWolny.Location = new System.Drawing.Point(176, 286);
            this.checkBoxCzyWolny.Name = "checkBoxCzyWolny";
            this.checkBoxCzyWolny.Size = new System.Drawing.Size(69, 22);
            this.checkBoxCzyWolny.TabIndex = 109;
            this.checkBoxCzyWolny.Text = "Wolny";
            this.checkBoxCzyWolny.UseVisualStyleBackColor = true;
            // 
            // checkBoxCzyPosprzatany
            // 
            this.checkBoxCzyPosprzatany.AutoSize = true;
            this.checkBoxCzyPosprzatany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxCzyPosprzatany.Location = new System.Drawing.Point(175, 319);
            this.checkBoxCzyPosprzatany.Name = "checkBoxCzyPosprzatany";
            this.checkBoxCzyPosprzatany.Size = new System.Drawing.Size(110, 22);
            this.checkBoxCzyPosprzatany.TabIndex = 110;
            this.checkBoxCzyPosprzatany.Text = "Posprzątany";
            this.checkBoxCzyPosprzatany.UseVisualStyleBackColor = true;
            // 
            // buttonWyswietlWolnePokoje
            // 
            this.buttonWyswietlWolnePokoje.BackColor = System.Drawing.Color.Teal;
            this.buttonWyswietlWolnePokoje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWyswietlWolnePokoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonWyswietlWolnePokoje.ForeColor = System.Drawing.Color.White;
            this.buttonWyswietlWolnePokoje.Location = new System.Drawing.Point(33, 462);
            this.buttonWyswietlWolnePokoje.Name = "buttonWyswietlWolnePokoje";
            this.buttonWyswietlWolnePokoje.Size = new System.Drawing.Size(342, 34);
            this.buttonWyswietlWolnePokoje.TabIndex = 112;
            this.buttonWyswietlWolnePokoje.Text = "Wyświetl wolne pokoje";
            this.buttonWyswietlWolnePokoje.UseVisualStyleBackColor = false;
            this.buttonWyswietlWolnePokoje.Click += new System.EventHandler(this.buttonWyswietlWolnePokoje_Click);
            // 
            // buttonWyswietlWszystkiePokoje
            // 
            this.buttonWyswietlWszystkiePokoje.BackColor = System.Drawing.Color.Teal;
            this.buttonWyswietlWszystkiePokoje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWyswietlWszystkiePokoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonWyswietlWszystkiePokoje.ForeColor = System.Drawing.Color.White;
            this.buttonWyswietlWszystkiePokoje.Location = new System.Drawing.Point(32, 411);
            this.buttonWyswietlWszystkiePokoje.Name = "buttonWyswietlWszystkiePokoje";
            this.buttonWyswietlWszystkiePokoje.Size = new System.Drawing.Size(344, 34);
            this.buttonWyswietlWszystkiePokoje.TabIndex = 113;
            this.buttonWyswietlWszystkiePokoje.Text = "Wyświetl wszystkie pokoje";
            this.buttonWyswietlWszystkiePokoje.UseVisualStyleBackColor = false;
            this.buttonWyswietlWszystkiePokoje.Click += new System.EventHandler(this.buttonWyswietlWszystkiePokoje_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(395, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 116;
            this.label10.Text = "Lista pokojów";
            // 
            // panelTytulowy
            // 
            this.panelTytulowy.BackColor = System.Drawing.Color.Teal;
            this.panelTytulowy.Controls.Add(this.label11);
            this.panelTytulowy.Controls.Add(this.labelZalogowany);
            this.panelTytulowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytulowy.Location = new System.Drawing.Point(0, 0);
            this.panelTytulowy.Name = "panelTytulowy";
            this.panelTytulowy.Size = new System.Drawing.Size(1264, 80);
            this.panelTytulowy.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(566, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "POKOJE";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(29, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 25);
            this.label13.TabIndex = 114;
            this.label13.Text = "Pokój";
            // 
            // buttonSzukajPokoju
            // 
            this.buttonSzukajPokoju.BackColor = System.Drawing.Color.Teal;
            this.buttonSzukajPokoju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSzukajPokoju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSzukajPokoju.ForeColor = System.Drawing.Color.White;
            this.buttonSzukajPokoju.Location = new System.Drawing.Point(300, 361);
            this.buttonSzukajPokoju.Name = "buttonSzukajPokoju";
            this.buttonSzukajPokoju.Size = new System.Drawing.Size(75, 34);
            this.buttonSzukajPokoju.TabIndex = 120;
            this.buttonSzukajPokoju.Text = "Szukaj";
            this.buttonSzukajPokoju.UseVisualStyleBackColor = false;
            this.buttonSzukajPokoju.Click += new System.EventHandler(this.buttonSzukajPokoju_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(210, 361);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 34);
            this.buttonAnuluj.TabIndex = 119;
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
            this.buttonUsun.Location = new System.Drawing.Point(121, 361);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 34);
            this.buttonUsun.TabIndex = 118;
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
            this.buttonDodaj.Location = new System.Drawing.Point(33, 361);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 34);
            this.buttonDodaj.TabIndex = 117;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // PokojeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSzukajPokoju);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonWyswietlWszystkiePokoje);
            this.Controls.Add(this.buttonWyswietlWolnePokoje);
            this.Controls.Add(this.checkBoxCzyPosprzatany);
            this.Controls.Add(this.checkBoxCzyWolny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.dataGridViewPokoje);
            this.Controls.Add(this.textBoxIdPokoju);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLiczbaMiejsc);
            this.Controls.Add(this.textBoxNumer);
            this.Name = "PokojeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokoje";
            this.Load += new System.EventHandler(this.PokojeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokoje)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIdPokoju;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLiczbaMiejsc;
        private System.Windows.Forms.TextBox textBoxNumer;
        private System.Windows.Forms.DataGridView dataGridViewPokoje;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCzyWolny;
        private System.Windows.Forms.CheckBox checkBoxCzyPosprzatany;
        private System.Windows.Forms.Button buttonWyswietlWolnePokoje;
        private System.Windows.Forms.Button buttonWyswietlWszystkiePokoje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSzukajPokoju;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPokoju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaMiejsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaZaDobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyWolny;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyPosprzatany;
    }
}