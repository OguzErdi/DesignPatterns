using DesignPatterns.ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.RealObject
{
    public class SuperGamingPc : PlayGame
    {
        public void OpenGame()
        {
            Console.WriteLine($"Open Game");
        }

        public void CloseGame()
        {
            Console.WriteLine($"Close Game");
        }
        
    }
}
