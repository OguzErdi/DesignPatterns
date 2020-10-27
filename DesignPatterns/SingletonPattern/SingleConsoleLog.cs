using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    public class SingleConsoleLog
    {
        private static readonly object padlock = new object();
        private static SingleConsoleLog _instance;

        private SingleConsoleLog(){}

        public static SingleConsoleLog GetInstance()
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new SingleConsoleLog();
                }
            }

            return _instance;
        }

        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
