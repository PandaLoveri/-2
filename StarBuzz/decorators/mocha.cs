using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Mocha: CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            if (beverage.getDescription().Contains("Mocha"))
                return beverage.getDescription().Replace("Mocha", "Double Mocha");
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return PriceList.mochaPrice + beverage.cost();
        }
    }
}
