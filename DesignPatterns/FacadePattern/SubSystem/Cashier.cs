using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattern.SubSystem
{
    public class Cashier
    {
        public void OpenPosDevice()
        {
            Console.WriteLine($"Open POS device");
        }

        public void ClosePosDevice()
        {
            Console.WriteLine($"Close POS device");
        }
    }
}
