using DesignPatterns.ProxyPattern.Interface;
using DesignPatterns.ProxyPattern.RealObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Proxy
{
    /// <summary>
    /// This is a Remote Proxy Example
    /// There is more Proxy types, such as Virtual Proxy, Caching Proxy, Firewall Proxy etc. These just have different implemantation according to own purposes.
    /// Also note that, there is no need to wrap real object, for expamle Virtual Proxy.
    /// Can be like Decoratore but, didn't. Proxy's intent is CONTROL ACCESS on real object.
    /// </summary>
    public class GameStreamingService : PlayGame
    {
        private readonly SuperGamingPc superGamingPC;

        public GameStreamingService(SuperGamingPc superGamingPC)
        {
            this.superGamingPC = superGamingPC;
        }

        public void OpenGame()
        {
            Console.WriteLine($"Open Game over internet");
            superGamingPC.OpenGame();
        }

        public void CloseGame()
        {
            Console.WriteLine($"Close Game over internet");
            superGamingPC.CloseGame();
        }
    }
}
