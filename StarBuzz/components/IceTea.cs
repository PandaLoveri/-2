using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class IceTea : Beverage
    {
        public IceTea()
        {
            description = "IceTea";
        }

        public override double cost()
        {
            return 0.69;
        }
    }
}
