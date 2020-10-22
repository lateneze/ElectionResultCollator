using System.Data;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCon = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonModifyResult = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.resultfkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paliamentaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetAllResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDBDataSet = new DemoCol.ElectionDBDataSet();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.chartPresidential = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartParliament = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spGet_All_ResultTableAdapter = new DemoCol.ElectionDBDataSetTableAdapters.spGet_All_ResultTableAdapter();
            this.spGetParliamentaryResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGet_Parliamentary_ResultsTableAdapter = new DemoCol.ElectionDBDataSetTableAdapters.spGet_Parliamentary_ResultsTableAdapter();
            this.spGetPresidentialResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGet_Presidential_ResultsTableAdapter = new DemoCol.ElectionDBDataSetTableAdapters.spGet_Presidential_ResultsTableAdapter();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDBDataSet)).BeginInit();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresidential)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParliament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetParliamentaryResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPresidentialResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonLoad);
            this.panelHeader.Controls.Add(this.buttonCon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(1091, 18);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(126, 39);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(12, 12);
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
            this.dataGridResults.AutoGenerateColumns = false;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultfkIDDataGridViewTextBoxColumn,
            this.paliamentaryDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.presidentialDataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn});
            this.dataGridResults.DataSource = this.spGetAllResultBindingSource;
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(0, 85);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.RowHeadersWidth = 51;
            this.dataGridResults.RowTemplate.Height = 24;
            this.dataGridResults.Size = new System.Drawing.Size(1350, 599);
            this.dataGridResults.TabIndex = 2;
            // 
            // resultfkIDDataGridViewTextBoxColumn
            // 
            this.resultfkIDDataGridViewTextBoxColumn.DataPropertyName = "result_fk_ID";
            this.resultfkIDDataGridViewTextBoxColumn.HeaderText = "result_fk_ID";
            this.resultfkIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultfkIDDataGridViewTextBoxColumn.Name = "resultfkIDDataGridViewTextBoxColumn";
            this.resultfkIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // paliamentaryDataGridViewTextBoxColumn
            // 
            this.paliamentaryDataGridViewTextBoxColumn.DataPropertyName = "paliamentary";
            this.paliamentaryDataGridViewTextBoxColumn.HeaderText = "NPP Paliamentary";
            this.paliamentaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paliamentaryDataGridViewTextBoxColumn.Name = "paliamentaryDataGridViewTextBoxColumn";
            this.paliamentaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "NDC Paliamentary";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // presidentialDataGridViewTextBoxColumn
            // 
            this.presidentialDataGridViewTextBoxColumn.DataPropertyName = "presidential";
            this.presidentialDataGridViewTextBoxColumn.HeaderText = "NPP Presidential";
            this.presidentialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presidentialDataGridViewTextBoxColumn.Name = "presidentialDataGridViewTextBoxColumn";
            this.presidentialDataGridViewTextBoxColumn.Width = 125;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "NDC Presidential";
            this.expr2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.Width = 125;
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
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.chartPresidential);
            this.panelCharts.Controls.Add(this.chartParliament);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCharts.Location = new System.Drawing.Point(764, 85);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(586, 599);
            this.panelCharts.TabIndex = 3;
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
            // ResultComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 736);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "ResultComp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDBDataSet)).EndInit();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPresidential)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParliament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetParliamentaryResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPresidentialResultsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn resultfkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paliamentaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonModifyResult;
    }
}

