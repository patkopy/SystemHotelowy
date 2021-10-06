
namespace SystemHotelowy
{
    partial class SprzatanieForm
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
            this.checkBoxCzyPosprzatany = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewPokoje = new System.Windows.Forms.DataGridView();
            this.IdPokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiczbaMiejsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyWolny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyPosprzatany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumer = new System.Windows.Forms.TextBox();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonAktualizuj = new System.Windows.Forms.Button();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokoje)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxCzyPosprzatany
            // 
            this.checkBoxCzyPosprzatany.AutoSize = true;
            this.checkBoxCzyPosprzatany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxCzyPosprzatany.Location = new System.Drawing.Point(151, 178);
            this.checkBoxCzyPosprzatany.Name = "checkBoxCzyPosprzatany";
            this.checkBoxCzyPosprzatany.Size = new System.Drawing.Size(110, 22);
            this.checkBoxCzyPosprzatany.TabIndex = 128;
            this.checkBoxCzyPosprzatany.Text = "Posprzątany";
            this.checkBoxCzyPosprzatany.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(31, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 126;
            this.label5.Text = "Stan sprzątania:";
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
            this.dataGridViewPokoje.ColumnHeadersHeight = 37;
            this.dataGridViewPokoje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPokoju,
            this.Numer,
            this.LiczbaMiejsc,
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
            this.dataGridViewPokoje.TabIndex = 121;
            this.dataGridViewPokoje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPokoje_MouseDoubleClick);
            // 
            // IdPokoju
            // 
            this.IdPokoju.DataPropertyName = "IdPokoju";
            this.IdPokoju.HeaderText = "IdPokoju";
            this.IdPokoju.Name = "IdPokoju";
            this.IdPokoju.ReadOnly = true;
            this.IdPokoju.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 116;
            this.label2.Text = "Numer:";
            // 
            // textBoxNumer
            // 
            this.textBoxNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNumer.Location = new System.Drawing.Point(151, 140);
            this.textBoxNumer.Multiline = true;
            this.textBoxNumer.Name = "textBoxNumer";
            this.textBoxNumer.Size = new System.Drawing.Size(225, 30);
            this.textBoxNumer.TabIndex = 114;
            this.textBoxNumer.WordWrap = false;
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(301, 212);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 34);
            this.buttonAnuluj.TabIndex = 113;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = false;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonAktualizuj
            // 
            this.buttonAktualizuj.BackColor = System.Drawing.Color.Teal;
            this.buttonAktualizuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAktualizuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAktualizuj.ForeColor = System.Drawing.Color.White;
            this.buttonAktualizuj.Location = new System.Drawing.Point(208, 212);
            this.buttonAktualizuj.Name = "buttonAktualizuj";
            this.buttonAktualizuj.Size = new System.Drawing.Size(75, 34);
            this.buttonAktualizuj.TabIndex = 111;
            this.buttonAktualizuj.Text = "Aktualizuj";
            this.buttonAktualizuj.UseVisualStyleBackColor = false;
            this.buttonAktualizuj.Click += new System.EventHandler(this.buttonAktualizuj_Click);
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
            this.panelTytulowy.TabIndex = 131;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(530, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "SPRZĄTANIE";
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
            this.label14.Size = new System.Drawing.Size(141, 25);
            this.label14.TabIndex = 130;
            this.label14.Text = "Lista pokojów";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 25);
            this.label15.TabIndex = 129;
            this.label15.Text = "Pokój";
            // 
            // SprzatanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkBoxCzyPosprzatany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewPokoje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumer);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonAktualizuj);
            this.Name = "SprzatanieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprzątanie";
            this.Load += new System.EventHandler(this.SprzatanieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokoje)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCzyPosprzatany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewPokoje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumer;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonAktualizuj;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPokoju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaMiejsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyWolny;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyPosprzatany;
    }
}