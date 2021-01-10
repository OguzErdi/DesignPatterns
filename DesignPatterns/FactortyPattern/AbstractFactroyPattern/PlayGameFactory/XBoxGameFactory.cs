using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameCd;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGameFactroy
{
    public class XBoxGameFactory : IPlayGameFactroy
    {
        public IGameCd CreateGameCd()
        {
            return new XBoxGameCd();
        }

        public IGameConsole CreateGameConsole()
        {
            return new XboxGameConsole();
        }

        public IGameController CreateGameController()
        {
            return new XboxGameController();
        }
    }
}
