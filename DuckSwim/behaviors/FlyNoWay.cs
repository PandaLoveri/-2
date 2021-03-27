using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim.behaviors
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("fly no way");
        }
    }
}
