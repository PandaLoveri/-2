using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim.behaviors
{
    public class ReactFly :IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("react fly");
        }
    }
}
