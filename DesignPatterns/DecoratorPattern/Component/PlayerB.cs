using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Component
{
    public class PlayerB : PlayerBase
    {
        public PlayerB()
        {
            Name = "Player B";
            AttackDamage = 5;
            JumpHeight = 15;
            Speed = 20;
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
