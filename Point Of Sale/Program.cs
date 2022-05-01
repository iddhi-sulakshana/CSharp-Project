﻿using System;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Splash_Screen());
            Application.Run(new Form_Welcome());
        }
    }
}
