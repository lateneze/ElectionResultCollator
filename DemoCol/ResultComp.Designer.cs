using System.Data;
using System.Windows.Forms;

namespace DemoCol
{
    partial class ResultComp
    {

        public DataTable parliamentaryData = null;
        public DataTable presidentialData = null;
        public DataTable gridData = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCon = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonModifyResult = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.chartPresidential = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartParliament = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spGetAllResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDBDataSet = new DemoCol.ElectionDBDataSet();
            this.spGet_All_ResultTableAdapter = new DemoCol.ElectionDBDataSetTableAdapters.spGet_All_ResultTableAdapter();
            this.spGetParliamentaryResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGet_Parliamentary_ResultsTableAdapter = new DemoCol.ElectionDBDataSetTableAdapters.spGet_Parliamentary_ResultsTableAdapter();
            this.spGetPresidentialResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGet_Presidential_ResultsTableAdapter = new DemoCol.ElectionDBDataSetTableAdapters.spGet_Presidential_ResultsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresidential)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParliament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetParliamentaryResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPresidentialResultsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeight);
            this.panelHeader.Controls.Add(this.labelWidth);
            this.panelHeader.Controls.Add(this.buttonLoad);
            this.panelHeader.Controls.Add(this.buttonCon);
            this.panelHeader.Controls.Add(this.menuStrip1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 104);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(517, 67);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(46, 17);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "label1";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWidth.Location = new System.Drawing.Point(520, 48);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(42, 19);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "width";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(1105, 44);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(126, 39);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(12, 44);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(100, 23);
            this.buttonCon.TabIndex = 0;
            this.buttonCon.Text = "CONNECT";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonModifyResult);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 684);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1350, 52);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonModifyResult
            // 
            this.buttonModifyResult.Location = new System.Drawing.Point(12, 6);
            this.buttonModifyResult.Name = "buttonModifyResult";
            this.buttonModifyResult.Size = new System.Drawing.Size(117, 38);
            this.buttonModifyResult.TabIndex = 0;
            this.buttonModifyResult.Text = "Modify";
            this.buttonModifyResult.UseVisualStyleBackColor = true;
            this.buttonModifyResult.Click += new System.EventHandler(this.buttonModifyResult_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridResults.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridResults.Location = new System.Drawing.Point(0, 104);
            this.dataGridResults.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.RowHeadersWidth = 51;
            this.dataGridResults.RowTemplate.Height = 24;
            this.dataGridResults.Size = new System.Drawing.Size(894, 580);
            this.dataGridResults.TabIndex = 2;
            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.chartPresidential);
            this.panelCharts.Controls.Add(this.chartParliament);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCharts.Location = new System.Drawing.Point(915, 104);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(435, 580);
            this.panelCharts.TabIndex = 3;
            // 
            // chartPresidential
            // 
            this.chartPresidential.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 5.597563F;
            this.chartPresidential.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chartPresidential.Legends.Add(legend1);
            this.chartPresidential.Location = new System.Drawing.Point(34, 335);
            this.chartPresidential.Name = "chartPresidential";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.LegendText = "#VALX";
            series1.Name = "SeriesPresidential";
            this.chartPresidential.Series.Add(series1);
            this.chartPresidential.Size = new System.Drawing.Size(341, 255);
            this.chartPresidential.TabIndex = 1;
            this.chartPresidential.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Name = "Title1";
            title1.Text = "Presidential Result";
            this.chartPresidential.Titles.Add(title1);
            // 
            // chartParliament
            // 
            this.chartParliament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 88.32358F;
            chartArea2.Position.Width = 80.58823F;
            chartArea2.Position.X = 19.41177F;
            chartArea2.Position.Y = 11.67642F;
            this.chartParliament.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chartParliament.Legends.Add(legend2);
            this.chartParliament.Location = new System.Drawing.Point(34, 31);
            this.chartParliament.Name = "chartParliament";
            this.chartParliament.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Label = "#PERCENT";
            series2.Legend = "Legend1";
            series2.LegendText = "#VALX (#VAL)";
            series2.Name = "SeriesParliament";
            this.chartParliament.Series.Add(series2);
            this.chartParliament.Size = new System.Drawing.Size(341, 252);
            this.chartParliament.TabIndex = 0;
            this.chartParliament.Text = "Parliamentary";
            title2.Name = "Title1";
            title2.Text = "Parliamentary Result";
            this.chartParliament.Titles.Add(title2);
            // 
            // spGetAllResultBindingSource
            // 
            this.spGetAllResultBindingSource.DataMember = "spGet_All_Result";
            this.spGetAllResultBindingSource.DataSource = this.electionDBDataSet;
            // 
            // electionDBDataSet
            // 
            this.electionDBDataSet.DataSetName = "ElectionDBDataSet";
            this.electionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGet_All_ResultTableAdapter
            // 
            this.spGet_All_ResultTableAdapter.ClearBeforeFill = true;
            // 
            // spGetParliamentaryResultsBindingSource
            // 
            this.spGetParliamentaryResultsBindingSource.DataMember = "spGet_Parliamentary_Results";
            this.spGetParliamentaryResultsBindingSource.DataSource = this.electionDBDataSet;
            // 
            // spGet_Parliamentary_ResultsTableAdapter
            // 
            this.spGet_Parliamentary_ResultsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetPresidentialResultsBindingSource
            // 
            this.spGetPresidentialResultsBindingSource.DataMember = "spGet_Presidential_Results";
            this.spGetPresidentialResultsBindingSource.DataSource = this.electionDBDataSet;
            // 
            // spGet_Presidential_ResultsTableAdapter
            // 
            this.spGet_Presidential_ResultsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ResultComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 736);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ResultComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NKWANTA NORTH ELECTION RESULT COLLATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.ResultComp_SizeChanged);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPresidential)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParliament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetParliamentaryResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPresidentialResultsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPresidential;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartParliament;
        private ElectionDBDataSet electionDBDataSet;
        private System.Windows.Forms.BindingSource spGetAllResultBindingSource;
        private ElectionDBDataSetTableAdapters.spGet_All_ResultTableAdapter spGet_All_ResultTableAdapter;
        private System.Windows.Forms.BindingSource spGetParliamentaryResultsBindingSource;
        private ElectionDBDataSetTableAdapters.spGet_Parliamentary_ResultsTableAdapter spGet_Parliamentary_ResultsTableAdapter;
        private System.Windows.Forms.BindingSource spGetPresidentialResultsBindingSource;
        private ElectionDBDataSetTableAdapters.spGet_Presidential_ResultsTableAdapter spGet_Presidential_ResultsTableAdapter;
        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonModifyResult;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}

