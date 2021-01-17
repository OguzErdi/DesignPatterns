using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattern.SubSystem
{
    public class Kitchen
    {
        public void OpenStove()
        {
            Console.WriteLine($"Open Stove");
        }

        public void CloseStove()
        {
            Console.WriteLine($"Close Stove");
        }

        public void OpenAspirator()
        {
            Console.WriteLine($"Open Aspirator");
        }

        public void CloseAspirator()
        {
            Console.WriteLine($"Close Aspirator");
        }
    }
}
