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
            XBoxGameFactroy xBoxGameFactroy = new XBoxGameFactroy();
            gameCd = xBoxGameFactroy.CreateGameCd();
            gameConsole = xBoxGameFactroy.CreateGameConsole();
            gameController = xBoxGameFactroy.CreateGameController();
        }
    }
}
