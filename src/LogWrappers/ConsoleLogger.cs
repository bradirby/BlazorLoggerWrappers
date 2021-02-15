using System;

namespace LogWrappers
{
    public class ConsoleLogger : IMessageLogger
    {
        private string LoggerType { get; set; }

        public void SetLoggerType<T>()
        {
            LoggerType = typeof(T).ToString();
        }

        public void Debug(string messageTemplate)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {messageTemplate}");
        }

        public void Debug<T>(string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {messageTemplate} {propertyValue}");
        }

        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {messageTemplate} {propertyValues}");
        }

        public void Debug(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {exception.Message} {messageTemplate} ");
        }

        public void Debug<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {exception.Message} {messageTemplate} {propertyValue}");
        }

        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"DEBUG: {LoggerType} {exception.Message} {messageTemplate} {propertyValues}");
        }

        //  ****************************************************************************

        public void Information(string messageTemplate)
        {
            Console.WriteLine($"INFO: {LoggerType} {messageTemplate}");
        }

        public void Information<T>(string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"INFO: {LoggerType} {messageTemplate} {propertyValue}");
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"INFO: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"INFO: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"INFO: {LoggerType} {messageTemplate} {propertyValues}");
        }

        public void Information(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"INFO: {LoggerType} {exception.Message} {messageTemplate} ");
        }

        public void Information<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"INFO: {LoggerType} {exception.Message} {messageTemplate} {propertyValue} ");
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"INFO: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1} ");
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"INFO: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"INFO: {LoggerType} {exception.Message} {messageTemplate} {propertyValues}");
        }

        public void Warning(string messageTemplate)
        {
            Console.WriteLine($"WARN: {LoggerType} {messageTemplate} ");
        }

        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"WARN: {LoggerType} {messageTemplate} {propertyValue} ");
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"WARN: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"WARN: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"WARN: {LoggerType} {messageTemplate} {propertyValues}");
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"WARN: {LoggerType} {exception.Message} {messageTemplate} ");
        }

        public void Warning<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"WARN: {LoggerType} {exception.Message} {messageTemplate} {propertyValue}");
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"WARN: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"WARN: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"WARN: {LoggerType} {exception.Message} {messageTemplate} {propertyValues}");
        }

        public void Error(string messageTemplate)
        {
            Console.WriteLine($"ERR: {LoggerType} {messageTemplate} ");
        }

        public void Error<T>(string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"ERR: {LoggerType} {messageTemplate} {propertyValue}");
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"ERR: {LoggerType} {messageTemplate} {propertyValue0}, {propertyValue1}");
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"ERR: {LoggerType} {messageTemplate} {propertyValue0}, {propertyValue1} {propertyValue2}");
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"ERR: {LoggerType} {messageTemplate} {propertyValues}");
        }

        public void Error(Exception exception)
        {
            Console.WriteLine($"ERR: {LoggerType} {exception.Message}");
        }

        public void Error(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"ERR: {LoggerType} {exception.Message} {messageTemplate}");
        }

        public void Error<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"ERR: {LoggerType} {exception.Message} {messageTemplate} {propertyValue}");
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"ERR: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"ERR: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"ERR: {LoggerType} {exception.Message} {messageTemplate} {propertyValues}");
        }

        public void Fatal(string messageTemplate)
        {
            Console.WriteLine($"FATAL: {LoggerType} ");
        }

        public void Fatal<T>(string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"FATAL: {LoggerType} {messageTemplate} {propertyValue}");
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"FATAL: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"FATAL: {LoggerType} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"FATAL: {LoggerType} {messageTemplate} {propertyValues}");
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"FATAL: {LoggerType} {exception.Message} {messageTemplate} ");
        }

        public void Fatal<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            Console.WriteLine($"FATAL: {LoggerType} {exception.Message} {messageTemplate} {propertyValue}");
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"FATAL: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1}");
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"FATAL: {LoggerType} {exception.Message} {messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"FATAL: {LoggerType} {exception.Message} {messageTemplate} {propertyValues}");
        }
    }
}
