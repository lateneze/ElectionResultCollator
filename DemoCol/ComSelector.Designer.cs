namespace DemoCol
{
    partial class ComSelector
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
            this.labelCom = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(46, 59);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(39, 17);
            this.labelCom.TabIndex = 0;
            this.labelCom.Text = "COM";
            this.labelCom.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox
            // 
            this.comboBox.DataSource = Program.serialCOMDevice.GetComPorts();
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(122, 59);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(125, 118);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(117, 34);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // ComSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 239);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelCom);
            this.Name = "ComSelector";
            this.Text = "ComSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonConnect;
    }
}