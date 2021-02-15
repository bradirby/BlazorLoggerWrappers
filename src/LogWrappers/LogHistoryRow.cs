using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWrappers
{
    public class LogHistoryRow
    {
        public LogHistoryType Logtype { get; set; }
        public string Msg { get; set; }
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

    public enum LogHistoryType
    {
        Debug,
        Info,
        Warn,
        Error,
        Exception
    }
}
