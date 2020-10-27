using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameCd;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameConsole;
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameController;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGame
{
    public abstract class PlayGame
    {
        protected IGameConsole gameConsole;
        protected IGameCd gameCd;
        protected IGameController gameController;

        public void Start()
        {
            PrepateItems();
            gameConsole.OpenConsole();
            gameCd.InsertGame();
            gameController.StartGame();
        }

        protected abstract void PrepateItems();
    }
}
