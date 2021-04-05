using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Discount : CondimentDecorator
    {
        private Beverage beverage;

        public Discount(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Discount";
        }

        public override double cost()
        {
            return Math.Round(beverage.cost() * (100 - 20) / 100, 2);
        }
    }
}
