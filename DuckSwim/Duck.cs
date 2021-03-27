using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim
{
    public abstract class Duck
    {
        protected IFlyable flyBehavior;
        protected IQuackable quackBehavior;
        protected ISwimmable swimBehavior;

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformSwim()
        {
            swimBehavior.Swim();
        }

        public abstract void Display();       
        
    }
}
