using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample.Ducks
{
    public class ExoticDuck: DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("\nHello! I'm Exotic Duck.");
        }
    }
}
