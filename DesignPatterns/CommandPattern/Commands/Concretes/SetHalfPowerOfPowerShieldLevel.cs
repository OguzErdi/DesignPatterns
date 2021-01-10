using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class SetHalfPowerOfPowerShieldLevel : ICommand
    {
        private readonly PowerShieldSystem powerShieldSystem;
        //You can add state to extend functionality
        private int prevLevel;

        public SetHalfPowerOfPowerShieldLevel(PowerShieldSystem powerShieldSystem)
        {
            this.powerShieldSystem = powerShieldSystem;
        }

        public void Execute()
        {
            prevLevel = this.powerShieldSystem.Level;
            powerShieldSystem.SetHalfPower();
        }

        public void Undo()
        {
            int powerLevelDiff = powerShieldSystem.Level - prevLevel;

            int count = powerLevelDiff / 10;

            if (powerLevelDiff > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    powerShieldSystem.DecreasePowerShieldLevel();
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    powerShieldSystem.DecreasePowerShieldLevel();
                }
            }
        }
    }
}
