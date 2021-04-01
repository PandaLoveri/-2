using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Soy:CondinmentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}
