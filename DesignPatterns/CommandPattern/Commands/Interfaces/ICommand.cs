using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
