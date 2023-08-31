using System.Collections.Generic;

namespace Clinic.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> ItemsToLog)
        {
            foreach (var Log in ItemsToLog)
            {
                // Code to Write Logs
                // ..
            }
        }
    }
}
