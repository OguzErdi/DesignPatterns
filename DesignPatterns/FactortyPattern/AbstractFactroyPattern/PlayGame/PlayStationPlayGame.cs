using DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGameFactroy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGame
{
    public class PlayStationPlayGame : PlayGame
    {
        protected override void PrepateItems()
        {
            PlayStationGameFactory playStationGameFactory = new PlayStationGameFactory();
            gameCd = playStationGameFactory.CreateGameCd();
            gameConsole = playStationGameFactory.CreateGameConsole();
            gameController = playStationGameFactory.CreateGameController();
        }
    }
}
