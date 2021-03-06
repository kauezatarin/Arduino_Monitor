﻿namespace Arduino_Monitor
{
    partial class Graphic_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphic_form));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Gray;
            chartArea1.AlignWithChartArea = "ChartArea2";
            chartArea1.AxisX.Title = "Intervalo";
            chartArea1.AxisY.Title = "Valores";
            chartArea1.Name = "ChartArea1";
            chartArea2.AlignWithChartArea = "ChartArea3";
            chartArea2.AxisX.Title = "Intervalo";
            chartArea2.AxisY.Title = "Valores";
            chartArea2.Name = "ChartArea2";
            chartArea3.AlignWithChartArea = "ChartArea1";
            chartArea3.AxisX.Title = "Intervalo";
            chartArea3.AxisY.Title = "Valores";
            chartArea3.Name = "ChartArea3";
            chartArea4.AlignWithChartArea = "ChartArea5";
            chartArea4.AxisX.Title = "Intervalo";
            chartArea4.AxisY.Title = "Valores";
            chartArea4.Name = "ChartArea4";
            chartArea5.AlignWithChartArea = "ChartArea4";
            chartArea5.AxisX.Title = "Intervalo";
            chartArea5.AxisY.Title = "Valores";
            chartArea5.Name = "ChartArea5";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.ChartAreas.Add(chartArea5);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderColor = System.Drawing.Color.Yellow;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Indigo;
            series1.Legend = "Legend1";
            series1.Name = "Field1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.BorderColor = System.Drawing.Color.Yellow;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Indigo;
            series2.Legend = "Legend1";
            series2.Name = "Field2";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.BorderColor = System.Drawing.Color.Yellow;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Indigo;
            series3.Legend = "Legend1";
            series3.Name = "Field3";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.BorderColor = System.Drawing.Color.Yellow;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea4";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Indigo;
            series4.Legend = "Legend1";
            series4.Name = "Field4";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.BorderColor = System.Drawing.Color.Yellow;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea5";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.Indigo;
            series5.Legend = "Legend1";
            series5.Name = "Field5";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1017, 448);
            this.chart1.TabIndex = 20;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.DockedToChartArea = "ChartArea1";
            title1.DockingOffset = -4;
            title1.Name = "Title1";
            title1.Text = "Field 1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.DockedToChartArea = "ChartArea2";
            title2.DockingOffset = -4;
            title2.Name = "Title2";
            title2.Text = "Field 2";
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.DockedToChartArea = "ChartArea3";
            title3.DockingOffset = -4;
            title3.Name = "Title3";
            title3.Text = "Field 3";
            title4.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title4.DockedToChartArea = "ChartArea4";
            title4.DockingOffset = -4;
            title4.Name = "Title4";
            title4.Text = "Field 4";
            title5.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title5.DockedToChartArea = "ChartArea5";
            title5.DockingOffset = -4;
            title5.Name = "Title5";
            title5.Text = "Field 5";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            this.chart1.Titles.Add(title4);
            this.chart1.Titles.Add(title5);
            // 
            // Graphic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 446);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graphic_form";
            this.Text = "Plotter";
            this.Load += new System.EventHandler(this.Graphic_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}