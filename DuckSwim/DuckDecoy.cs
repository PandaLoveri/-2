using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.behaviors;

namespace DuckSwim
{
    class DuckDecoy
    {
        public void PerformQuack()
        {
            Quackle quackleObject = new Quackle();
            quackleObject.Quack();
        }
    }
}
