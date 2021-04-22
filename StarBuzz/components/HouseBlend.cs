using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = Description.houseBlend;
        }

        public override double cost()
        {
            return PriceList.houseBlendPrice;
        }
    }
}
