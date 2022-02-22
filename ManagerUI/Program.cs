using ServiceManagerLibrary;

namespace ManagerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //TODO - SEARCH ALL CUSTOMERS.

            //TODO - Clean up code - add comments where missing.


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Initialize SQL Connection before running app.
            GlobalConfig.InitializeConnection();
            Application.Run(new ManagerLanding());
        }
    }
}