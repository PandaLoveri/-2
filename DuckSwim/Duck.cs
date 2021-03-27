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

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public abstract void Display();
        public void Swim() 
        {
            Console.WriteLine("All ducks float, even decoys!");        
        }
        
    }
}
