using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    class Whip:CondimentDecorator
    {
        private Beverage beverage;
        
        public Whip(Beverage beverage)
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
            if (!temp.ContainsKey(Description.whip))
            {
                temp.Add(Description.whip, 0);
            }
            temp[Description.whip]++;
            return temp;
        }

        public override double cost()
        {
            return PriceList.whipPrice + beverage.cost();
        }
    }
}
