using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Soy:CondimentDecorator
    {
        private Beverage beverage;

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
            return PriceList.soyPrice + beverage.cost();
        }
    }
}
