using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.behaviors;

namespace DuckSwim
{
    class RoastDuck : Duck
    {
        public RoastDuck() : base()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
            swimBehavior = new Sink();
        }

        public override void Display()
        {
            Console.WriteLine("RoastDuck display");
        }
    }
}
