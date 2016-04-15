using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceTracker.Forms;
using InvoiceTracker.Database;

namespace InvoiceTracker
{
    static class Program
    {
        public static InvoiceTrackerDB Model
        {
            get
            {
                return InvoiceTrackerDB.AccessDatabaseProvider(ConnfigurationStrings.AccessDb);
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main m = new Main
                        {
                            Text = MainHeading(),
                            Model = Program.Model
                        };
            Application.Run(m);                      
        }

        static string MainHeading()
        {
            return "Water Resources Division: Invoice Tracker Beta 0.0.1";
        }
        
    }
}
