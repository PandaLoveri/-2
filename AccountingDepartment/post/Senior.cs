using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.post
{
    class Senior : Wage
    {
        public Senior()
        {
            description = Names.senior;
        }

        public override double payout()
        {
            return Pricing.seniorSalary;
        }
    }
}
