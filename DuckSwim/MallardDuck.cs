using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.behaviors;

namespace DuckSwim
{
    class MallardDuck : Duck
    {
        public MallardDuck(): base()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quackle();
        }

        public override void Display()
        {
            Console.WriteLine("MallardDuck display");
        }
    }
}
