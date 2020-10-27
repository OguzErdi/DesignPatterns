using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole
{
    public class XboxGameController : IGameController
    {
        public void StartGame()
        {
            Console.WriteLine("Push X button on the XBox Controller.");
        }
    }
}
