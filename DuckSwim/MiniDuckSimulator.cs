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
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.PerformSwim();
            Console.WriteLine();

            RoastDuck roast = new RoastDuck();
            roast.Display();
            roast.PerformFly();
            roast.PerformQuack();
            roast.PerformSwim();
            Console.WriteLine();

            WoodenDuck wooden = new WoodenDuck();
            wooden.Display();
            wooden.PerformFly();
            wooden.PerformQuack();
            wooden.PerformSwim();

        }
    }
}
