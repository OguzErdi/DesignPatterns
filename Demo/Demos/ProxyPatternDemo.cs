using DesignPatterns.ProxyPattern.Proxy;
using DesignPatterns.ProxyPattern.RealObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class ProxyPatternDemo
    {
        public static void Start()
        {
            SuperGamingPc superGamingPc = new SuperGamingPc();
            GameStreamingService gameStreamingService = new GameStreamingService(superGamingPc);

            gameStreamingService.OpenGame();
            gameStreamingService.CloseGame();
        }
    }
}
