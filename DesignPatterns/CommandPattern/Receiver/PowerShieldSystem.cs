using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Receiver
{
    public class PowerShieldSystem
    {
        public int Level { get; set; } = 10;

        public void Open()
        {
            Console.WriteLine("Open Power Shield");
        }

        public void Close()
        {
            Console.WriteLine("Close Power Shield");
        }

        public void IncreasePowerShieldLevel()
        {
            Level+=10;
            Console.WriteLine($"Increase Power Shield Level to {Level}% ");
        }

        public void DecreasePowerShieldLevel()
        {
            Level-=10;
            Console.WriteLine($"Decrease Power Shield Level to {Level}% ");
        }

        public void SetHalfPower()
        {
            Level = 50;
            Console.WriteLine($"Power Shield Level set to HALF/{Level}%");
        }

    }
}
