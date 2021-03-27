using System;
using System.Collections.Generic;
using System.Text;
using DuckSwim.interfaces;

namespace DuckSwim.behaviors
{
    class SurfaceSwim : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("surface swim");
        }
    }

}
