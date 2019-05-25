using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample.Ducks
{
    public abstract class DuckBase
    {
        public void Quack()
        {
            Console.WriteLine("Qua... Qua... Quack!");
        }
        public void Swim()
        {
            Console.WriteLine("Now I'm swimming");
        }
        public abstract void Display();
    }
}
