using DesignPatterns.TemplateMethodPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class TemplateMethodPatternDemo
    {
        public static void Start()
        {
            PlayGame psPlayGame = new PSPlayGame();
            PlayGame xboxPlayGame = new XBoxPlayGame();

            psPlayGame.StartPlayGame();
            xboxPlayGame.StartPlayGame();
        }
    }
}
