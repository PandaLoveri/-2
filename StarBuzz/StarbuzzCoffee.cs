﻿using System;
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
            Console.WriteLine(beverage.getDescription()+" $"+beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());

            Beverage beverage4 = new IceTea();
            beverage4 = new Сaramel(beverage4);
            Console.WriteLine(beverage4.getDescription() + " $" + beverage4.cost());
        }
    }
}
