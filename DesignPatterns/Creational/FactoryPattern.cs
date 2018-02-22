using DesignPatterns.Component.Entities;
using DesignPatterns.Component.Entity;
using DesignPatterns.Component.Enums;
using DesignPatterns.Component.Interfaces;
using System;

namespace DesignPatterns.Creational
{
    public class BirdFactory : IFactory
    {
        public IBird Get(string type)
        {
            BirdType bt = (BirdType)Enum.Parse(typeof(BirdType), type);
            IBird bird;
            switch (bt)
            {
                case BirdType.Crow:
                    bird = new Bird("Black Crow", bt);
                    bird.Fly = new SimpleFlyActivity();
                    break;

                case BirdType.Duck:
                    bird = new Bird("White Pond Duck", bt);
                    bird.Fly = new SmallFlyActivity();
                    break;

                case BirdType.Eagle:
                    bird = new Bird("Grey Eagle", bt);
                    bird.Fly = new JetFlyActivity();
                    break;

                case BirdType.Owls:

                    bird = new Bird("Brown Owl", bt);
                    bird.Fly = new SmallFlyActivity();
                    break;
                case BirdType.Rubber:
                    bird = new Bird("Yellow Rubber Duck", bt);
                    bird.Fly = new NoFlyActivity();
                    break;

                case BirdType.Simple:
                default:
                    bird = new Bird("Simple White Bird", bt);
                    bird.Fly = new SimpleFlyActivity();
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("________________________");
            Console.WriteLine($"{bird.ToString()}");
            return bird;
        }
    }
}
