using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameCd;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGameFactroy
{
    public class PlayStationGameFactory : IPlayGameFactroy
    {
        public IGameCd CreateGameCd()
        {
            return new PlayStationGameCd();
        }

        public IGameConsole CreateGameConsole()
        {
            return new PlayStationGameConsole();
        }

        public IGameController CreateGameController()
        {
            return new PlayStationGameController();
        }
    }
}
