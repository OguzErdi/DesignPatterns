using DesignPatterns.StatePattern.State.Concretes;
using DesignPatterns.StatePattern.State.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern.Context
{
    public class TV
    {
        public TVState OffState { get; }
        public TVState OnState { get; }
        public TVState StandbyState { get; }
        public TVState StartState { get; }

        private TVState currentState;

        public TV()
        {
            OffState = new OffState(this);
            OnState = new OnState(this);
            StandbyState = new StandbyState(this);
            StartState = new StartState(this);
            currentState = OffState;
        }

        public void PlugIn()
        {
            currentState.PlugIn();
        }

        public void RemovePower()
        {
            currentState.RemovePower();
        }

        public void PressStandbyButton()
        {
            currentState.PressStandbyButton();
        }

        public void PressStartButton()
        {
            currentState.PressStartButton();
        }

        public void SetState(TVState tVState)
        {
            currentState = tVState;
            Console.WriteLine($"State changed to \"{tVState}\"");
        }


    }
}
