
namespace SystemHotelowy
{
    partial class PrzychodyZaWszystkoForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonWyswietl = new System.Windows.Forms.Button();
            this.comboBoxRok = new System.Windows.Forms.ComboBox();
            this.chartPrzychodyZaWszystko = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTytulowy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelZalogowany = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrzychodyZaWszystko)).BeginInit();
            this.panelTytulowy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWyswietl
            // 
            this.buttonWyswietl.BackColor = System.Drawing.Color.Teal;
            this.buttonWyswietl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonWyswietl.ForeColor = System.Drawing.Color.White;
            this.buttonWyswietl.Location = new System.Drawing.Point(301, 97);
            this.buttonWyswietl.Name = "buttonWyswietl";
            this.buttonWyswietl.Size = new System.Drawing.Size(75, 34);
            this.buttonWyswietl.TabIndex = 106;
            this.buttonWyswietl.Text = "Wyświetl";
            this.buttonWyswietl.UseVisualStyleBackColor = false;
            this.buttonWyswietl.Click += new System.EventHandler(this.buttonWyswietl_Click);
            // 
            // comboBoxRok
            // 
            this.comboBoxRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxRok.FormattingEnabled = true;
            this.comboBoxRok.Location = new System.Drawing.Point(162, 101);
            this.comboBoxRok.Name = "comboBoxRok";
            this.comboBoxRok.Size = new System.Drawing.Size(121, 26);
            this.comboBoxRok.TabIndex = 105;
            // 
            // chartPrzychodyZaWszystko
            // 
            chartArea1.AxisX.Title = "Miesiąc";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Suma wszystkich przychodów";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            chartArea1.Name = "ChartArea1";
            this.chartPrzychodyZaWszystko.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrzychodyZaWszystko.Legends.Add(legend1);
            this.chartPrzychodyZaWszystko.Location = new System.Drawing.Point(34, 150);
            this.chartPrzychodyZaWszystko.Name = "chartPrzychodyZaWszystko";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Coral;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Przychody całkowite";
            this.chartPrzychodyZaWszystko.Series.Add(series1);
            this.chartPrzychodyZaWszystko.Size = new System.Drawing.Size(1192, 503);
            this.chartPrzychodyZaWszystko.TabIndex = 104;
            this.chartPrzychodyZaWszystko.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Wykres wszystkich przychodów za pobyty, dania i usługi";
            this.chartPrzychodyZaWszystko.Titles.Add(title1);
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
            this.panelTytulowy.TabIndex = 109;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(446, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(373, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "PRZYCHODY CAŁKOWITE";
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
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 25);
            this.label15.TabIndex = 110;
            this.label15.Text = "Wybierz rok:";
            // 
            // PrzychodyZaWszystkoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panelTytulowy);
            this.Controls.Add(this.buttonWyswietl);
            this.Controls.Add(this.comboBoxRok);
            this.Controls.Add(this.chartPrzychodyZaWszystko);
            this.Name = "PrzychodyZaWszystkoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przychody całkowite";
            this.Load += new System.EventHandler(this.PrzychodyZaWszystkoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrzychodyZaWszystko)).EndInit();
            this.panelTytulowy.ResumeLayout(false);
            this.panelTytulowy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWyswietl;
        private System.Windows.Forms.ComboBox comboBoxRok;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrzychodyZaWszystko;
        private System.Windows.Forms.Panel panelTytulowy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelZalogowany;
        private System.Windows.Forms.Label label15;
    }
}