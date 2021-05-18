using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment
{
    public abstract class Wage
    {
        protected string description = "Зарплата";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double payout();

        public Dictionary<string, int> surcharges = new Dictionary<string, int>();

        public virtual Dictionary<string, int> getSurcharges()
        {
            return surcharges;
        }

        public string info()
        {
            string des = "";
            foreach (var surch in getSurcharges())
                des += $" {surch.Value} {surch.Key},";
            return getDescription() + ":" + des + " WAGE:" + payout() + " Р";
        }
    }
}
