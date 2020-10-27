
using DesignPatterns.FactortyPattern.AbstractFactroyPattern.PlayGame;

namespace Demo.Demos
{
    public class AbstractFactoryPatternDemo
    {
        public static void Start()
        {
            //I uses no If-else block By the power of AFP, DI and Polymorhism 
            PlayStationPlayGame playStationPlayGame = new PlayStationPlayGame();
            XBoxPlayGame xBoxPlayGame = new XBoxPlayGame();

            playStationPlayGame.Start();
            xBoxPlayGame.Start();
        }
    }
}
