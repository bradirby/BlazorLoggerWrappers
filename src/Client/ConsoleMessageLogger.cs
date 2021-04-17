using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLoggerWrappers.Shared;

namespace BlazorLoggerWrappers.Client
{
   public class ConsoleMessageLogger : IMessageLogger
    {

        private string CurrentTimeStamp => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

        private string LoggerType { get; set; } = "[?] ";

        public void SetLoggerType<T>()
        {
            LoggerType = $"[{typeof(T)}] ";
        }


        public void Debug(string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + messageTemplate);
        }

        public void Debug<T1>(string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + messageTemplate, propertyValue);
        }

        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + messageTemplate, propertyValues);
        }

        public void Debug(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + exception.Message, messageTemplate);
        }

        public void Debug<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + exception.Message, messageTemplate, propertyValue);
        }

        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [DEBUG] " + LoggerType + exception.Message, messageTemplate, propertyValues);
        }

        //**********************************************************************************************

        public void Information(string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + messageTemplate);
        }

        public void Information<T1>(string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + messageTemplate, propertyValues);
        }

        public void Information(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + exception.Message, messageTemplate);
        }

        public void Information<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + exception.Message, messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [INFO] " + LoggerType + exception.Message, messageTemplate, propertyValues);
        }

        //****************************************************************************************

        public void Warning(string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + messageTemplate);
        }

        public void Warning<T1>(string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + messageTemplate, propertyValues);
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + exception.Message, messageTemplate);
        }

        public void Warning<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + exception.Message, messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [WARN] " + LoggerType + exception.Message, messageTemplate, propertyValues);
        }

        //**********************************************************************************************************

        public void Error(string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + messageTemplate);
        }

        public void Error<T1>(string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + messageTemplate, propertyValues);
        }

        public void Error(Exception exception)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + exception.Message);
        }


        public void Error(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + exception.Message, messageTemplate);
        }

        public void Error<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + exception.Message, messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [ERROR] " + LoggerType + exception.Message, messageTemplate, propertyValues);
        }

        //*************************************************************************

        public void Fatal(string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + messageTemplate);
        }

        public void Fatal<T1>(string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + messageTemplate, propertyValues);
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + exception.Message, messageTemplate);
        }

        public void Fatal<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + exception.Message, messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + exception.Message, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine($"{CurrentTimeStamp} [FATAL] " + LoggerType + exception.Message, messageTemplate, propertyValues);
        }

    }
}
