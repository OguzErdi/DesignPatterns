using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class IncreasePowerShieldLevel : ICommand
    {
        private readonly PowerShieldSystem powerShieldSystem;

        public IncreasePowerShieldLevel(PowerShieldSystem powerShieldSystem)
        {
            this.powerShieldSystem = powerShieldSystem;
        }

        public void Execute()
        {
            powerShieldSystem.IncreasePowerShieldLevel();
        }

        public void Undo()
        {
            powerShieldSystem.DecreasePowerShieldLevel();
        }
    }
}
