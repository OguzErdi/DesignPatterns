using DesignPatterns.CommandPattern.Commands;
using DesignPatterns.CommandPattern.Commands.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CommandPattern.Invoker
{
    public class SpaceShipsCommandConsole
    {
        private const int BUTTON_COUNT = 10;
        private List<ICommand> commands;
        private ICommand prevCommand;

        public SpaceShipsCommandConsole()
        {
            ICommand noCommand = new NoCommand();
            commands = Enumerable.Repeat(noCommand, BUTTON_COUNT).ToList();
        }

        public void SetCommand(int buttonIndex, ICommand command)
        {
            commands[buttonIndex] = command;
        }

        public void PushButton(int buttonIndex)
        {
            Console.WriteLine($"Pushed Button {buttonIndex} ");
            commands[buttonIndex].Execute();
            prevCommand = commands[buttonIndex];
        }

        public void Undo()
        {
            Console.WriteLine($"Pushed Undo Button ");
            prevCommand.Undo();
        }
    }
}
