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
            return beverage.getDescription();
        }

        public override Dictionary<string, int> getCondiments()
        {
            Dictionary<string, int> temp = beverage.getCondiments();
            if (!temp.ContainsKey(Description.discount))
            {
                temp.Add(Description.discount, 0);
            }
            temp[Description.discount]++;
            return temp;
        }

        public override double cost()
        {
            return Math.Round(beverage.cost() * (100 - PriceList.discount) / 100, 2);
        }
    }
}
