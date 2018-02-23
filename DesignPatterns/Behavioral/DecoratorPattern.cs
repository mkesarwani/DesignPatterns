using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Component;

namespace DesignPatterns.Behavioral
{

    public class DecoratorPattern
    {
        public DecoratorPattern()
        {
            PizzaToppings toppings;
            VegPizza vp = new VegPizza();
            Console.WriteLine($"Veg Prize : {vp.Cost()}");
            toppings = new BroccoliToppings(vp);
            Console.WriteLine($"Veg Pizz with topping - {toppings.Name} : {toppings.Cost()}");
            toppings = new RomaTomatoesToppings(toppings);
            Console.WriteLine($"Veg Pizz with topping - {toppings.Name} : {toppings.Cost()}");
            toppings = new RomaTomatoesToppings(toppings);
            Console.WriteLine($"Veg Pizz with topping - {toppings.Name} : {toppings.Cost()}");
            toppings = new PineappleToppings(toppings);
            Console.WriteLine($"Veg Pizz with topping - {toppings.Name} : {toppings.Cost()}");
            toppings = new OlivesToppings(toppings);
            Console.WriteLine($"Veg Pizz with topping - {toppings.Name} : {toppings.Cost()}");
           
        }
    }

    abstract class Pizza
    {
        public abstract int Cost();
    }

    class VegPizza : Pizza
    {
        public override int Cost()
        {
            return 100;
        }
    }

    abstract class PizzaToppings : Pizza
    {
        public string Name { get; set; }
        protected Pizza pizza;
        public PizzaToppings(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public abstract override int Cost();
    }
    class RomaTomatoesToppings : PizzaToppings
    {
        public RomaTomatoesToppings(Pizza pizza) : base(pizza)
        {
            this.Name = "Roma Tomatoes";
        }
        public override int Cost()
        {
            return this.pizza.Cost() + Constants.RomaTomatoCost;
        }
    }

    class BroccoliToppings : PizzaToppings
    {
        public BroccoliToppings(Pizza pizza) : base(pizza)
        {
            this.Name = "Broccoli";
        }
        public override int Cost()
        {
            return this.pizza.Cost() + Constants.BroccoliCost;
        }
    }

    class OlivesToppings : PizzaToppings
    {
        public OlivesToppings(Pizza pizza) : base(pizza)
        {
            this.Name = "Olives";
        }
        public override int Cost()
        {
            return this.pizza.Cost() + Constants.OlivesCost;
        }
    }

    class PineappleToppings : PizzaToppings
    {
        public PineappleToppings(Pizza pizza) : base(pizza)
        {
            this.Name = "Pineapple";
        }
        public override int Cost()
        {
            return this.pizza.Cost() + Constants.PineappleCost;
        }
    }

}