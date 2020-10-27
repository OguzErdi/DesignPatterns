using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Component
{
    public abstract class PlayerBase
    {
        private string name;
        private int _attackDamage;
        private int _jumpHeight;
        private int _speed;

        public string Name { get => name; set => name = value; }
        public int AttackDamage { get => _attackDamage; set => _attackDamage = value; }
        public int JumpHeight { get => _jumpHeight; set => _jumpHeight = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public abstract void PrintName();
        public abstract void Attack();
        public abstract void Jump();
        public abstract void Run();
    }
}
