using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    public class PSPlayGame : PlayGame
    {
        public override void OpenConsole()
        {
            Console.WriteLine($"Open PS");
        }

        //this method not called
        private void OpenTv()
        {
            Console.WriteLine($"PSPlayGame TV");
        }
    }
}
