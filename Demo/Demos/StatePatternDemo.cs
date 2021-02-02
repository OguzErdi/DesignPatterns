using DesignPatterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class StatePatternDemo
    {
        public static void Start()
        {
            TV tv = new TV();

            tv.PlugIn();
            tv.RemovePower();
            tv.PlugIn();
            tv.PressStartButton();
            tv.PressStandbyButton();
            tv.PressStandbyButton();
            tv.RemovePower();
            tv.PressStandbyButton();
            tv.RemovePower();
            tv.PressStartButton();
            tv.RemovePower();
            tv.PressStandbyButton();
        }
    }
}
