using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.State.Concretes
{
    public interface TVState
    {
        void PlugIn();
        void PressStartButton();
        void PressStandbyButton();
        void RemovePower();
    }
}
