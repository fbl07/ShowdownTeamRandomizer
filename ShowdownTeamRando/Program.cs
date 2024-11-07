using System.Runtime.Versioning;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AppDomain.CurrentDomain.UnhandledException += ErrorHandler;

            Application.Run(new frmMainForm());
            
        }

        static void ErrorHandler(object sender, UnhandledExceptionEventArgs args)
        {
            var e = (Exception)args.ExceptionObject;

            var dialog = new ThreadExceptionDialog(e);
            dialog.ShowDialog();
        } 
    }
}