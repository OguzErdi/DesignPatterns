using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.SingletonPattern;
using System.Threading;
using DesignPatterns.CommandPattern.Invoker;
using DesignPatterns.CommandPattern.Commands.Concretes;
using DesignPatterns.CommandPattern.Commands;
using DesignPatterns.CommandPattern.Receiver;

namespace Demo.Demos
{
    public class CommandPatternDemo
    {
        public static void Start()
        {
            //Invoker
            SpaceShipsCommandConsole spaceShipsCommandConsole = new SpaceShipsCommandConsole();

            //Receivers
            PowerShieldSystem powerShieldSystem = new PowerShieldSystem();
            WeaponSystem weaponSystem = new WeaponSystem();

            //Requests
            ICommand aimEnemy = new AimEnemy(weaponSystem);
            ICommand attack = new Attack(weaponSystem);
            ICommand reloadWeapons = new ReloadWeapons(weaponSystem);
            ICommand openPowerShield = new OpenPowerShield(powerShieldSystem);
            ICommand closePowerShield = new ClosePowerShield(powerShieldSystem);
            ICommand decreasePowerShield = new DecreasePowerShieldLevel(powerShieldSystem);
            ICommand increasePowerShield = new IncreasePowerShieldLevel(powerShieldSystem);
            ICommand setHalfPowerOfPowerShieldLevel = new SetHalfPowerOfPowerShieldLevel(powerShieldSystem);
            ICommand macro = new MacroMode(new List<ICommand> {aimEnemy, attack, openPowerShield, increasePowerShield});

            //Set Commands to Slots
            spaceShipsCommandConsole.SetCommand(0, setHalfPowerOfPowerShieldLevel);
            spaceShipsCommandConsole.SetCommand(1, aimEnemy);
            spaceShipsCommandConsole.SetCommand(2, attack);
            spaceShipsCommandConsole.SetCommand(3, reloadWeapons);
            spaceShipsCommandConsole.SetCommand(4, openPowerShield);
            spaceShipsCommandConsole.SetCommand(5, closePowerShield);
            spaceShipsCommandConsole.SetCommand(7, increasePowerShield);
            spaceShipsCommandConsole.SetCommand(8, decreasePowerShield);
            spaceShipsCommandConsole.SetCommand(9, macro);

            //Try
            spaceShipsCommandConsole.PushButton(1);
            spaceShipsCommandConsole.PushButton(2);
            spaceShipsCommandConsole.PushButton(0);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(3);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(4);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(5);
            spaceShipsCommandConsole.PushButton(6);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(0);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(7);
            spaceShipsCommandConsole.PushButton(7);
            spaceShipsCommandConsole.PushButton(7);
            spaceShipsCommandConsole.PushButton(7);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(8);
            spaceShipsCommandConsole.PushButton(0);
            spaceShipsCommandConsole.Undo();
            spaceShipsCommandConsole.PushButton(8);
            spaceShipsCommandConsole.PushButton(9);
            spaceShipsCommandConsole.Undo();
        }
    }
}
