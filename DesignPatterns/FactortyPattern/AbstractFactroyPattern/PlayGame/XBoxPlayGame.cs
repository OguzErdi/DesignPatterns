using DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGameFactroy;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameCd;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGame
{
    public class XBoxPlayGame : PlayGame
    {
        protected override void PrepateItems()
        {
            XBoxGameFactory xBoxGameFactory = new XBoxGameFactory();
            gameCd = xBoxGameFactory.CreateGameCd();
            gameConsole = xBoxGameFactory.CreateGameConsole();
            gameController = xBoxGameFactory.CreateGameController();
        }
    }
}
