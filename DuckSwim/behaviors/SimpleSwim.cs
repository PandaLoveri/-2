using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim.behaviors
{
    public class SimpleSwim :ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("simple swim");
        }
    }   
}
