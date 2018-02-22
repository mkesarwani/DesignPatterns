using DesignPatterns.Behavioral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPattern strategy = new StrategyPattern();
            Console.WriteLine();
            ObserverPattern observer = new ObserverPattern();
            Console.WriteLine();
            DecoratorPattern decotrator = new DecoratorPattern();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
