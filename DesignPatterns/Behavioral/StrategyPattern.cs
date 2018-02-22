using DesignPatterns.Component.Interfaces;
using DesignPatterns.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral
{
    class StrategyPattern
    {
        private IFactory birdFactory;
        public StrategyPattern()
        {
            birdFactory = new BirdFactory();
            IBird simpleBird = birdFactory.Get("Simple");
            simpleBird.Fly.Do();

            IBird rubberBird = birdFactory.Get("Rubber");
            rubberBird.Fly.Do();

            IBird eagleBird = birdFactory.Get("Eagle");
            eagleBird.Fly.Do();

            IBird crowBird = birdFactory.Get("Crow");
            crowBird.Fly.Do();

            IBird duckBird = birdFactory.Get("Duck");
            duckBird.Fly.Do();

            IBird OwlsBird = birdFactory.Get("Owls");
            OwlsBird.Fly.Do();
        }
    }










}
