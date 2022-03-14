using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class EventLogger: LogBase
    {
        string _appName = "";

        public EventLogger(string appName)
        {
            _appName = appName;
        }

        public override void Log(LogType logType, string message)
        {
            try
            {
                if (!EventLog.SourceExists(_appName))
                {
                    EventLog.CreateEventSource(_appName, message);
                    return;
                }

                EventLog eventLog = new EventLog("");
                eventLog.Source = _appName;
                EventLogEntryType elet = EventLogEntryType.Information;
                switch (logType)
                {
                    case LogType.Error:
                        elet = EventLogEntryType.Error;
                        break;
                    case LogType.Warning:
                        elet = EventLogEntryType.Warning;
                        break;
                    case LogType.Information:
                        elet = EventLogEntryType.Information;
                        break;
                }

                eventLog.WriteEntry(message, elet);
            }
            catch (Exception e)
            {
                LogHelper.Log(LogTarget.File, LogType.Error, e.Message);
            }
        }
    }
}
