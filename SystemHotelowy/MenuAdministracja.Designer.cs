
namespace SystemHotelowy
{
    partial class MenuAdministracja
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
            this.buttonUzytkownicy = new System.Windows.Forms.Button();
            this.buttonStatystyki = new System.Windows.Forms.Button();
            this.buttonPracownicy = new System.Windows.Forms.Button();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUzytkownicy
            // 
            this.buttonUzytkownicy.BackColor = System.Drawing.Color.Teal;
            this.buttonUzytkownicy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUzytkownicy.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.buttonUzytkownicy.ForeColor = System.Drawing.Color.White;
            this.buttonUzytkownicy.Location = new System.Drawing.Point(506, 265);
            this.buttonUzytkownicy.Name = "buttonUzytkownicy";
            this.buttonUzytkownicy.Size = new System.Drawing.Size(250, 250);
            this.buttonUzytkownicy.TabIndex = 2;
            this.buttonUzytkownicy.Text = "Użytkownicy";
            this.buttonUzytkownicy.UseVisualStyleBackColor = false;
            this.buttonUzytkownicy.Click += new System.EventHandler(this.buttonUzytkownicy_Click);
            // 
            // buttonStatystyki
            // 
            this.buttonStatystyki.BackColor = System.Drawing.Color.Teal;
            this.buttonStatystyki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatystyki.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.buttonStatystyki.ForeColor = System.Drawing.Color.White;
            this.buttonStatystyki.Location = new System.Drawing.Point(884, 265);
            this.buttonStatystyki.Name = "buttonStatystyki";
            this.buttonStatystyki.Size = new System.Drawing.Size(250, 250);
            this.buttonStatystyki.TabIndex = 3;
            this.buttonStatystyki.Text = "Statystyki";
            this.buttonStatystyki.UseVisualStyleBackColor = false;
            this.buttonStatystyki.Click += new System.EventHandler(this.buttonStatystyki_Click);
            // 
            // buttonPracownicy
            // 
            this.buttonPracownicy.BackColor = System.Drawing.Color.Teal;
            this.buttonPracownicy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPracownicy.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.buttonPracownicy.ForeColor = System.Drawing.Color.White;
            this.buttonPracownicy.Location = new System.Drawing.Point(128, 265);
            this.buttonPracownicy.Name = "buttonPracownicy";
            this.buttonPracownicy.Size = new System.Drawing.Size(250, 250);
            this.buttonPracownicy.TabIndex = 91;
            this.buttonPracownicy.Text = "Pracownicy";
            this.buttonPracownicy.UseVisualStyleBackColor = false;
            this.buttonPracownicy.Click += new System.EventHandler(this.buttonPracownicy_Click);
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
            this.panelTytulowy.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(457, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(351, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "MENU ADMINISTRACJA";
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
            // MenuAdministracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.buttonPracownicy);
            this.Controls.Add(this.buttonStatystyki);
            this.Controls.Add(this.buttonUzytkownicy);
            this.Name = "MenuAdministracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracja - menu";
            this.Load += new System.EventHandler(this.MenuAdministracja_Load);
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUzytkownicy;
        private System.Windows.Forms.Button buttonStatystyki;
        private System.Windows.Forms.Button buttonPracownicy;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
    }
}