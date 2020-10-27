using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.AbstractFactroyPattern.Product.GameCd
{
    public class PlayStationGameCd : IGameCd
    {
        public void InsertGame()
        {
            Console.WriteLine("Insert the PlayStation Game CD.");
        }
    }
}
