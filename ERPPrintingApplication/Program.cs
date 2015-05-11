using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPPrintingApplication
{
    static class Program
    {
        public static MagentoAPIService MagentoService = new MagentoAPIService();
        public static PrinterAPI PrintService = new PrinterAPI();
        public static ToUPS convertUPS = new ToUPS();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.SessionKey = "";
            using (Login login = new Login())
            {
                while (1==1)
                {
                    if (login.ShowDialog() == DialogResult.OK) Application.Run(new MainForm());
                    else if (login.DialogResult == DialogResult.Cancel) return;
                }

                
            }
           
        }
    }
}
