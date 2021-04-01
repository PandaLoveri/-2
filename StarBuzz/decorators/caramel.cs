using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.decorators
{
    public class Сaramel:CondinmentDecorator
    {
        Beverage beverage;

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
            return 0.25 + beverage.cost();
        }
    }
}
