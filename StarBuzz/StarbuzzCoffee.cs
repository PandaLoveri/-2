using System;
using System.Collections.Generic;
using StarBuzz.components;
using StarBuzz.decorators;

namespace StarBuzz
{
    class StarbuzzCoffee
    {        
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Сaramel(beverage);
            Console.WriteLine(beverage.info());

            Beverage beverage1 = new Espresso();
            beverage1 = new Сaramel(beverage1);
            beverage1 = new Сaramel(beverage1);
            Console.WriteLine(beverage1.info());

            Beverage beverage2 = new DarkRoast();            
            beverage2 = new Whip(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Discount(beverage2);
            Console.WriteLine(beverage2.info());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            beverage3 = new Soy(beverage3);
            Console.WriteLine(beverage3.info());

            Beverage beverage4 = new IceTea();
            beverage4 = new Сaramel(beverage4);
            Console.WriteLine(beverage4.info());
        }
    }
}
