using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class PlayGame
    {
        //template method
        public void StartPlayGame() {
            OpenTv();
            OpenConsole();
            FindAGoodCouchAndSit();
            if (WannaSnack())
            {
                GetSnakcs();
            }
        }
        protected void OpenTv()
        {
            Console.WriteLine($"Open TV");
        }

        protected void FindAGoodCouchAndSit()
        {
            Console.WriteLine($"Find a Good Couch And Sit");
        }

        protected void GetSnakcs()
        {
            Console.WriteLine($"Get Snakcs");
        }

        //hook method
        //subclass may want to override but not must -> add virtual
        protected virtual bool WannaSnack()
        {
            return true;
        }

        //subclass have to override -> add abstract
        public abstract void OpenConsole();
    }
}
