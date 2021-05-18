using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.post
{
    class Junior : Wage
    {
        public Junior()
        {
            description = Names.junior;
        }

        public override double payout()
        {
            return Pricing.juniorSalary;
        }
    }
}
