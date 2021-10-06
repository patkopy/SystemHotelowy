
namespace SystemHotelowy
{
    partial class MenuGastronomia
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
            this.buttonDania = new System.Windows.Forms.Button();
            this.buttonRachunkiZaDania = new System.Windows.Forms.Button();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDania
            // 
            this.buttonDania.BackColor = System.Drawing.Color.Teal;
            this.buttonDania.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDania.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.buttonDania.ForeColor = System.Drawing.Color.White;
            this.buttonDania.Location = new System.Drawing.Point(260, 265);
            this.buttonDania.Name = "buttonDania";
            this.buttonDania.Size = new System.Drawing.Size(250, 250);
            this.buttonDania.TabIndex = 1;
            this.buttonDania.Text = "Dania";
            this.buttonDania.UseVisualStyleBackColor = false;
            this.buttonDania.Click += new System.EventHandler(this.buttonDania_Click);
            // 
            // buttonRachunkiZaDania
            // 
            this.buttonRachunkiZaDania.BackColor = System.Drawing.Color.Teal;
            this.buttonRachunkiZaDania.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRachunkiZaDania.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.buttonRachunkiZaDania.ForeColor = System.Drawing.Color.White;
            this.buttonRachunkiZaDania.Location = new System.Drawing.Point(770, 265);
            this.buttonRachunkiZaDania.Name = "buttonRachunkiZaDania";
            this.buttonRachunkiZaDania.Size = new System.Drawing.Size(250, 250);
            this.buttonRachunkiZaDania.TabIndex = 3;
            this.buttonRachunkiZaDania.Text = "Rachunki za dania";
            this.buttonRachunkiZaDania.UseVisualStyleBackColor = false;
            this.buttonRachunkiZaDania.Click += new System.EventHandler(this.buttonRachunkiZaDania_Click);
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
            this.panelTytulowy.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(462, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(328, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "MENU GASTRONOMIA";
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
            // MenuGastronomia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.buttonRachunkiZaDania);
            this.Controls.Add(this.buttonDania);
            this.Name = "MenuGastronomia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastronomia - menu";
            this.Load += new System.EventHandler(this.MenuGastronomia_Load);
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDania;
        private System.Windows.Forms.Button buttonRachunkiZaDania;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
    }
}