using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample.Ducks
{
    public class SimpleDuck: DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("\nHOOO!!! I'm a simple Duck!");
        }
    }
}
