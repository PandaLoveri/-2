using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSwim
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
        }
    }
}
