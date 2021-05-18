using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.surcharge
{
    class Late : SurchargesDecorator
    {
        private Wage wage;

        public Late(Wage wage)
        { this.wage = wage; }

        public override string getDescription()
        { return wage.getDescription(); }

        public override Dictionary<string, int> getSurcharges()
        {
            Dictionary<string, int> temp = wage.getSurcharges();
            if (!temp.ContainsKey(Names.late))
            {
                temp.Add(Names.late, 0);
            }
            temp[Names.late]++;
            return temp;
        }

        public override double payout()
        { return wage.payout() - Pricing.lateFee; }
    }
}
