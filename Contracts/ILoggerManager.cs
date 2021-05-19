namespace Contracts
{
    /// <summary>
    /// Provides methods to Logger
    /// </summary>
    public interface ILoggerManager
    {
        /// <summary>
        /// Log info
        /// </summary>
        /// <param name="message">Message</param>        
        void LogInfo(string message);

        /// <summary>
        /// Log Warnig
        /// </summary>
        /// <param name="message">Message</param>
        void LogWarn(string message);

        /// <summary>
        /// Log Debug
        /// </summary>
        /// <param name="message">Message</param>
        void LogDebug(string message);

        /// <summary>
        /// Log Error
        /// </summary>
        /// <param name="message">Message</param>
        void LogError(string message);
    }
}
