namespace SeppimCaraibesApp.Domain.Model
{
    using System;
    using System.Diagnostics;
    using System.IO;

    internal class Log
    {
        private readonly string CURRENT_APP_DIRECTORY = @AppDomain.CurrentDomain.BaseDirectory + @"\Log";
        private readonly string REFERENCE_ORIGIN = "Seppim Caraibes: ";
        private readonly DateTime currentDate = DateTime.Now;


        private string SetMessage(params object[] values)
        {
            return string.Format("({0}) => [{1}] :: {2}", values);
        }


        public void WriteLogIntoFile(string personName, string description, Domain.ETypeOfMessage logType)
        {
            TraceSource traceSource = new TraceSource(REFERENCE_ORIGIN);
            SourceSwitch level = new SourceSwitch(REFERENCE_ORIGIN);

            switch (logType)
            {
                case ETypeOfMessage.Warning:
                    level.Level = SourceLevels.Warning;
                    break;
                case ETypeOfMessage.Error:
                    level.Level = SourceLevels.Error;
                    break;
                default:
                    level.Level = SourceLevels.Information;
                    break;
            }

            traceSource.Switch = level;

            string logDirectory = CURRENT_APP_DIRECTORY;
            string nameFile = currentDate.Year + "_" + currentDate.Month + "_" + currentDate.Day + "." + level.Level.ToString();

            string path = Path.Combine(logDirectory, nameFile);

            string message = SetMessage(new object[] { currentDate.ToShortTimeString(), personName, description });

            switch (logType)
            {
                case ETypeOfMessage.Warning:
                    using (TextWriterTraceListener infoLogListener = new TextWriterTraceListener(path))
                    {
                        if (!traceSource.Listeners.Contains(infoLogListener))
                        {
                            traceSource.Listeners.Add(infoLogListener);
                        }
                        traceSource.TraceEvent(TraceEventType.Warning, 1, message);
                        infoLogListener.Flush();
                    }
                    break;
                case ETypeOfMessage.Error:
                    using (TextWriterTraceListener infoLogListener = new TextWriterTraceListener(path))
                    {
                        if (!traceSource.Listeners.Contains(infoLogListener))
                        {
                            traceSource.Listeners.Add(infoLogListener);
                        }
                        traceSource.TraceEvent(TraceEventType.Error, 2, message);
                        infoLogListener.Flush();
                    }
                    break;
                default:
                    using (TextWriterTraceListener infoLogListener = new TextWriterTraceListener(path))
                    {
                        if (!traceSource.Listeners.Contains(infoLogListener))
                        {
                            traceSource.Listeners.Add(infoLogListener);
                        }
                        traceSource.TraceInformation(message);
                        infoLogListener.Flush();
                    }
                    break;
            }
        }
    }
}
