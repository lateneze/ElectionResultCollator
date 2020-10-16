using GsmComm.PduConverter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collator
{
    class DatabaseConnection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["RCConnectionString"].ConnectionString;

        internal static void WriteDatabase(int[] results, string pollingAgent)
        {
            //var conn = ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.testConnectionString"].ConnectionString;
            //var conn = ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.RCConnectionString"].ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection  
                var s = "INSERT INTO Community(communityName) VALUES ('New Developer')";
                OleDbCommand command = new OleDbCommand(s, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  


                    /* using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("------------Original data----------------");
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1}", reader["Name"].ToString(), reader["Address"].ToString());
                        }
                    }
                    */

                    command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


            /*using (IDbConnection connection = new System.Data.OleDb.OleDbConnection(conn))
            {
                /* var upd = $"SELECT * from Results where ID = 1 or ID =2;";
                string insert = "insert INTO Results (pollingstation, pollingname, NDC_pa, NPP_pa, NPP_pr) VALUES (1, 1, 544, 233, 849);";
                connection.Execute(insert);
                var outc = connection.Query(upd).ToList();
                foreach (var item in outc)
                {
                    Console.WriteLine(item);
                }
                /
                var s = "INSERT INTO Community(communityName) VALUES ('New Developer')";
                var rs = connection.Execute(s);
                Console.WriteLine("test " + rs);
                Console.ReadLine();
            }
            */
        }

        public static void WriteToDatabase(int[] results, string pollingAgent)
        {
            var npp_pa = results[0];
            var ndc_pa = results[1];
            var npp_pr = results[2];
            var ndc_pr = results[3];
            
            pollingAgent = pollingAgent.Replace("+233", "0");
            pollingAgent = pollingAgent.Substring(1);
            int pollingAgenti = int.Parse(pollingAgent);

            
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                //string comm = "wewe";
                //cmd.CommandText = "Insert into Community(communityName) Values('"+ comm + "')";

                //cmd.CommandText = $"Insert into Results(pollingstation, pollingname, NPP_pa, NDC_pa, NPP_pr) Values(1, 'wiini', {rs[0]}, {rs[1]}, {rs[2]});";

                cmd.CommandText = $"UPDATE Results SET NPP_pa = {results[0]}, NDC_pa = {results[1]}, NPP_pr = {results[2]}, NDC_pr = {results[3]} WHERE pollingAgent = {pollingAgenti};";

                cmd.Connection = con;
                Console.WriteLine(cmd.ExecuteNonQuery());
                Console.WriteLine("Record Submitted, Congrats");
                con.Close();
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
            pollingAgent = pollingAgent.Replace("+233", "0");
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
