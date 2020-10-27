using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.FactoryMethodPattern.GameConsole
{
    public class PlayStationGameConsole : IGameConsole
    {
        public void InsertGame()
        {
            Console.WriteLine("Insert the game in PlayStation.");
        }

        public void OpenConsole()
        {
            Console.WriteLine("Push PlayStation power button.");
        }

        public void StartGame()
        {
            Console.WriteLine("Find game in PlayStation menu and push A button.");
        }
    }
}
