﻿using System;
using System.Windows.Forms;
using WindowsApp.WindowsApp;

namespace WindowsApp
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

            new Login().Show();

            Application.Run();
        }
    }
}
