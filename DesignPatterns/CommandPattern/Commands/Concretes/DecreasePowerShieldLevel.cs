using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class DecreasePowerShieldLevel : ICommand
    {
        private readonly PowerShieldSystem powerShieldSystem;

        public DecreasePowerShieldLevel(PowerShieldSystem powerShieldSystem)
        {
            this.powerShieldSystem = powerShieldSystem;
        }

        public void Execute()
        {
            powerShieldSystem.DecreasePowerShieldLevel();
        }

        public void Undo()
        {
            powerShieldSystem.IncreasePowerShieldLevel();
        }
    }
}
