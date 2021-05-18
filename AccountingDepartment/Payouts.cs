using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingDepartment.post;
using AccountingDepartment.surcharge;

namespace AccountingDepartment
{
    class Payouts
    {
        static void Main(string[] args)
        {
            Wage ivanov = new Director();
            ivanov = new Overtime(ivanov);
            ivanov = new Premium(ivanov);
            Console.WriteLine(ivanov.info());

            Wage petrov = new Junior();
            petrov = new Late(petrov);
            petrov = new Late(petrov);
            petrov = new Late(petrov);
            Console.WriteLine(petrov.info());

            Wage novikov = new Middle();
            novikov = new Late(novikov);
            novikov = new Overtime(novikov);
            novikov = new Overtime(novikov);
            novikov = new Deal(novikov);
            Console.WriteLine(novikov.info());

            Wage andreev = new Middle();
            andreev = new Overtime(andreev);
            andreev = new Overtime(andreev);
            andreev = new Deal(andreev);
            andreev = new Deal(andreev);
            andreev = new Deal(andreev);
            andreev = new Deal(andreev);
            andreev = new Premium(andreev);
            Console.WriteLine(andreev.info());
        }
    }
}
