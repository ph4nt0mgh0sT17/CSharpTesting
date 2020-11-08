using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTest
{
    class ConsoleLogger : ILogger
    {
        private string mPrependLog = "ConsoleLogger";

        public ConsoleLogger(string prependLog)
        {
            mPrependLog = prependLog;
        }

        public void Log(string message)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine($"[{mPrependLog}][{now}] - {message}");
        }
    }
}
