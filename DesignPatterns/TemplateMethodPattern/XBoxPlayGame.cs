using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    public class XBoxPlayGame : PlayGame
    {
        public override void OpenConsole()
        {
            Console.WriteLine($"Open Xbox");
        }

        protected override bool WannaSnack()
        {
            return false;
        }
    }
}
