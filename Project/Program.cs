using System;
using System.Windows.Forms;

namespace EmlakciKayitSistemiGUI
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktasıdır.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmlakciForm());
        }
    }
}
