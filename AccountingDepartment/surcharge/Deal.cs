using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.surcharge
{
    class Deal : SurchargesDecorator
    {
        private Wage wage;

        public Deal(Wage wage)
        { this.wage = wage; }

        public override string getDescription()
        { return wage.getDescription(); }

        public override Dictionary<string, int> getSurcharges()
        {
            Dictionary<string, int> temp = wage.getSurcharges();
            if (!temp.ContainsKey(Names.deal))
            {
                temp.Add(Names.deal, 0);
            }
            temp[Names.deal]++;
            return temp;
        }

        public override double payout()
        { return Pricing.dealBonus + wage.payout(); }
    }
}
