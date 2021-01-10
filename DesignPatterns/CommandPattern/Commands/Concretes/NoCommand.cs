using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Do Nothing");
        }

        public void Undo()
        {
            Console.WriteLine("Do Nothing");
        }
    }
}
