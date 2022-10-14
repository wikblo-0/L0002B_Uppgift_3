//Wiktoria Blomgren Strandberg
//wikblo-0@student.ltu.se
//L0002B Uppgift 3

using System;
using System.Windows.Forms;

namespace L0002B_Uppgift_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
