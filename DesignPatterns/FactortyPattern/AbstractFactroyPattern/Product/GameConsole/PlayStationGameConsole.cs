using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole
{
    public class PlayStationGameConsole : IGameConsole
    {

        public void OpenConsole()
        {
            Console.WriteLine("Push PlayStation power button.");
        }
    }
}
