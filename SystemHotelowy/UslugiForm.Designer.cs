
namespace SystemHotelowy
{
    partial class UslugiForm
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
            this.dataGridViewUslugi = new System.Windows.Forms.DataGridView();
            this.IdUslugi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIdUslugi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUslugi)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUslugi
            // 
            this.dataGridViewUslugi.AllowUserToDeleteRows = false;
            this.dataGridViewUslugi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUslugi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUslugi.ColumnHeadersHeight = 37;
            this.dataGridViewUslugi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUslugi,
            this.Nazwa,
            this.Cena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUslugi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUslugi.EnableHeadersVisualStyles = false;
            this.dataGridViewUslugi.Location = new System.Drawing.Point(400, 140);
            this.dataGridViewUslugi.Name = "dataGridViewUslugi";
            this.dataGridViewUslugi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUslugi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUslugi.RowTemplate.Height = 30;
            this.dataGridViewUslugi.Size = new System.Drawing.Size(825, 488);
            this.dataGridViewUslugi.TabIndex = 87;
            this.dataGridViewUslugi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUslugi_MouseDoubleClick);
            // 
            // IdUslugi
            // 
            this.IdUslugi.DataPropertyName = "IdUslugi";
            this.IdUslugi.HeaderText = "ID Usługi";
            this.IdUslugi.Name = "IdUslugi";
            this.IdUslugi.ReadOnly = true;
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
            // textBoxIdUslugi
            // 
            this.textBoxIdUslugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIdUslugi.Location = new System.Drawing.Point(170, 140);
            this.textBoxIdUslugi.Multiline = true;
            this.textBoxIdUslugi.Name = "textBoxIdUslugi";
            this.textBoxIdUslugi.Size = new System.Drawing.Size(202, 30);
            this.textBoxIdUslugi.TabIndex = 86;
            this.textBoxIdUslugi.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(31, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "Identyfikator usługi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(31, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nazwa:";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCena.Location = new System.Drawing.Point(170, 212);
            this.textBoxCena.Multiline = true;
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(202, 30);
            this.textBoxCena.TabIndex = 74;
            this.textBoxCena.WordWrap = false;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNazwa.Location = new System.Drawing.Point(169, 176);
            this.textBoxNazwa.Multiline = true;
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(202, 30);
            this.textBoxNazwa.TabIndex = 73;
            this.textBoxNazwa.WordWrap = false;
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
            this.label16.Location = new System.Drawing.Point(564, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "USŁUGI";
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
            this.label14.Size = new System.Drawing.Size(116, 25);
            this.label14.TabIndex = 106;
            this.label14.Text = "Lista usług";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 25);
            this.label15.TabIndex = 105;
            this.label15.Text = "Usługa";
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.Color.Teal;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnuluj.ForeColor = System.Drawing.Color.White;
            this.buttonAnuluj.Location = new System.Drawing.Point(296, 260);
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
            this.buttonUsun.Location = new System.Drawing.Point(203, 260);
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
            this.buttonDodaj.Location = new System.Drawing.Point(111, 260);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 34);
            this.buttonDodaj.TabIndex = 108;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // UslugiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridViewUslugi);
            this.Controls.Add(this.textBoxIdUslugi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxNazwa);
            this.Name = "UslugiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usługi";
            this.Load += new System.EventHandler(this.UslugiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUslugi)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUslugi;
        private System.Windows.Forms.TextBox textBoxIdUslugi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUslugi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
    }
}