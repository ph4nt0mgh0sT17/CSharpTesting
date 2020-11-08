using System;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger("ValhallaLogger");
            ILogger fileLogger = new FileLogger("FileMikriteLogger", @"D:\Logs\Mikrite\OsuLogger.txt");

            fileLogger.Log("XDDDDDDDD");
            fileLogger.Log("XDDDDDDDD");
            fileLogger.Log("XDDDDDDDD");
            fileLogger.Log("XDDDDDDDD");
            fileLogger.Log("XDDDDDDDD");
            fileLogger.Log("XDDDDDDDD");
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD"); 
            fileLogger.Log("XDDDDDDDD");


            logger.Log("Maminka snedla babovku.");
        }
    }
}
