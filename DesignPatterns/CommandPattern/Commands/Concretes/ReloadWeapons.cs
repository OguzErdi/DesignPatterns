using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concretes
{
    public class ReloadWeapons : ICommand
    {
        private readonly WeaponSystem weaponSystem;

        public ReloadWeapons(WeaponSystem weaponSystem)
        {
            this.weaponSystem = weaponSystem;
        }

        public void Execute()
        {
            weaponSystem.Reload();
        }

        public void Undo()
        {
            weaponSystem.UnLoad();
        }
    }
}
