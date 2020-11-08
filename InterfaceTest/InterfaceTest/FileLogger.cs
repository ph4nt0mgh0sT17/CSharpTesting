using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfaceTest
{
    class FileLogger : ILogger
    {
        private string mLoggerName;
        private string mFilePath;

        public FileLogger(string loggerName, string filePath)
        {
            mLoggerName = loggerName;
            mFilePath = filePath;
        }

        public void Log(string message)
        {
            if (!File.Exists(mFilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(mFilePath));
            }

            File.AppendAllText(mFilePath, $"[{mLoggerName}][{DateTime.Now}] - {message} \n");
        }
    }
}
