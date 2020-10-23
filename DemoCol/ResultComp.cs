using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCol
{
    public partial class ResultComp : Form
    {
        SqlDataAdapter da;
        public ResultComp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.8), (int)(Screen.PrimaryScreen.Bounds.Height * 0.8));
        }

        public delegate void SafeUpdateCharts();
        public delegate void SafeUpdatePrChart();
        public delegate void SafeUpdatePaChart();


        private void Pa()
        {
            //Update parliamentary pie
            parliamentaryData = DatabaseConnection.GetParliamentaryResult();
            chartParliament.Series["SeriesParliament"].XValueMember = this.parliamentaryData.Columns[0].ColumnName;
            chartParliament.Series["SeriesParliament"].YValueMembers = this.parliamentaryData.Columns[1].ColumnName;
            chartParliament.Series["SeriesParliament"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartParliament.DataBind();
            chartParliament.Visible = true;
            chartParliament.Show();
           
            this.Refresh();
        }

        private void Pr()
        {
            //Update presidential pie
            presidentialData = DatabaseConnection.GetPresidentialResult();
            chartPresidential.Series["SeriesPresidential"].XValueMember = this.presidentialData.Columns[0].ColumnName;
            chartPresidential.Series["SeriesPresidential"].YValueMembers = this.presidentialData.Columns[1].ColumnName;
            chartPresidential.Series["SeriesPresidential"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartPresidential.DataBind();
            chartPresidential.Update();
        }

        public void UpdateSafe()
        {
            this.BeginInvoke((SafeUpdateCharts)delegate ()
            {
                UpdateCharts();
            });
            
        }

        public void UpdatePaSafe()
        {
            chartParliament.BeginInvoke((SafeUpdatePaChart)delegate ()
            {
                parliamentaryData = DatabaseConnection.GetParliamentaryResult();
                chartParliament.DataBind();
                chartParliament.Update();
            });

            
        }


        public void UpdatePrSafe()
        {
            chartPresidential.BeginInvoke((SafeUpdatePrChart)delegate ()
            {
                presidentialData = DatabaseConnection.GetPresidentialResult();
                chartPresidential.DataBind();
                chartPresidential.Update();
            });


            //if (this.chartPresidential.InvokeRequired)
            //{
            //    var d = new SafeUpdatePrChart(Pr);
            //    d();
            //}
            //else
            //{
                
            //    //Update presidential pie
            //    this.presidentialData = DatabaseConnection.GetPresidentialResult();
            //    this.chartPresidential.Series["SeriesPresidential"].XValueMember = this.presidentialData.Columns[0].ColumnName;
            //    this.chartPresidential.Series["SeriesPresidential"].YValueMembers = this.presidentialData.Columns[1].ColumnName;
            //    //this.chartPresidential.Series["SeriesPresidential"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //    this.chartPresidential.DataBind();
            //    this.Refresh();
            //}
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDBDataSet.spGet_Presidential_Results' table. You can move, or remove it, as needed.
            this.spGet_Presidential_ResultsTableAdapter.Fill(this.electionDBDataSet.spGet_Presidential_Results);
            // TODO: This line of code loads data into the 'electionDBDataSet.spGet_Parliamentary_Results' table. You can move, or remove it, as needed.
            this.spGet_Parliamentary_ResultsTableAdapter.Fill(this.electionDBDataSet.spGet_Parliamentary_Results);
            // TODO: This line of code loads data into the 'electionDBDataSet.spGet_All_Result' table. You can move, or remove it, as needed.
            this.spGet_All_ResultTableAdapter.Fill(this.electionDBDataSet.spGet_All_Result);

            //this.electionDBDataSet.spGet_Parliamentary_Results.Columns[0].
            //presidentialData = DatabaseConnection.GetPresidentialResult();
            this.Width = ((int)(Screen.PrimaryScreen.Bounds.Width * 0.8));
            this.Height = ((int)(Screen.PrimaryScreen.Bounds.Height * 0.8));

            dataGridResults.Width = Convert.ToInt32(this.Width * 0.7);
            panelCharts.Width = (this.Size.Width - dataGridResults.Width);

            UpdateCharts();
            SqlCommand command = new SqlCommand("dbo.spGet_All_Result", new SqlConnection(DatabaseConnection.connectionString));

            da = new SqlDataAdapter(command);
            DataSet DS = new DataSet();
            da.Fill(DS);
            dataGridResults.DataSource = DS.Tables[0];
        }

        public void UpdatePaChart()
        {
            UpdatePaSafe();
            
        }

        public void UpdatePrChart()
        {
            UpdatePrSafe();

        }

        public void UpdateDataGrid()
        {

        }

        private void buttonCon_Click(object sender, EventArgs e)
        {
            ComSelector ss = new ComSelector();
            ss.Show();
        }

        internal void UpdateCharts()
        {
            //this.BeginInvoke((SafeUpdatePaChart)delegate ()
            //{
            //    this.Refresh();
            //});

            //UpdatePrSafe();
            //UpdatePaSafe();
            //UpdateDGSafe();

            parliamentaryData = DatabaseConnection.GetParliamentaryResult();
            chartParliament.DataSource = parliamentaryData;
            chartParliament.Series["SeriesParliament"].XValueMember = this.parliamentaryData.Columns[0].ColumnName;
            chartParliament.Series["SeriesParliament"].YValueMembers = this.parliamentaryData.Columns[1].ColumnName;
            chartParliament.Series["SeriesParliament"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartParliament.DataBind();
            //chartParliament.Visible = true;
            //chartParliament.Show();

            presidentialData = DatabaseConnection.GetPresidentialResult();
            chartPresidential.DataSource = presidentialData;
            chartPresidential.Series["SeriesPresidential"].XValueMember = this.presidentialData.Columns[0].ColumnName;
            chartPresidential.Series["SeriesPresidential"].YValueMembers = this.presidentialData.Columns[1].ColumnName;
            chartPresidential.Series["SeriesPresidential"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartPresidential.DataBind();
            //chartPresidential.Update();

            // Update DataGrid
            dataGridResults.DataSource = DatabaseConnection.GetResult();
            dataGridResults.Update();
            dataGridResults.Refresh();

            this.Refresh();

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            UpdateCharts();
        }

        private void buttonModifyResult_Click(object sender, EventArgs e)
        {
           

            DataTable changes = ((DataTable)dataGridResults.DataSource).GetChanges();
            if (changes != null)
            {
                foreach (DataRow result in changes.Rows)
                {
                    using (SqlCommand command = new SqlCommand("dbo.spResult_Details_Update", new SqlConnection(DatabaseConnection.connectionString)))
                    {
                        command.Connection.Open();
                        command.Parameters.AddWithValue("@agent", result[1]);
                        command.Parameters.AddWithValue("@npp_pa", result[2]);
                        command.Parameters.AddWithValue("@ndc_pa", result[3]);
                        command.Parameters.AddWithValue("@npp_pr", result[4]);
                        command.Parameters.AddWithValue("@ndc_pr", result[5]);

                        command.CommandType = CommandType.StoredProcedure;
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                }
                    
                
                
            }
                
        }

        private void ResultComp_SizeChanged(object sender, EventArgs e)
        {
           
            dataGridResults.Width = Convert.ToInt32(this.Width * 0.7);
            panelCharts.Width = (this.Size.Width - dataGridResults.Width);

            var sw = Screen.PrimaryScreen.Bounds.Width;
            var sh = Screen.PrimaryScreen.Bounds.Height;
            var fw = this.Width;
            var fh = this.Height;
            var pw = ((decimal)fw / sw) * 100;
            var ph = ((decimal)fh / sh) * 100;

            var wid = ((this.Width) *100);
            var heit = ((this.Height / Screen.PrimaryScreen.Bounds.Height) * 100);
            labelWidth.Text = $"{pw}";
            labelHeight.Text = $"{ph}";
        }
    }
}
