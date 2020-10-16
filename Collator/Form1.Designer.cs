namespace Collator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollingStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rC12DataSet = new Collator.RC12DataSet();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new Collator.RC12DataSetTableAdapters.ResultsTableAdapter();
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
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rC12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.connectbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 718);
            this.panel1.TabIndex = 0;
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(3, 33);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(96, 34);
            this.connectbtn.TabIndex = 5;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(203, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(50, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NDC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(203, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TitlegroupBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NKWANTA NORTH CONSTITUENCY";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.connectMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.Size = new System.Drawing.Size(146, 26);
            this.connectMenuItem.Text = "Connect";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pollingStationsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // pollingStationsToolStripMenuItem
            // 
            this.pollingStationsToolStripMenuItem.Name = "pollingStationsToolStripMenuItem";
            this.pollingStationsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.pollingStationsToolStripMenuItem.Text = "Polling Stations";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 396);
            this.dataGridView1.TabIndex = 8;
            // 
            // rC12DataSet
            // 
            this.rC12DataSet.DataSetName = "RC12DataSet";
            this.rC12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.rC12DataSet;
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
            this.ClientSize = new System.Drawing.Size(1077, 718);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rC12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollingStationsToolStripMenuItem;
        private RC12DataSet rC12DataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private RC12DataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
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