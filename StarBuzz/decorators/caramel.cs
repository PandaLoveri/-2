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
            return beverage.getDescription();
        }

        public override Dictionary<string, int> getCondiments()
        {
            Dictionary<string, int> temp = beverage.getCondiments();
            if (!temp.ContainsKey(Description.caramel))
            {
                temp.Add(Description.caramel, 0);
            }
            temp[Description.caramel]++;            
            return temp;
        }

        public override double cost()
        {
            return PriceList.caramelPrice + beverage.cost();
        }
    }
}
