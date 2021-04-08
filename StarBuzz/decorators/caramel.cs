using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Сaramel:CondimentDecorator
    {
        private Beverage beverage;

        public Сaramel(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Сaramel";
        }

        public override double cost()
        {
            return PriceList.caramelPrice + beverage.cost();
        }
    }
}
