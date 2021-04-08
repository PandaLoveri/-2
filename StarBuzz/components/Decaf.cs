using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double cost()
        {
            return PriceList.decafPrice;
        }
    }
}
