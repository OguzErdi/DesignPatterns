using DesignPatterns.AdapterPattern.Adaptee.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.Adaptee
{
    public class Bicycle : IBicycle
    {
        public void StartTurnPedal()
        {
            Console.WriteLine($"Start turn pedals.");
        }

        public void Stop()
        {
            Console.WriteLine($"Squeeze the brakes of the bike");
        }
    }
}
