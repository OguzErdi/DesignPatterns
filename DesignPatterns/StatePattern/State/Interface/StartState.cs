using DesignPatterns.StatePattern.Context;
using DesignPatterns.StatePattern.State.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.State.Interface
{
    public class StartState : TVState
    {
        private readonly TV tv;

        public StartState(TV tv)
        {
            this.tv = tv;
        }

        public void PlugIn()
        {
            Console.WriteLine("Already plugged in");
        }

        public void RemovePower()
        {
            Console.WriteLine("Shot down TV");
            tv.SetState(tv.OffState);
        }

        public void PressStandbyButton()
        {
            Console.WriteLine("Take to Standby mode");
            tv.SetState(tv.StandbyState);
        }

        public void PressStartButton()
        {
            Console.WriteLine("No Action");
        }

        public override string ToString()
        {
            return "StartState";
        }
    }
}
