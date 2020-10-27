using DesignPatterns.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Decorator
{
    public class Tiger : PetDecorator
    {
        public Tiger(PlayerBase player): base(player)
        {
            Name = "Tiger";
            AttackDamage = 20;
            JumpHeight = 5;
            Speed = 5;
        }
        public override void PrintName()
        {
            Player.PrintName();
            Console.WriteLine($"-------{Name}-------");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Player.Name}'s {Name} {AttackDamage} damaged");
            Player.Attack();
        }

        public override void Jump()
        {
            Player.Jump();
            Console.WriteLine($"{Player.Name}'s {Name} {JumpHeight} jumped");
        }

        public override void Run()
        {
            Player.Run();
            Console.WriteLine($"{Player.Name}'s {Name} {Speed} unit ran in one second");
        }

    }
}
