using NLog;
using System;
namespace StaticClass
{
    public static class Hata
    {
        static Logger _logger = LogManager.GetCurrentClassLogger();
        public static void tryCatch(Action Action)
        {
            try
            {
                Action.Invoke();
            }
            catch (Exception exception)
            {
                MessageBoxOperation.MessageBoxError(exception.Message);
                Logging(exception);
            }
        }
        public static void Logging(Exception exception)
        {
            try
            {
                _logger.Debug(exception.Message);
            }
            catch (Exception _exception)
            {
                MessageBoxOperation.MessageBoxError("Loglama Yapılamadı. "+_exception.Message);
            }
        }
    }
}
