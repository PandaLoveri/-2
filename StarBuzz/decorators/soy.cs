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

        public override double cost()
        {
            return PriceList.soyPrice + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription();
        }

        public override Dictionary<string, int> getCondiments()
        {
            Dictionary<string, int> temp = beverage.getCondiments();
            if (!temp.ContainsKey(Description.soy))
            {
                temp.Add(Description.soy, 0);
            }
            temp[Description.soy]++;
            return temp;
        }
    }
}
