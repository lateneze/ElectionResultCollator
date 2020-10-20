using GsmComm.PduConverter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCol
{
    class DatabaseConnection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DemoCol.Properties.Settings.ElectionDBConnectionString"].ConnectionString;

        public static void GetParliamentaryResult()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand command = new SqlCommand("dbo.spGet_Parliamentary_Results", cn);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Console.WriteLine(dataTable.Columns[0].ColumnName);

            }

        }

        public static void GetPresidentialResult()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlCommand command = new SqlCommand("dbo.spGet_Presidential_Results", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    Console.WriteLine(dataTable.Columns[0].ColumnName);
                }

                cn.Close();
            }

        }


        public static void GetResult()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (SqlCommand command = new SqlCommand("dbo.spGet_All_Result", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    Console.WriteLine(dataTable.Columns[0].ColumnName);
                }

                cn.Close();
            }

        }



        public static void WriteToDatabase(List<int> results, string pollingAgent)
        {
            var npp_pa = results[0];
            var ndc_pa = results[1];
            var npp_pr = results[2];
            var ndc_pr = results[3];


            pollingAgent = pollingAgent.Substring(1);
            int pollingAgenti = int.Parse(pollingAgent);

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand command = new SqlCommand("dbo.spEnter_Results", cn);
                command.Parameters.AddWithValue("@agent", pollingAgenti);
                command.Parameters.AddWithValue("@npp_pa", npp_pa);
                command.Parameters.AddWithValue("@ndc_pa", ndc_pa);
                command.Parameters.AddWithValue("@npp_pr", npp_pr);
                command.Parameters.AddWithValue("@ndc_pr", ndc_pr);

                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                cn.Close();
            }


        }

        internal static void SaveDuplicateMessage(string textMessage, string pollingAgent, SmsTimestamp smsTimestamp)
        {
            pollingAgent = pollingAgent.Replace("+233", "0");
            pollingAgent = pollingAgent.Substring(1);
            int pollingAgenti = int.Parse(pollingAgent);
            string time = smsTimestamp.ToString(false);

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                var insertText = "INSERT INTO DuplicateMessage ([sender],[time],[message]) VALUES (@sender,@time, @message)";

                OleDbCommand cmd = new OleDbCommand(insertText, con);
                //cmd.Parameters.Add("@ID", OleDbType.Integer).Value = 2;
                cmd.Parameters.Add("@sender", OleDbType.Integer).Value = pollingAgenti;
                cmd.Parameters.Add("@time", OleDbType.VarChar).Value = time;
                cmd.Parameters.Add("@message", OleDbType.VarChar).Value = textMessage;

                Console.WriteLine(cmd.ExecuteNonQuery());
                Console.WriteLine("Msg Submitted, Congrats");
                con.Close();
            }
        }

        internal static void SaveMessage(string textMessage, string pollingAgent, SmsTimestamp smsTimestamp)
        {
            pollingAgent = pollingAgent.Replace("+233", "0");
            pollingAgent = pollingAgent.Substring(1);
            int pollingAgenti = int.Parse(pollingAgent);
            string time = smsTimestamp.ToString(false);

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                var insertText = "INSERT INTO Message ([sender],[time],[message]) VALUES (@sender,@time, @message)";
                // var insertText = $"INSERT INTO Message ([sender],[time],[message]) VALUES ({pollingAgenti}, {time}, {textMessage})";

                OleDbCommand cmd = new OleDbCommand(insertText, con);
                //cmd.Parameters.Add("@ID", OleDbType.Integer).Value = 2;
                cmd.Parameters.Add("@sender", OleDbType.Integer).Value = pollingAgenti;
                cmd.Parameters.Add("@time", OleDbType.VarChar).Value = time;
                cmd.Parameters.Add("@message", OleDbType.VarChar).Value = textMessage;

                Console.WriteLine(cmd.ExecuteNonQuery());
                Console.WriteLine("Msg Submitted, Congrats");
                con.Close();
            }

        }

        internal static MessageExistenceStatus ValidateMessage(string textMessage, string pollingAgent)
        {

            pollingAgent = pollingAgent.Substring(1);
            int pollingAgenti = int.Parse(pollingAgent);
            MessageExistenceStatus messageExistenceStatus = MessageExistenceStatus.New;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                var commandText = $"SELECT * FROM Message WHERE sender = {pollingAgenti};";

                OleDbCommand cmd = new OleDbCommand(commandText, con);
                var reader = (cmd.ExecuteReader());
                if (reader.HasRows)
                {
                    reader.Read();
                    string message = (string)reader[3];

                    if (message == textMessage)
                    {
                        messageExistenceStatus = MessageExistenceStatus.ExistsButSame;
                    }
                    else
                    {
                        messageExistenceStatus = MessageExistenceStatus.ExistsButDifferent;
                    }

                }
                else
                {
                    messageExistenceStatus = MessageExistenceStatus.New;
                }

                reader.Close();
                con.Close();

                return messageExistenceStatus;
            }

        }
    }
}
