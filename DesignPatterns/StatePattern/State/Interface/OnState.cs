using DesignPatterns.StatePattern.Context;
using DesignPatterns.StatePattern.State.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.State.Interface
{
    public class OnState : TVState
    {
        private readonly TV tv;

        public OnState(TV tv)
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
            Console.WriteLine("No action");
        }

        public void PressStartButton()
        {
            Console.WriteLine("Start TV");
            tv.SetState(tv.StartState);
        }

        public override string ToString()
        {
            return "OnState";
        }
    }
}
