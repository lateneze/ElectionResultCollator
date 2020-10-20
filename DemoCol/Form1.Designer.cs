namespace DemoCol
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.chartParliament = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPresidential = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartParliament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresidential)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 705);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1350, 31);
            this.panelFooter.TabIndex = 1;
            // 
            // dataGridResults
            // 
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(0, 85);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.RowHeadersWidth = 51;
            this.dataGridResults.RowTemplate.Height = 24;
            this.dataGridResults.Size = new System.Drawing.Size(1350, 620);
            this.dataGridResults.TabIndex = 2;
            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.chartPresidential);
            this.panelCharts.Controls.Add(this.chartParliament);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCharts.Location = new System.Drawing.Point(810, 85);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(540, 620);
            this.panelCharts.TabIndex = 3;
            // 
            // chartParliament
            // 
            chartArea2.Name = "ChartArea1";
            this.chartParliament.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartParliament.Legends.Add(legend2);
            this.chartParliament.Location = new System.Drawing.Point(111, 35);
            this.chartParliament.Name = "chartParliament";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "SeriesParliament";
            this.chartParliament.Series.Add(series2);
            this.chartParliament.Size = new System.Drawing.Size(341, 252);
            this.chartParliament.TabIndex = 0;
            this.chartParliament.Text = "chart1";
            // 
            // chartPresidential
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPresidential.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPresidential.Legends.Add(legend1);
            this.chartPresidential.Location = new System.Drawing.Point(111, 338);
            this.chartPresidential.Name = "chartPresidential";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SeriesPresidential";
            this.chartPresidential.Series.Add(series1);
            this.chartPresidential.Size = new System.Drawing.Size(341, 255);
            this.chartPresidential.TabIndex = 1;
            this.chartPresidential.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 736);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartParliament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresidential)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPresidential;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartParliament;
    }
}

