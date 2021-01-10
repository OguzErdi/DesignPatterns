using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Receiver
{
    public class WeaponSystem
    {
        public void LockedToEnemy()
        {
            Console.WriteLine("WeaponSystem Locked to Enemy");
        }

        public void ReleaseEnemy()
        {
            Console.WriteLine("WeaponSystem Release Enemy");
        }

        public void Attack()
        {
            Console.WriteLine("WeaponSystem Start Attack");
        }

        public void StopAttack()
        {
            Console.WriteLine("WeaponSystem Stop Attack");
        }

        public void Reload()
        {
            Console.WriteLine("WeaponSystem Reload All Weapons");
        }

        public void UnLoad()
        {
            Console.WriteLine("WeaponSystem UnLoad All Weapons");
        }
    }
}
