namespace SeppimCaraibesApp
{
    using SeppimCaraibesApp.Domain;
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Threading;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandleException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Domain.View.U_LogginPage());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            C_Log _cLog = new C_Log();
            _cLog.Write(e.Exception.Message, ETypeOfMessage.Error);
        }

        static void CurrentDomain_UnhandleException(object sender, UnhandledExceptionEventArgs e)
        {
            C_Log _cLog = new C_Log();
            _cLog.Write((e.ExceptionObject as Exception).Message, ETypeOfMessage.Error);
        }
    }
}
