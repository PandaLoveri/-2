using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    public class Mocha: CondinmentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return 0.2 + beverage.cost();
        }
    }
}
