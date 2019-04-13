using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenkartei
{
    static class Program
    {

        private static Mutex m_Mutex;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            bool createdNew;
            m_Mutex = new Mutex(true, "MyApplicationMutex", out createdNew);
            if (createdNew)
                Application.Run(new MainForm());
            else
                MessageBox.Show("Die Anwendung läuft bereits.", Application.ProductName,
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
