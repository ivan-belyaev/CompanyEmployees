using Contracts;
using NLog;

namespace LoggerService
{
    /// <summary>
    /// Logger Manager
    /// </summary>
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Logger Manager ctor
        /// </summary>
        public LoggerManager()
        {
            // empty because GetCurrentClassLogger
        }

        /// <inheritdoc/>
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        /// <inheritdoc/>
        public void LogError(string message)
        {
            logger.Error(message);
        }

        /// <inheritdoc/>
        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        /// <inheritdoc/>
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }

    }
}
