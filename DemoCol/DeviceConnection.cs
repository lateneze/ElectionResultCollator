//using Dapper;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace DemoCol
{
    public class DeviceConnection
    {
        private static GsmCommMain port;
        public static SmsSubmitPdu outmsg = new SmsSubmitPdu();
        public static string sender = "";
        private static List<string> duplicateMessage = new List<string>();
        public static string[] Parties = { "npp_pa", "ndc_pa", "npp_pr", "ndc_pr" };


        public void InitializePortConnection(string comPort)
        {
            port = new GsmCommMain(comPort);
            port.Open();
            port.MessageReceived += new MessageReceivedEventHandler(MessageReceivedHandler);
            port.PhoneDisconnected += new EventHandler(DeviceDisconnectedHandler);
            port.PhoneConnected += new EventHandler(DeviceConnectedHandler);

            IdentificationInfo info = port.IdentifyDevice();

            Console.WriteLine("Hello World! " + port.PortName);
            Console.WriteLine(info.Manufacturer);
            Console.WriteLine(info.Model);
            Console.WriteLine(info.Revision);
            Console.WriteLine(info.SerialNumber);
        }

        public string[] GetComPorts()
        {
            // Get a list of serial port names and return them.
            string[] ports = SerialPort.GetPortNames();
            return ports;

        }


        /// <summary>
        /// Processes the received PDU message event from the device sent by a polling agent.
        /// </summary>
        /// <param name="eventArgs"></param>
        private static void ProcessReceivedMessage(MessageReceivedEventArgs eventArgs)
        {

            var obj = eventArgs.IndicationObject;
            MemoryLocation loc = null;

            if (obj is MemoryLocation)
            {
                loc = (MemoryLocation)obj;
                var msg1 = string.Format("New message received in storage \"{0}\", index {1}.", loc.Storage, loc.Index);
            }

            DecodedShortMessage msg = port.ReadMessage(loc.Index, "SM");
            SmsPdu pdu = msg.Data;
            var textMessage = pdu.UserDataText;
            SmsDeliverPdu smsDeliver = (SmsDeliverPdu)pdu;
            sender = smsDeliver.OriginatingAddress.Replace("+233", "0");

            Console.WriteLine($"New Results Received from {sender}");

            if (CheckFormat(textMessage))
            {
                var validationOutcome = ValidateMessage(textMessage, sender);

                switch (validationOutcome)
                {
                    case MessageExistenceStatus.New:
                        try
                        {
                            var results = ExtractResultsFromMessage(textMessage);
                            Console.WriteLine($"NPP PALIAMENTARY = {results[0]}\nNDC PALIAMENTARY = {results[1]}\nNPP PRESIDENTIAL = {results[2]}\nNDC PRESIDENTIAL = {results[3]}");
                            DatabaseConnection.WriteToDatabase(results, sender);
                            //DatabaseConnection.SaveMessage(textMessage, sender, smsDeliver.GetTimestamp());

                            //SmsSubmitPdu msgtosend = new SmsSubmitPdu("Results Received", smsDeliver.OriginatingAddress);
                            //port.SendMessage(msgtosend);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case MessageExistenceStatus.ExistsButSame:
                        Console.WriteLine($"Same message received from {sender}. Ignored!");
                        break;
                    case MessageExistenceStatus.ExistsButDifferent:
                        //TODO - comeplete
                        //DatabaseConnection.SaveDuplicateMessage(textMessage, sender, smsDeliver.GetTimestamp());
                        duplicateMessage.Add(sender);
                        break;
                    default:

                        break;
                }
            }
            else
            {
                Console.WriteLine($"Message from {sender} is not in approved format.");
            }

        }

        /// <summary>
        /// Checks to ensure that the received message conforms to the protocol format
        /// </summary>
        /// <param name="textMessage"></param>
        /// <returns>True or false depending on the check</returns>
        private static bool CheckFormat(string textMessage)
        {
            bool formatResult = true;
            var splitted = textMessage.Split('\n'); //Spilts the message into lines
            foreach (var line in splitted)
            {
                var trimedLine = RemoveWhiteSpaces(line);
                var halfed = trimedLine.Split(':');

                if (halfed.Length == 2)
                {
                    var partyName = halfed[0];
                    var partyResult = halfed[1];

                    if (Parties.Contains(partyName))
                    {
                        try
                        {
                            int.Parse(partyResult);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            formatResult = false;
                        }
                        formatResult = true;
                    }
                    else
                    {
                        formatResult = false;
                    }
                }
                else
                {
                    formatResult = false;
                }

            }

            return formatResult;
        }

        private static string RemoveWhiteSpaces(string trimedLine)
        {
            return String.Concat(trimedLine.Where(c => !Char.IsWhiteSpace(c)));
        }

        private static MessageExistenceStatus ValidateMessage(string textMessage, string originatingAddress)
        {
            return DatabaseConnection.ValidateMessage(textMessage, originatingAddress);
        }

        /// <summary>
        /// Extracts the polling results for each party from the text message sent from an agent.
        /// </summary>
        /// <param name="textMessage"> The text message extracted from the PDU received</param>
        /// <returns>Returns are array of values representing the results each party got from the polling station</returns>
        private static List<int> ExtractResultsFromMessage(string textMessage)
        {
            List<int> result = new List<int>();
            var splitted = textMessage.Split('\n');

            if (splitted.Length == 4)
            {
                int npp_pa = int.Parse(splitted[0].Substring(splitted[0].IndexOf("npp_pa") + "npp_pa".Length + 1));
                int ndc_pa = int.Parse(splitted[1].Substring(splitted[1].IndexOf("ndc_pa") + "ndc_pa".Length + 1));
                int npp_pr = int.Parse(splitted[2].Substring(splitted[2].IndexOf("npp_pr") + "npp_pr".Length + 1));
                int ndc_pr = int.Parse(splitted[3].Substring(splitted[3].IndexOf("ndc_pr") + "ndc_pr".Length + 1));

                result.Add(npp_pa);
                result.Add(ndc_pa);
                result.Add(npp_pr);
                result.Add(ndc_pr);
            }
            else if (splitted.Length == 2)
            {
                if (splitted[0].Contains("pa") && splitted[1].Contains("pa"))
                {
                    int npp_pa = int.Parse(splitted[0].Substring(splitted[0].IndexOf("npp_pa") + "npp_pa".Length + 1));
                    int ndc_pa = int.Parse(splitted[1].Substring(splitted[1].IndexOf("ndc_pa") + "ndc_pa".Length + 1));
                    int npp_pr = 0;
                    int ndc_pr = 0;

                    result.Add(npp_pa);
                    result.Add(ndc_pa);
                    result.Add(npp_pr);
                    result.Add(ndc_pr);
                }
                else if (splitted[0].Contains("pr") && splitted[1].Contains("pr"))
                {
                    int npp_pa = 0;
                    int ndc_pa = 0;
                    int npp_pr = int.Parse(splitted[0].Substring(splitted[0].IndexOf("npp_pr") + "npp_pr".Length + 1));
                    int ndc_pr = int.Parse(splitted[1].Substring(splitted[1].IndexOf("ndc_pr") + "ndc_pr".Length + 1));

                    result.Add(npp_pa);
                    result.Add(ndc_pa);
                    result.Add(npp_pr);
                    result.Add(ndc_pr);
                }
            }



            return result;
        }

        private static void MessageReceivedHandler(Object o, MessageReceivedEventArgs eventArgs)
        {
            //Console.WriteLine("new message received");
            ProcessReceivedMessage(eventArgs);
            Program.resultComp.UpdateSafe();
            

        }

        private static void DeviceConnectedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Connected");
        }

        private static void DeviceDisconnectedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Disconnected");
        }

    }
}