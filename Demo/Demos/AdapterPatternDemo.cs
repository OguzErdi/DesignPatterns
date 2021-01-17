using DesignPatterns.AdapterPattern.Adaptee;
using DesignPatterns.AdapterPattern.Adaptee.Interface;
using DesignPatterns.AdapterPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class AdapterPatternDemo
    {
        public static void Start()
        {
            IBicycle bicycle = new Bicycle();
            BicycleAsCar bicycleAsCar = new BicycleAsCar(bicycle);

            bicycleAsCar.StartEngine();
            bicycleAsCar.Break();

        }
    }
}
