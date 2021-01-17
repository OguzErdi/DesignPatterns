using DesignPatterns.AdapterPattern.Adaptee.Interface;
using DesignPatterns.AdapterPattern.TargetInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.Adapter
{
    public class BicycleAsCar : ICar
    {
        IBicycle bicycle;

        public BicycleAsCar(IBicycle bicycle)
        {
            this.bicycle = bicycle;
        }

        public void Break()
        {
            bicycle.Stop();
        }

        public void StartEngine()
        {
            bicycle.StartTurnPedal();
        }
    }
}
