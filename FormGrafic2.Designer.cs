
namespace Agentie_de_Turism___Proiect_PAW
{
    partial class FormGrafic2
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
            this.chartPreturi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPreturi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPreturi
            // 
            this.chartPreturi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartPreturi.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chartPreturi.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartPreturi.BackSecondaryColor = System.Drawing.Color.White;
            this.chartPreturi.BorderlineColor = System.Drawing.Color.Silver;
            this.chartPreturi.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chartPreturi.BorderlineWidth = 5;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartPreturi.ChartAreas.Add(chartArea1);
            this.chartPreturi.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.AutoFitMinFontSize = 10;
            legend1.BackColor = System.Drawing.Color.Turquoise;
            legend1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            legend1.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.chartPreturi.Legends.Add(legend1);
            this.chartPreturi.Location = new System.Drawing.Point(37, 28);
            this.chartPreturi.Name = "chartPreturi";
            this.chartPreturi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Lime;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.White;
            series1.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Lime;
            series1.LabelBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Preturi (€)";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowColor = System.Drawing.Color.White;
            series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series1.YValuesPerPoint = 2;
            this.chartPreturi.Series.Add(series1);
            this.chartPreturi.Size = new System.Drawing.Size(629, 402);
            this.chartPreturi.TabIndex = 0;
            this.chartPreturi.Text = "chart2";
            title1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Pret Mediu / Tip Cazare";
            title1.Text = "Pret Mediu / Tip Cazare";
            this.chartPreturi.Titles.Add(title1);
            // 
            // FormGrafic2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 454);
            this.Controls.Add(this.chartPreturi);
            this.Name = "FormGrafic2";
            this.Text = "Chart - Pret Mediu / Tip Cazare";
            this.Load += new System.EventHandler(this.FormGrafic2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPreturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPreturi;
    }
}