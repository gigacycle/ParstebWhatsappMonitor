using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(LogTarget target, LogType type, string message)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(type, message);
                    break;
                case LogTarget.Database:
                    //logger = new DBLogger();
                    //logger.Log(message);
                    break;
                default:
                    return;
            }
        }
        public static void EventLog(LogType type, string appName, string message)
        {
            logger = new EventLogger(appName);
            logger.Log(type, message);
        }
    }
}
