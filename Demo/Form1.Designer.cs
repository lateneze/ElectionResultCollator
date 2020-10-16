namespace Demo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rCDataSet = new Demo.RCDataSet();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new Demo.RCDataSetTableAdapters.ResultsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollingAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPPpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDCpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPPprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDCprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPPpaPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDCpaPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pollingAgentDataGridViewTextBoxColumn,
            this.nPPpaDataGridViewTextBoxColumn,
            this.nDCpaDataGridViewTextBoxColumn,
            this.nPPprDataGridViewTextBoxColumn,
            this.nDCprDataGridViewTextBoxColumn,
            this.paTotalDataGridViewTextBoxColumn,
            this.prTotalDataGridViewTextBoxColumn,
            this.nPPpaPercentDataGridViewTextBoxColumn,
            this.nDCpaPercentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // rCDataSet
            // 
            this.rCDataSet.DataSetName = "RCDataSet";
            this.rCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.rCDataSet;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pollingAgentDataGridViewTextBoxColumn
            // 
            this.pollingAgentDataGridViewTextBoxColumn.DataPropertyName = "pollingAgent";
            this.pollingAgentDataGridViewTextBoxColumn.HeaderText = "pollingAgent";
            this.pollingAgentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pollingAgentDataGridViewTextBoxColumn.Name = "pollingAgentDataGridViewTextBoxColumn";
            this.pollingAgentDataGridViewTextBoxColumn.Width = 125;
            // 
            // nPPpaDataGridViewTextBoxColumn
            // 
            this.nPPpaDataGridViewTextBoxColumn.DataPropertyName = "NPP_pa";
            this.nPPpaDataGridViewTextBoxColumn.HeaderText = "NPP_pa";
            this.nPPpaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nPPpaDataGridViewTextBoxColumn.Name = "nPPpaDataGridViewTextBoxColumn";
            this.nPPpaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nDCpaDataGridViewTextBoxColumn
            // 
            this.nDCpaDataGridViewTextBoxColumn.DataPropertyName = "NDC_pa";
            this.nDCpaDataGridViewTextBoxColumn.HeaderText = "NDC_pa";
            this.nDCpaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nDCpaDataGridViewTextBoxColumn.Name = "nDCpaDataGridViewTextBoxColumn";
            this.nDCpaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nPPprDataGridViewTextBoxColumn
            // 
            this.nPPprDataGridViewTextBoxColumn.DataPropertyName = "NPP_pr";
            this.nPPprDataGridViewTextBoxColumn.HeaderText = "NPP_pr";
            this.nPPprDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nPPprDataGridViewTextBoxColumn.Name = "nPPprDataGridViewTextBoxColumn";
            this.nPPprDataGridViewTextBoxColumn.Width = 125;
            // 
            // nDCprDataGridViewTextBoxColumn
            // 
            this.nDCprDataGridViewTextBoxColumn.DataPropertyName = "NDC_pr";
            this.nDCprDataGridViewTextBoxColumn.HeaderText = "NDC_pr";
            this.nDCprDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nDCprDataGridViewTextBoxColumn.Name = "nDCprDataGridViewTextBoxColumn";
            this.nDCprDataGridViewTextBoxColumn.Width = 125;
            // 
            // paTotalDataGridViewTextBoxColumn
            // 
            this.paTotalDataGridViewTextBoxColumn.DataPropertyName = "pa_Total";
            this.paTotalDataGridViewTextBoxColumn.HeaderText = "pa_Total";
            this.paTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paTotalDataGridViewTextBoxColumn.Name = "paTotalDataGridViewTextBoxColumn";
            this.paTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // prTotalDataGridViewTextBoxColumn
            // 
            this.prTotalDataGridViewTextBoxColumn.DataPropertyName = "pr_Total";
            this.prTotalDataGridViewTextBoxColumn.HeaderText = "pr_Total";
            this.prTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prTotalDataGridViewTextBoxColumn.Name = "prTotalDataGridViewTextBoxColumn";
            this.prTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // nPPpaPercentDataGridViewTextBoxColumn
            // 
            this.nPPpaPercentDataGridViewTextBoxColumn.DataPropertyName = "NPP_pa_Percent";
            this.nPPpaPercentDataGridViewTextBoxColumn.HeaderText = "NPP_pa_Percent";
            this.nPPpaPercentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nPPpaPercentDataGridViewTextBoxColumn.Name = "nPPpaPercentDataGridViewTextBoxColumn";
            this.nPPpaPercentDataGridViewTextBoxColumn.Width = 125;
            // 
            // nDCpaPercentDataGridViewTextBoxColumn
            // 
            this.nDCpaPercentDataGridViewTextBoxColumn.DataPropertyName = "NDC_pa_Percent";
            this.nDCpaPercentDataGridViewTextBoxColumn.HeaderText = "NDC_pa_Percent";
            this.nDCpaPercentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nDCpaPercentDataGridViewTextBoxColumn.Name = "nDCpaPercentDataGridViewTextBoxColumn";
            this.nDCpaPercentDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RCDataSet rCDataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private RCDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollingAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPPpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDCpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPPprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDCprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPPpaPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDCpaPercentDataGridViewTextBoxColumn;
    }
}

