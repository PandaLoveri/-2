using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingDepartment
{
    class Pricing
    {
        public static double juniorSalary = 12000;
        public static double middleSalary = 18000;
        public static double seniorSalary = 24000;
        public static double directorSalary = 35000;

        public static int premium = 20; // % премии
        
        public static double overtimeBonus = 2; // % к з\п за каждый сверхурочный день
        public static double dealBonus = 600; // бонус за закрытый заказ
        public static double tripBonus = 400; // бонус за выезд
        public static double lateFee = 500; // штраф за опоздание
    }
}
