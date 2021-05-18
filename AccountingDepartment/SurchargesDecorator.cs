using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment
{
    public abstract class SurchargesDecorator : Wage
    {
        public abstract override string getDescription();
        public abstract override Dictionary<String, int> getSurcharges();
    }
}
