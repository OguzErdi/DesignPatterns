using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole
{
    public class PlayStationGameController : IGameController
    {
        public void StartGame()
        {
            Console.WriteLine("Push A button on the PlayStation Controller.");
        }

    }
}
