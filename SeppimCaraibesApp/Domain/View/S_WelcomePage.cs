namespace SeppimCaraibesApp.Domain.View
{
    using System;
    using DevExpress.XtraSplashScreen;

    internal partial class S_WelcomePage : SplashScreen
    {
        public S_WelcomePage()
        {
            InitializeComponent();
            copyrightLC.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }
        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}