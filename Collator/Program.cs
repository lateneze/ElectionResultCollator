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

namespace Collator
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ResultViewer());
            //DatabaseConnection.ValidateMessage("test message", "+233542182248");
            
        }

        
    }
}
