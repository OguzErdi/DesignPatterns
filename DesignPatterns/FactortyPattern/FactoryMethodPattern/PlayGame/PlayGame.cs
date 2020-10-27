using DesignPatterns.FactortyPattern.FactoryMethodPattern.GameConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.FactoryMethodPattern.PlayGame
{
    public abstract class PlayGame
    {
        public void Start()
        {
            var gameConsole = CreateGameConsole();
            gameConsole.OpenConsole();
            gameConsole.InsertGame();
            gameConsole.StartGame();
        }

        //Factroy Method
        protected abstract IGameConsole CreateGameConsole();
    }
}
