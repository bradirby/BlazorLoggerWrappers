using System;
using Serilog;

namespace LogWrappers
{
    public class SerilogLogger : IMessageLogger
    {
        private ILogger seriLogger;

        public string GetNewMethodCallId()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        public void SetLoggerType<T>()
        {
            seriLogger = Log.Logger.ForContext<T>();
        }

     

        public void Debug(string messageTemplate)
        {
            seriLogger.Debug(messageTemplate);
        }

        public void Debug<T1>(string messageTemplate, T1 propertyValue)
        {
            seriLogger.Debug(messageTemplate, propertyValue);
        }

        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Debug(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Debug(messageTemplate, propertyValues);
        }

        public void Debug(Exception exception, string messageTemplate)
        {
            seriLogger.Debug(exception, messageTemplate);
        }

        public void Debug<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            seriLogger.Debug(exception, messageTemplate, propertyValue);
        }

        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Debug(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Debug(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Debug(exception, messageTemplate, propertyValues);
        }

        //**********************************************************************************************

        public void Information(string messageTemplate)
        {
            seriLogger.Information(messageTemplate);
        }

        public void Information<T1>(string messageTemplate, T1 propertyValue)
        {
            seriLogger.Information(messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Information(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Information(messageTemplate, propertyValues);
        }

        public void Information(Exception exception, string messageTemplate)
        {
            seriLogger.Information(exception, messageTemplate);
        }

        public void Information<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            seriLogger.Information(exception, messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Information(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Information(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Information(exception, messageTemplate, propertyValues);
        }

        //****************************************************************************************

        public void Warning(string messageTemplate)
        {
            seriLogger.Warning(messageTemplate);
        }

        public void Warning<T1>(string messageTemplate, T1 propertyValue)
        {
            seriLogger.Warning(messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Warning(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Warning(messageTemplate, propertyValues);
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            seriLogger.Warning(exception, messageTemplate);
        }

        public void Warning<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            seriLogger.Warning(exception, messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Warning(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Warning(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Warning(exception, messageTemplate, propertyValues);
        }

        //**********************************************************************************************************

        public void Error(string messageTemplate)
        {
            seriLogger.Error(messageTemplate);
        }

        public void Error<T1>(string messageTemplate, T1 propertyValue)
        {
            seriLogger.Error(messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Error(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Error(messageTemplate, propertyValues);
        }

        public void Error(Exception exception)
        {
            seriLogger.Error(exception, "Exception Encountered");
        }


        public void Error(Exception exception, string messageTemplate)
        {
            seriLogger.Error(exception, messageTemplate);
        }

        public void Error<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            seriLogger.Error(exception, messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Error(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Error(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Error(exception, messageTemplate, propertyValues);
        }

        //*************************************************************************

        public void Fatal(string messageTemplate)
        {
            seriLogger.Fatal(messageTemplate);
        }

        public void Fatal<T1>(string messageTemplate, T1 propertyValue)
        {
            seriLogger.Fatal(messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Fatal(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Fatal(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Fatal(messageTemplate, propertyValues);
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            seriLogger.Fatal(exception, messageTemplate);
        }

        public void Fatal<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            seriLogger.Fatal(exception, messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            seriLogger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            seriLogger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            seriLogger.Fatal(exception, messageTemplate, propertyValues);
        }


       

    }
}
