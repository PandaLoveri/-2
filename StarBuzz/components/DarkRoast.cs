using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz.components
{
    class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
