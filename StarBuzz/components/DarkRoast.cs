using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description = Description.darkRoast;
        }

        public override double cost()
        {
            return PriceList.darkRoastPrice;
        }
    }
}
