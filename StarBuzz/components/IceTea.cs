using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class IceTea : Beverage
    {
        public IceTea()
        {
            description = Description.iceTea;
        }

        public override double cost()
        {
            return PriceList.iceTeaPrice;
        }
    }
}
