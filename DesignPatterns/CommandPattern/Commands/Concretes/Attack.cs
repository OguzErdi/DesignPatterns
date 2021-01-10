using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class Attack : ICommand
    {
        private readonly WeaponSystem weaponSystem;

        public Attack(WeaponSystem weaponSystem)
        {
            this.weaponSystem = weaponSystem;
        }

        public void Execute()
        {
            weaponSystem.Attack();
        }

        public void Undo()
        {
            weaponSystem.StopAttack();
        }
    }
}
