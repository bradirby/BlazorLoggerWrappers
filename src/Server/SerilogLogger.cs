using System;
using System.Diagnostics;
using BlazorLoggerWrappers.Shared;
using Serilog;

namespace BlazorLoggerWrappers.Server
{
      public class SerilogLogger : IMessageLogger
    {
        private LogHistory History = new();
        private  ILogger seriLogger;


        public void SetLoggerType<T>()
        {
            seriLogger = Log.Logger.ForContext<T>();
        }

        public SerilogLogger( )
        {
            seriLogger = Log.Logger;
        }

        
        public void Debug(string messageTemplate)
        {
            History?.Debug(messageTemplate);
            seriLogger.Debug(messageTemplate);
        }

        public void Debug<T1>(string messageTemplate, T1 propertyValue)
        {
            History?.Debug($"{messageTemplate} {propertyValue}");
            seriLogger.Debug(messageTemplate, propertyValue);
        }

        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            History?.Debug($"{messageTemplate} {propertyValue0} {propertyValue1}");
            seriLogger.Debug(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            History?.Debug($"{messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Debug(messageTemplate, propertyValue0, propertyValue1,propertyValue2);
        }

        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            History?.Debug(messageTemplate);
            seriLogger.Debug(messageTemplate, propertyValues);
        }

        public void Debug(Exception exception, string messageTemplate)
        {
            History?.Debug($"{messageTemplate} {exception.Message}");
            seriLogger.Debug(exception, messageTemplate);
        }

        public void Debug<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            History?.Debug($"{messageTemplate} {exception.Message} {propertyValue}");
            seriLogger.Debug(exception, messageTemplate, propertyValue);
        }

        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            History?.Debug($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1}");
            seriLogger.Debug(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            History?.Debug($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Debug(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            History?.Debug(messageTemplate);
            seriLogger.Debug(exception, messageTemplate, propertyValues);
        }

        //**********************************************************************************************

        public void Information(string messageTemplate)
        {
            History?.Information(messageTemplate);
            seriLogger.Information(messageTemplate);
        }

        public void Information<T1>(string messageTemplate, T1 propertyValue)
        {
            History?.Information($"{messageTemplate} {propertyValue}");
            seriLogger.Information(messageTemplate,propertyValue);
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            History?.Information($"{messageTemplate} {propertyValue0} {propertyValue1}");
            seriLogger.Information(messageTemplate,propertyValue0,propertyValue1);
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            History?.Information($"{messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Information(messageTemplate,propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            History?.Information(messageTemplate);
            seriLogger.Information(messageTemplate,propertyValues);
        }

        public void Information(Exception exception, string messageTemplate)
        {
            History?.Information($"{messageTemplate} {exception.Message}");
            seriLogger.Information(exception, messageTemplate);
        }

        public void Information<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            History?.Information($"{messageTemplate} {exception.Message} {propertyValue} ");

            seriLogger.Information(exception, messageTemplate,propertyValue);
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            History?.Information($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} ");
            seriLogger.Information(exception, messageTemplate,propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            History?.Information($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} {propertyValue2} ");
            seriLogger.Information(exception, messageTemplate,propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            History?.Information(messageTemplate);
            seriLogger.Information(exception, messageTemplate, propertyValues);
        }

        //****************************************************************************************

        public void Warning(string messageTemplate)
        {
            History?.Warning(messageTemplate);
            seriLogger.Warning(messageTemplate);
        }

        public void Warning<T1>(string messageTemplate, T1 propertyValue)
        {
            History?.Warning($"{messageTemplate} {propertyValue}");
            seriLogger.Warning(messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            History?.Warning($"{messageTemplate} {propertyValue0} {propertyValue1}");
            seriLogger.Warning(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            History?.Warning($"{messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            History?.Warning(messageTemplate);
            seriLogger.Warning(messageTemplate, propertyValues);
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            History?.Warning($"{messageTemplate} {exception.Message}");
            seriLogger.Warning(exception, messageTemplate);
        }

        public void Warning<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            History?.Warning($"{messageTemplate} {exception.Message} {propertyValue}");

            seriLogger.Warning(exception, messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            History?.Warning($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1}");
            seriLogger.Warning(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            History?.Warning($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Warning(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            History?.Warning(messageTemplate);
            seriLogger.Warning(exception, messageTemplate, propertyValues);
        }

        //**********************************************************************************************************

        public void Error(string messageTemplate)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error(messageTemplate);
            seriLogger.Error(messageTemplate);
        }

        public void Error<T1>(string messageTemplate, T1 propertyValue)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {propertyValue}");
            seriLogger.Error(messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {propertyValue0} {propertyValue1}");
            seriLogger.Error(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} ");
            seriLogger.Error(messageTemplate, propertyValues);
        }

        public void Error(Exception exception)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error(exception.Message);
            seriLogger.Error(exception, "Exception Encountered");
        }

        public void Error( Exception exception, string messageTemplate)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {exception.Message} ");
            seriLogger.Error(exception, messageTemplate);
        }

        public void Error<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {exception.Message} {propertyValue}");
            seriLogger.Error(exception, messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1}");
            seriLogger.Error(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Error(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Error($"{messageTemplate} {exception.Message} ");
            seriLogger.Error(exception, messageTemplate, propertyValues);
        }

        //*************************************************************************

        public void Fatal(string messageTemplate)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} ");
            seriLogger.Fatal( messageTemplate);
        }

        public void Fatal<T1>(string messageTemplate, T1 propertyValue)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {propertyValue}");
            seriLogger.Fatal(messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {propertyValue0} {propertyValue1}");
            seriLogger.Fatal(messageTemplate,  propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Fatal(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} ");
            seriLogger.Fatal(messageTemplate, propertyValues);
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {exception.Message} ");
            seriLogger.Fatal(exception, messageTemplate);
        }

        public void Fatal<T1>(Exception exception, string messageTemplate, T1 propertyValue)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {exception.Message} {propertyValue} ");
            seriLogger.Fatal(exception, messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} ");
            seriLogger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {exception.Message} {propertyValue0} {propertyValue1} {propertyValue2}");
            seriLogger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            if (Debugger.IsAttached) Debugger.Break();
            History?.Fatal($"{messageTemplate} {exception.Message} ");
            seriLogger.Fatal(exception, messageTemplate, propertyValues);
        }


        public void WriteOutLogHistory()
        {
            History.WriteOutLogHistory(this);
        }

        public int MaxHistoryToKeep
        {
            get => History.MaxHistoryToKeep;
            set => History.MaxHistoryToKeep = value;
        }

    }
}
