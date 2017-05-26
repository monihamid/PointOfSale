

/* ========================================================
FILE          : Program.cs
PROJECT       : Revence of Wally (PoS)- Assignment #04
STUDENT NAME  : Monira Sultana (ID 7308182)
FUNCTION      : main
PURPOSE       :This mainline calls main form page and run the program.
======================================================== */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallyPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrontPage());
        }
    }
}
