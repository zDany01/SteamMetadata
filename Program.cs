using System;
using System.Windows.Forms;

namespace SteamMetadata
{
    internal static class Program
    {
        public const string APP_NAME = "Steam Metadata";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
