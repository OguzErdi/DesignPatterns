using DesignPatterns.FactortyPattern.FactoryMethodPattern.GameConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.FactoryMethodPattern.PlayGame
{
    public class PlayStationPlayGame : PlayGame
    {
        protected override IGameConsole CreateGameConsole()
        {
            return new PlayStationGameConsole();
        }
    }
}
