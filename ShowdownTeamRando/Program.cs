using System.Runtime.Versioning;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    internal static class Program
    {
        private const string ERROR_LOG_FILENAME = "error_logs.txt";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += ErrorHandler;

            Application.Run(new frmMainForm());
            
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleErrors(e.Exception);
        }

        static void ErrorHandler(object sender, UnhandledExceptionEventArgs args)
        {
            HandleErrors((Exception)args.ExceptionObject);
        } 
        
        static void HandleErrors(Exception e)
        {
            string exceptionInfo = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} Error happened : \n{e.Message}\n\n";
            exceptionInfo += e.StackTrace + "\n\n";

            File.AppendAllText(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), ERROR_LOG_FILENAME), exceptionInfo);

            var dialog = new ThreadExceptionDialog(e);
            var result = dialog.ShowDialog();

            if (result == DialogResult.Abort)
                Application.Exit();
        }
    }
}