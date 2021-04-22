using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = Description.decaf;
        }

        public override double cost()
        {
            return PriceList.decafPrice;
        }
    }
}
