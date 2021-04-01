using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
