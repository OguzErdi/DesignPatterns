using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class AimEnemy : ICommand
    {
        private readonly WeaponSystem weaponSystem;

        public AimEnemy(WeaponSystem weaponSystem)
        {
            this.weaponSystem = weaponSystem;
        }

        public void Execute()
        {
            weaponSystem.LockedToEnemy();
        }

        public void Undo()
        {
            weaponSystem.ReleaseEnemy();
        }
    }
}
