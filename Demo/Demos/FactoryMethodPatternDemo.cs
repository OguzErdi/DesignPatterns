using DesignPatterns.FactortyPattern.FactoryMethodPattern.PlayGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class FactoryMethodPatternDemo
    {
        public static void Start()
        {
            PlayGame playStationPlayGame = new PlayStationPlayGame();
            PlayGame xBoxPlayGame = new XBoxPlayGame();

            playStationPlayGame.Start();
            xBoxPlayGame.Start();
        }
    }
}
