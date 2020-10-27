using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Component
{
    public class PlayerA : PlayerBase
    {
        public PlayerA()
        {
            Name = "Player A";
            AttackDamage = 10;
            JumpHeight = 15;
            Speed = 5;
        }
        public override void PrintName()
        {
            Console.WriteLine($"-------{Name}-------");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} {AttackDamage} unit demaged");
        }

        public override void Jump()
        {
            Console.WriteLine($"{Name} {JumpHeight} unit jumped");
        }

        public override void Run()
        {
            Console.WriteLine($"{Name} {Speed} unit ran in one second");
        }

    }
}
