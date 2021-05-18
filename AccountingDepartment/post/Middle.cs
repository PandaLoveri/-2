using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.post
{
    class Middle : Wage
    {
        public Middle()
        {
            description = Names.middle;
        }

        public override double payout()
        {
            return Pricing.middleSalary;
        }
    }
}
