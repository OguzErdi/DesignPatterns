using DesignPatterns.StatePattern.Context;
using DesignPatterns.StatePattern.State.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.State.Interface
{
    public class OffState : TVState
    {
        private readonly TV tv;

        public OffState(TV tv)
        {
            this.tv = tv;
        }

        public void PlugIn()
        {
            Console.WriteLine("Plugged In");
            tv.SetState(tv.OnState);
        }

        public void RemovePower()
        {
            Console.WriteLine("Already there is no power");
        }

        public void PressStandbyButton()
        {
            Console.WriteLine("No Action");
        }

        public void PressStartButton()
        {
            Console.WriteLine("No Action");
        }

        public override string ToString()
        {
            return "OffState";
        }
    }
}
