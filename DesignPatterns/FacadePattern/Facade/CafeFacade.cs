using DesignPatterns.FacadePattern.SubSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattern.Facade
{
    public class CafeFacade
    {
        readonly Kitchen kitchen;
        readonly Cashier cashier;

        public CafeFacade(Kitchen kitchen, Cashier cashier)
        {
            this.kitchen = kitchen;
            this.cashier = cashier;
        }

        public void OpenCafe()
        {
            kitchen.OpenAspirator();
            kitchen.OpenStove();
            cashier.OpenPosDevice();
        }

        public void CloseCafe()
        {

            kitchen.CloseAspirator();
            kitchen.CloseStove();
            cashier.OpenPosDevice();
        }
    }
}
