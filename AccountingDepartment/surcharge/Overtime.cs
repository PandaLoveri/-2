using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.surcharge
{
    class Overtime : SurchargesDecorator
    {
        private Wage wage;

        public Overtime(Wage wage)
        { this.wage = wage; }

        public override string getDescription()
        { return wage.getDescription(); }

        public override Dictionary<string, int> getSurcharges()
        {
            Dictionary<string, int> temp = wage.getSurcharges();
            if (!temp.ContainsKey(Names.overtime))
            {
                temp.Add(Names.overtime, 0);
            }
            temp[Names.overtime]++;
            return temp;
        }

        public override double payout()
        { return wage.payout() + (Pricing.overtimeBonus + 100) / 100; }
    }
}
