using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment.surcharge
{
    class Trip : SurchargesDecorator
    {
        private Wage wage;

        public Trip(Wage wage)
        { this.wage = wage; }

        public override string getDescription()
        { return wage.getDescription(); }

        public override Dictionary<string, int> getSurcharges()
        {
            Dictionary<string, int> temp = wage.getSurcharges();
            if (!temp.ContainsKey(Names.trips))
            {
                temp.Add(Names.trips, 0);
            }
            temp[Names.trips]++;
            return temp;
        }

        public override double payout()
        { return Pricing.tripBonus + wage.payout(); }
    }
}
