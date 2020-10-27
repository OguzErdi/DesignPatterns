using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactortyPattern.FactoryMethodPattern.GameConsole
{
    public class XboxGameConsole : IGameConsole
    {
        public void InsertGame()
        {
            Console.WriteLine("Insert the game in Xbox.");
        }

        public void OpenConsole()
        {
            Console.WriteLine("Push Xbox power button.");
        }

        public void StartGame()
        {
            Console.WriteLine("Find game in Xbox menu and push X button.");
        }
    }
}
