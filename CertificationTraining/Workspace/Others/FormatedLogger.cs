using System;

namespace CertificationTraining.Workspace.Others
{
    public delegate string MessageFormatter(string format, params object[] eventArgs);

    public sealed class FormatedLogger
    {
        public bool IsEnabled => true;
        
        public void LogMessage(Func<MessageFormatter, string> message, Exception ex = null)
        {
            if (!IsEnabled)
            {
                return;
            }

            CallHandler(message, ex, Console.WriteLine, Console.WriteLine);
        }

        static void CallHandler(
            Func<MessageFormatter, string> message,
            Exception ex,
            Action<object> logMessage,
            Action<object> logMessageEx)
        {
            if (ex == null)
            {
                logMessage(message(string.Format));
            }
            else
            {
                logMessageEx(message(string.Format) + Environment.NewLine + ex);
            }
        }
    }

    public static class FormatedLoggerTests
    {
        public static void VerboseRun()
        {
            FormatedLogger logger = new FormatedLogger();
            
            // Those calls all only format the string when the m function is executed, not before.
            // In this sense, they are all alright, however:

            // Either of two are the way to do it
            logger.LogMessage(m => $"Log this number: {123}");
            logger.LogMessage(m => m("Log this number: {0}", 123));

            // Those are not really ok
            // They call Format again even tho the string is already formatted by $, +, or the methods
            logger.LogMessage(m => m($"Log this number: {123}"));
            logger.LogMessage(m => m("Log this number: " + 123));
            logger.LogMessage(m => m(string.Format("Log this number: {0}", 123)));
            logger.LogMessage(m => m(string.Concat("Log this number: ", 123)));
        }
    }
}
