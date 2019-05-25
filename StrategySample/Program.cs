using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategySample.Ducks;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===DESIGN PATTERNS - STRATEGY SAMPLE===");
            Console.WriteLine("\n=======Lake with different ducks=======");

            // Создаем список из DuckBase
            //List<DuckBase> ducks = new List<DuckBase>();
            List<DuckBase> ducks = new List<DuckBase>();
            // Добавлю в ducks несколько новых уток
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());

            foreach(var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
            }

            Console.ReadLine();
        }
    }
}
