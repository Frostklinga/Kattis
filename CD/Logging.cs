using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kattis.CD
{
    public static class MethodTimeLogger
    {
        //public static ILogger logger;

        static ILogger logger = new LoggerConfiguration()
                            .WriteTo.Console()
                            .WriteTo.Debug()
                            .CreateLogger();

        public static void Log(MethodBase methodBase, TimeSpan time, string message)
        {
            logger.Fatal("{Class}.{Method} {Duration}",
                methodBase.DeclaringType!.Name, methodBase.Name, time);
        }
    }
    public static class GeneralLogging
    {
        static ILogger logger = new LoggerConfiguration()
                            .WriteTo.Console()
                            .WriteTo.Debug()
                            .CreateLogger();
        public static void Log(string message)
        {
            logger.Fatal (message);
        }
    }
}
