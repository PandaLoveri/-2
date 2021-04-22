using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzz
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public Dictionary<string, int> condiments = new Dictionary<string, int>();

        public virtual string getDescription()
        {
            return description;
        }

        public virtual Dictionary<string, int> getCondiments()
        {
            return condiments;
        }

        public abstract double cost();

        public string info()
        {
            string result = "";
            foreach (var condiment in getCondiments())
            {
                if (condiment.Key == "Discount")
                    result += $", Discount";
                else
                    result += $", {condiment.Value} {condiment.Key}";
            }

            return getDescription() + result + " $" +cost();
        }
    }
}
