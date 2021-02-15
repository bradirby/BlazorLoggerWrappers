using System;
using log4net;

namespace LogWrappers
{
    public class Log4NetWrapper : IMessageLogger
    {
        private ILog _logger;

        private ILog logger => _logger ??= LogManager.GetLogger("Unknown");

        public void SetLoggerType<T>()
        {
            _logger = LogManager.GetLogger(typeof(T));
        }

        public void Debug(string messageTemplate)
        {
            logger.Debug(messageTemplate);
        }

        public void Debug<T>(string messageTemplate, T propertyValue)
        {
            logger.DebugFormat(messageTemplate,propertyValue);
        }

        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.DebugFormat(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.DebugFormat(messageTemplate, propertyValue0, propertyValue1, propertyValue2); 
        }

        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            logger.DebugFormat(messageTemplate, propertyValues);
        }

        public void Debug(Exception exception, string messageTemplate)
        {
            logger.Debug(messageTemplate, exception);
        }

        public void Debug<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            logger.Debug($"{messageTemplate} {propertyValue}",exception);
        }

        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.Debug($"{messageTemplate} {propertyValue0} {propertyValue1}", exception);
        }

        public void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.Debug($"{messageTemplate} {propertyValue0} {propertyValue1} {propertyValue2}", exception);
        }

        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            logger.Debug($"{messageTemplate} {propertyValues}", exception);
        }

        public void Information(string messageTemplate)
        {
            logger.Info(messageTemplate);
        }

        public void Information<T>(string messageTemplate, T propertyValue)
        {
            logger.InfoFormat(messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.InfoFormat(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.InfoFormat(messageTemplate,propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            logger.InfoFormat(messageTemplate, propertyValues);
        }

        public void Information(Exception exception, string messageTemplate)
        {
            logger.Info(messageTemplate, exception);
        }

        public void Information<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            logger.InfoFormat($"{exception.Message} {messageTemplate}",propertyValue);
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.InfoFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.InfoFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            logger.InfoFormat($"{exception.Message} {messageTemplate}", propertyValues);
        }

        public void Warning(string messageTemplate)
        {
            logger.Warn(messageTemplate);
        }

        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            logger.WarnFormat(messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.WarnFormat(messageTemplate,propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.WarnFormat(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            logger.WarnFormat(messageTemplate, propertyValues);
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            logger.Warn(messageTemplate,exception);
        }

        public void Warning<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            logger.WarnFormat($"{exception.Message} {messageTemplate}", propertyValue);
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.WarnFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.WarnFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            logger.WarnFormat($"{exception.Message} {messageTemplate}", propertyValues);
        }

        public void Error(string messageTemplate)
        {
            logger.Error(messageTemplate);
        }

        public void Error<T>(string messageTemplate, T propertyValue)
        {
            logger.ErrorFormat(messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.ErrorFormat(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.ErrorFormat(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            logger.ErrorFormat(messageTemplate, propertyValues);
        }

        public void Error(Exception exception)
        {
            logger.Error(exception);
        }

        public void Error(Exception exception, string messageTemplate)
        {
            logger.Error(messageTemplate, exception);
        }

        public void Error<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            logger.ErrorFormat($"{exception.Message} {messageTemplate}",propertyValue);
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.ErrorFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.ErrorFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            logger.ErrorFormat($"{exception.Message} {messageTemplate}", propertyValues);
        }

        public void Fatal(string messageTemplate)
        {
            logger.Fatal(messageTemplate);
        }

        public void Fatal<T>(string messageTemplate, T propertyValue)
        {
            logger.FatalFormat(messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.FatalFormat(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.FatalFormat(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            logger.FatalFormat(messageTemplate, propertyValues);
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            logger.Fatal(messageTemplate,exception);
        }

        public void Fatal<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            logger.FatalFormat($"{exception.Message} {messageTemplate}", propertyValue);
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            logger.FatalFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            logger.FatalFormat($"{exception.Message} {messageTemplate}", propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            logger.FatalFormat($"{exception.Message} {messageTemplate}", propertyValues);
        }
    }
}
