
namespace SystemHotelowy
{
    partial class UzytkownicyForm
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
            this.dataGridViewUzytkownicy = new System.Windows.Forms.DataGridView();
            this.IdUzytkownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haslo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIdUzytkownika = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxIdPracownika = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonSzukajPracownika = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNrTel = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUzytkownicy
            // 
            this.dataGridViewUzytkownicy.AllowUserToDeleteRows = false;
            this.dataGridViewUzytkownicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUzytkownicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUzytkownicy.ColumnHeadersHeight = 37;
            this.dataGridViewUzytkownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUzytkownika,
            this.IdPracownika,
            this.Login,
            this.Haslo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUzytkownicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUzytkownicy.EnableHeadersVisualStyles = false;
            this.dataGridViewUzytkownicy.Location = new System.Drawing.Point(400, 140);
            this.dataGridViewUzytkownicy.Name = "dataGridViewUzytkownicy";
            this.dataGridViewUzytkownicy.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUzytkownicy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUzytkownicy.RowTemplate.Height = 30;
            this.dataGridViewUzytkownicy.Size = new System.Drawing.Size(825, 504);
            this.dataGridViewUzytkownicy.TabIndex = 87;
            this.dataGridViewUzytkownicy.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUzytkownicy_CellFormatting);
            this.dataGridViewUzytkownicy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewKlienci_MouseDoubleClick);
            // 
            // IdUzytkownika
            // 
            this.IdUzytkownika.DataPropertyName = "IdUzytkownika";
            this.IdUzytkownika.HeaderText = "ID Użytkownika";
            this.IdUzytkownika.Name = "IdUzytkownika";
            this.IdUzytkownika.ReadOnly = true;
            // 
            // IdPracownika
            // 
            this.IdPracownika.DataPropertyName = "IdPracownika";
            this.IdPracownika.HeaderText = "ID Pracownika";
            this.IdPracownika.Name = "IdPracownika";
            this.IdPracownika.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Haslo
            // 
            this.Haslo.DataPropertyName = "Haslo";
            this.Haslo.HeaderText = "Hasło";
            this.Haslo.Name = "Haslo";
            this.Haslo.ReadOnly = true;
            // 
            // textBoxIdUzytkownika
            // 
            this.textBoxIdUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdUzytkownika.Location = new System.Drawing.Point(214, 140);
            this.textBoxIdUzytkownika.Multiline = true;
            this.textBoxIdUzytkownika.Name = "textBoxIdUzytkownika";
            this.textBoxIdUzytkownika.Size = new System.Drawing.Size(163, 30);
            this.textBoxIdUzytkownika.TabIndex = 86;
            this.textBoxIdUzytkownika.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(31, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "Identyfikator użytkownika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(31, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Identyfikator pracownika:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLogin.Location = new System.Drawing.Point(214, 212);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(163, 30);
            this.textBoxLogin.TabIndex = 74;
            this.textBoxLogin.WordWrap = false;
            // 
            // textBoxIdPracownika
            // 
            this.textBoxIdPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdPracownika.Location = new System.Drawing.Point(214, 176);
            this.textBoxIdPracownika.Multiline = true;
            this.textBoxIdPracownika.Name = "textBoxIdPracownika";
            this.textBoxIdPracownika.Size = new System.Drawing.Size(163, 30);
            this.textBoxIdPracownika.TabIndex = 73;
            this.textBoxIdPracownika.WordWrap = false;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxHaslo.Location = new System.Drawing.Point(214, 248);
            this.textBoxHaslo.Multiline = true;
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(163, 30);
            this.textBoxHaslo.TabIndex = 72;
            this.textBoxHaslo.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Hasło:";
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
            this.label16.Location = new System.Drawing.Point(526, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(222, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "UŻYTKOWNICY";
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
            this.label14.Size = new System.Drawing.Size(196, 25);
            this.label14.TabIndex = 106;
            this.label14.Text = "Lista użytkowników";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 25);
            this.label15.TabIndex = 105;
            this.label15.Text = "Użytkownik";
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(302, 296);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 34);
            this.buttonAnuluj.TabIndex = 110;
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
            this.buttonUsun.Location = new System.Drawing.Point(209, 296);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 34);
            this.buttonUsun.TabIndex = 109;
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
            this.buttonDodaj.Location = new System.Drawing.Point(117, 296);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 34);
            this.buttonDodaj.TabIndex = 108;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonSzukajPracownika
            // 
            this.buttonSzukajPracownika.BackColor = System.Drawing.Color.Teal;
            this.buttonSzukajPracownika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSzukajPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSzukajPracownika.ForeColor = System.Drawing.Color.White;
            this.buttonSzukajPracownika.Location = new System.Drawing.Point(298, 496);
            this.buttonSzukajPracownika.Name = "buttonSzukajPracownika";
            this.buttonSzukajPracownika.Size = new System.Drawing.Size(75, 34);
            this.buttonSzukajPracownika.TabIndex = 160;
            this.buttonSzukajPracownika.Text = "Szukaj";
            this.buttonSzukajPracownika.UseVisualStyleBackColor = false;
            this.buttonSzukajPracownika.Click += new System.EventHandler(this.buttonSzukajPracownika_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(29, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(309, 25);
            this.label17.TabIndex = 159;
            this.label17.Text = "Znajdź identyfikator pracownika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(31, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 158;
            this.label5.Text = "Numer telefonu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(31, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 157;
            this.label13.Text = "Nazwisko:";
            // 
            // textBoxNrTel
            // 
            this.textBoxNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNrTel.Location = new System.Drawing.Point(207, 451);
            this.textBoxNrTel.Multiline = true;
            this.textBoxNrTel.Name = "textBoxNrTel";
            this.textBoxNrTel.Size = new System.Drawing.Size(166, 30);
            this.textBoxNrTel.TabIndex = 156;
            this.textBoxNrTel.WordWrap = false;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNazwisko.Location = new System.Drawing.Point(207, 415);
            this.textBoxNazwisko.Multiline = true;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(166, 30);
            this.textBoxNazwisko.TabIndex = 155;
            this.textBoxNazwisko.WordWrap = false;
            // 
            // UzytkownicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSzukajPracownika);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxNrTel);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridViewUzytkownicy);
            this.Controls.Add(this.textBoxIdUzytkownika);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxIdPracownika);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.label1);
            this.Name = "UzytkownicyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Użytkownicy";
            this.Load += new System.EventHandler(this.UzytkownicyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUzytkownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haslo;
        private System.Windows.Forms.TextBox textBoxIdUzytkownika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxIdPracownika;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonSzukajPracownika;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNrTel;
        private System.Windows.Forms.TextBox textBoxNazwisko;
    }
}