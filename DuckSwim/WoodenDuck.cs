using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.behaviors;

namespace DuckSwim
{
    class WoodenDuck : Duck
    {
        public WoodenDuck() : base()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("WoodenDuck display");
        }
    }
}
