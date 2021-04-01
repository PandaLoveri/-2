using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Whip:CondinmentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.30 + beverage.cost();
        }
    }
}
