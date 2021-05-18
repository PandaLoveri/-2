using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.post
{
    class Director : Wage
    {
        public Director()
        {
            description = Names.director;
        }

        public override double payout()
        {
            return Pricing.directorSalary;
        }
    }
}
