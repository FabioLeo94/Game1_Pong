using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Game1_Pong
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
            Application.Run(new Form1());

            }
            catch
            {

            }
        }
    }
}
