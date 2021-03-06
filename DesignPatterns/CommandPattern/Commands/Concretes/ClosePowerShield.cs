﻿using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class ClosePowerShield : ICommand
    {
        private readonly PowerShieldSystem powerShieldSystem;

        public ClosePowerShield(PowerShieldSystem powerShieldSystem)
        {
            this.powerShieldSystem = powerShieldSystem;
        }

        public void Execute()
        {
            powerShieldSystem.Close();
        }

        public void Undo()
        {
            powerShieldSystem.Open();
        }
    }
}
