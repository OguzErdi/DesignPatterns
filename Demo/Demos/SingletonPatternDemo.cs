using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.SingletonPattern;
using System.Threading;

namespace Demo.Demos
{
    public class SingletonPatternDemo
    {
        public static void Start()
        {

            Thread t1 = new Thread(new ThreadStart(LogTextForThread1));
            Thread t2 = new Thread(new ThreadStart(LogTextForThread2));
            t1.Start();
            t2.Start();
        }

        public static void LogTextForThread1()
        {

            SingleConsoleLog singleConsoleLog = SingleConsoleLog.GetInstance();
            singleConsoleLog.Log("Thread 1 Log");
        }
        public static void LogTextForThread2()
        {

            SingleConsoleLog singleConsoleLog = SingleConsoleLog.GetInstance();
            singleConsoleLog.Log("Thread 2 Log");
        }
    }
}
