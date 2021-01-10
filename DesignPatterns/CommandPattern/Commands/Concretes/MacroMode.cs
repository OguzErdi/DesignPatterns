using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class MacroMode : ICommand
    {
        private readonly List<ICommand> commands;

        public MacroMode(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commands)
            {
                command.Undo();
            }
        }
    }
}
