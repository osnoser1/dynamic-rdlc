using System;
using System.Windows.Forms;

namespace PeriodicTable
{
    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Change to Form2 to see the result of the static report design.
            Application.Run(new Form1());
        }
    }
}