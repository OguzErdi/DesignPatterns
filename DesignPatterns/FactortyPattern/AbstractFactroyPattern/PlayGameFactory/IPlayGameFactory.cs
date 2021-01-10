using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameCd;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGameFactroy
{
    interface IPlayGameFactroy
    {
        IGameCd CreateGameCd();
        IGameConsole CreateGameConsole();
        IGameController CreateGameController();
    }
}
