using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim.behaviors
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("fly with wings");
        }
    }
}
