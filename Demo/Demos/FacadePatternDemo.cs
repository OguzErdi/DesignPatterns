using DesignPatterns.FacadePattern.Facade;
using DesignPatterns.FacadePattern.SubSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demos
{
    public class FacadePatternDemo
    {
        public static void Start()
        {
            Kitchen kitchen = new Kitchen();
            Cashier cashier = new Cashier();

            CafeFacade cafeFacade = new CafeFacade(kitchen, cashier);

            cafeFacade.OpenCafe();
            cafeFacade.CloseCafe();

        }
    }
}
