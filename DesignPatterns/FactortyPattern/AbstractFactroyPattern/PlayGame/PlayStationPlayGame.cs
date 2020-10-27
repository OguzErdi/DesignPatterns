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
            PlayStationGameFactroy playStationGameFactroy = new PlayStationGameFactroy();
            gameCd = playStationGameFactroy.CreateGameCd();
            gameConsole = playStationGameFactroy.CreateGameConsole();
            gameController = playStationGameFactroy.CreateGameController();
        }
    }
}
