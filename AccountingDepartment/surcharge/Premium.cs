using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.surcharge
{
    class Premium : SurchargesDecorator
    {
        private Wage wage;

        public Premium(Wage wage)
        { this.wage = wage; }

        public override string getDescription()
        { return wage.getDescription(); }

        public override Dictionary<string, int> getSurcharges()
        {
            Dictionary<string, int> temp = wage.getSurcharges();
            if (!temp.ContainsKey(Names.premium))
            {
                temp.Add(Names.premium, 0);
            }
            temp[Names.premium]++;
            return temp;
        }

        public override double payout()
        { return wage.payout() * (Pricing.premium + 100) / 100; }
    }
}
