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
            return beverage.getDescription();
        }

        public override Dictionary<string, int> getCondiments()
        {
            Dictionary<string, int> temp = beverage.getCondiments();
            if (!temp.ContainsKey(Description.mocha))
            {
                temp.Add(Description.mocha, 0);
            }
            temp[Description.mocha]++;
            return temp;
        }

        public override double cost()
        {
            return PriceList.mochaPrice + beverage.cost();
        }
    }
}
