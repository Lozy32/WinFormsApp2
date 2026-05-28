using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseInitializer.Initialize();
            Application.Run(new StartForm());
        }
    }
}