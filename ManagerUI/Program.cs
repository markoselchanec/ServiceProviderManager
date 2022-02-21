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
            //TODO - SEARCH ALL CUSTOMERS

            //TODO - IF REMOVING A SERVICE ON UPDATE CUSTOMER - 
            //TODO - Format dates in dashboard
            //TODO - When closing update customer reload dashboard instead of closing it.
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Initialize SQL Connection before running app.
            GlobalConfig.InitializeConnection();
            Application.Run(new ManagerLanding());
        }
    }
}