using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorLoggerWrappers.Shared
{
   public class LogHistory
    {
        public int MaxHistoryToKeep { get; set; } = 30;

        private readonly Queue<LogHistoryRow> _history = new();


        public void Debug(string msg)
        {
            EnqueueItem(new LogHistoryRow(LogHistoryType.Debug, msg));
        }

        public void Warning(string msg)
        {
            EnqueueItem(new LogHistoryRow(LogHistoryType.Warn, msg));
        }

        public void Information(string msg)
        {
            EnqueueItem(new LogHistoryRow(LogHistoryType.Info, msg));
        }

        public void Error(string msg)
        {
            EnqueueItem(new LogHistoryRow(LogHistoryType.Error, msg));
        }
        
        public void Fatal(string msg)
        {
            EnqueueItem(new LogHistoryRow(LogHistoryType.Error, msg));
        }

        public void Error(Exception e, string msg)
        {
            EnqueueItem(new LogHistoryRow(LogHistoryType.Exception, msg, e));
        }

        private void EnqueueItem(LogHistoryRow row)
        {
            _history.Enqueue(row);
            if (_history.Count > MaxHistoryToKeep) _history.Dequeue();
        }

        
        public void WriteOutLogHistory(IMessageLogger logger)
        {
            logger.Error("*** Beginning of log history ***");
            foreach (var logRow in _history.ToList())
            {
                switch (logRow.Logtype)
                {
                    case LogHistoryType.Debug:
                        logger.Debug(logRow.Msg);
                        break;
                    case LogHistoryType.Info:
                        logger.Information(logRow.Msg);
                        break;
                    case LogHistoryType.Warn:
                        logger.Warning(logRow.Msg);
                        break;
                    case LogHistoryType.Error:
                        logger.Error(logRow.Msg);
                        break;
                    case LogHistoryType.Exception:
                        logger.Error(logRow.Exc, logRow.Msg);
                        break;
                    default:
                        logger.Error(logRow.Msg);
                        break;
                }
                logger.Error("*** End of log history ***");
            }
        }

        internal enum LogHistoryType
        {
            Debug,
            Info,
            Warn,
            Error,
            Exception
        }

        internal class LogHistoryRow
        {
            public LogHistoryType Logtype { get;set;}
            public string Msg { get;set;}
            public Exception Exc { get; set; }

            public LogHistoryRow(LogHistoryType typ, string msg)
            {
                Logtype = typ;
                Msg = msg;
            }
            public LogHistoryRow(LogHistoryType typ, string msg, Exception exc)
            {
                Exc = exc;
                Logtype = typ;
                Msg = msg;
            }
        }
    }



}
