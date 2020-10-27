using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole
{
    public class XboxGameConsole : IGameConsole
    {
        public void OpenConsole()
        {
            Console.WriteLine("Push Xbox power button.");
        }
    }
}
