
namespace SystemHotelowy
{
    partial class MenuGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRecepcja = new System.Windows.Forms.Button();
            this.buttonGastronomia = new System.Windows.Forms.Button();
            this.buttonAdministracja = new System.Windows.Forms.Button();
            this.buttonSprzatanie = new System.Windows.Forms.Button();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRecepcja
            // 
            this.buttonRecepcja.BackColor = System.Drawing.Color.Teal;
            this.buttonRecepcja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecepcja.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRecepcja.ForeColor = System.Drawing.Color.White;
            this.buttonRecepcja.Location = new System.Drawing.Point(52, 265);
            this.buttonRecepcja.Name = "buttonRecepcja";
            this.buttonRecepcja.Size = new System.Drawing.Size(250, 250);
            this.buttonRecepcja.TabIndex = 0;
            this.buttonRecepcja.Text = "Recepcja";
            this.buttonRecepcja.UseVisualStyleBackColor = false;
            this.buttonRecepcja.Click += new System.EventHandler(this.buttonRecepcja_Click);
            // 
            // buttonGastronomia
            // 
            this.buttonGastronomia.BackColor = System.Drawing.Color.Teal;
            this.buttonGastronomia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGastronomia.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGastronomia.ForeColor = System.Drawing.Color.White;
            this.buttonGastronomia.Location = new System.Drawing.Point(354, 265);
            this.buttonGastronomia.Name = "buttonGastronomia";
            this.buttonGastronomia.Size = new System.Drawing.Size(250, 250);
            this.buttonGastronomia.TabIndex = 1;
            this.buttonGastronomia.Text = "Gastronomia";
            this.buttonGastronomia.UseVisualStyleBackColor = false;
            this.buttonGastronomia.Click += new System.EventHandler(this.buttonGastronomia_Click);
            // 
            // buttonAdministracja
            // 
            this.buttonAdministracja.BackColor = System.Drawing.Color.Teal;
            this.buttonAdministracja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdministracja.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdministracja.ForeColor = System.Drawing.Color.White;
            this.buttonAdministracja.Location = new System.Drawing.Point(958, 265);
            this.buttonAdministracja.Name = "buttonAdministracja";
            this.buttonAdministracja.Size = new System.Drawing.Size(250, 250);
            this.buttonAdministracja.TabIndex = 2;
            this.buttonAdministracja.Text = "Administracja";
            this.buttonAdministracja.UseVisualStyleBackColor = false;
            this.buttonAdministracja.Click += new System.EventHandler(this.buttonAdministracja_Click);
            // 
            // buttonSprzatanie
            // 
            this.buttonSprzatanie.BackColor = System.Drawing.Color.Teal;
            this.buttonSprzatanie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSprzatanie.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSprzatanie.ForeColor = System.Drawing.Color.White;
            this.buttonSprzatanie.Location = new System.Drawing.Point(656, 265);
            this.buttonSprzatanie.Name = "buttonSprzatanie";
            this.buttonSprzatanie.Size = new System.Drawing.Size(250, 250);
            this.buttonSprzatanie.TabIndex = 6;
            this.buttonSprzatanie.Text = "Sprzątanie";
            this.buttonSprzatanie.UseVisualStyleBackColor = false;
            this.buttonSprzatanie.Click += new System.EventHandler(this.buttonSprzatanie_Click);
            // 
            // panelTytulowy
            // 
            this.panelTytulowy.BackColor = System.Drawing.Color.Teal;
            this.panelTytulowy.Controls.Add(this.label1);
            this.panelTytulowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytulowy.Location = new System.Drawing.Point(0, 0);
            this.panelTytulowy.Name = "panelTytulowy";
            this.panelTytulowy.Size = new System.Drawing.Size(1264, 80);
            this.panelTytulowy.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYSTEM WSPOMAGAJĄCY OBSŁUGĘ GOŚCI HOTELOWYCH";
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.buttonSprzatanie);
            this.Controls.Add(this.buttonAdministracja);
            this.Controls.Add(this.buttonGastronomia);
            this.Controls.Add(this.buttonRecepcja);
            this.Name = "MenuGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System wspomagający obsługę gości hotelowych";
            this.Load += new System.EventHandler(this.MenuGlowne_Load);
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecepcja;
        private System.Windows.Forms.Button buttonGastronomia;
        private System.Windows.Forms.Button buttonAdministracja;
        private System.Windows.Forms.Button buttonSprzatanie;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label1;
    }
}

