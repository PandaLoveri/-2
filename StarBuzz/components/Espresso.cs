using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    public class Espresso: Beverage
    {
        public Espresso()
        {
            description = Description.espresso;
        }

        public override double cost()
        {
            return PriceList.espressoPrice;
        }
    }
}
