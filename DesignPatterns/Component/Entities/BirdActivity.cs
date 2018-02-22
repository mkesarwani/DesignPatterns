using DesignPatterns.Component.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Component.Entities
{
    public class SimpleFlyActivity : IBirdActivity
    {
        public void Do()
        {
            Console.WriteLine($"Simply flying....");
        }
    }

    public class JetFlyActivity : IBirdActivity
    {
        public void Do()
        {
            Console.WriteLine($"Very Fast Jet flying....");
        }
    }

    public class NoFlyActivity : IBirdActivity
    {
        public void Do()
        {
            Console.WriteLine($"Sorry, Can't Fly....");
        }
    }

    public class SmallFlyActivity : IBirdActivity
    {
        public void Do()
        {
            Console.WriteLine($"Very Small Flyier....");
        }
    }

    public class HighFlyActivity : IBirdActivity
    {
        public void Do()
        {
            Console.WriteLine($"Simply flying....");
        }
    }
}
