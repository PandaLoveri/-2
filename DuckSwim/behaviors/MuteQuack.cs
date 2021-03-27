using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim.behaviors
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("mute quack");
        }
    }
}
