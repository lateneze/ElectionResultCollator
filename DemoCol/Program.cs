using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;

namespace DemoCol
{
    static class Program
    {
        public static DeviceConnection serialCOMDevice = new DeviceConnection();
        //public static DatabaseConnection databaseConnection;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ResultViewer());
            List<int> results = new List<int> { 78, 90, 0, 0 };
            //int outcome = 0;
            DatabaseConnection.GetResult();
            //Console.WriteLine($"Outcome is {outcome}");

        }


    }
}
