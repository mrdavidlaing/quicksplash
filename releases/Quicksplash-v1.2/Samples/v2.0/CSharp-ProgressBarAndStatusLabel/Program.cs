using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace CSharp_ProgressBarAndStatusLabel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Splashscreen.SplashscreenController.UpdateStatusLabel("Initialising");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Splashscreen.SplashscreenController.UpdateStatusLabel("Loading data...");
            Thread.Sleep(5000); //Simulate loading data
            Application.Run(new Form1());
        }
    }
}